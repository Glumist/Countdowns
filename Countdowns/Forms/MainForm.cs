using Countdowns.Classes;
using Countdowns.Forms;

namespace Countdowns
{
    public partial class MainForm : Form
    {
        bool colored = true;
        Dictionary<Countdown, ucCountown> countdownsUCs;

        public MainForm()
        {
            InitializeComponent();
            countdownsUCs = new Dictionary<Countdown, ucCountown>();
            RefreshCountdowns();
            timerMain.Enabled = true;
            CountdownsCollection.GetInstance().OnCollectionChange += CountdownsCollection_OnCollectionChange;
        }

        private void CountdownsCollection_OnCollectionChange(object sender, EventArgs e) => RefreshCountdowns();        

        private void RefreshCountdowns()
        {            
            tlpCountdowns.SuspendLayout();
            tlpCountdowns.RowCount = CountdownsCollection.GetInstance().Countdowns.Count;
            tlpCountdowns.Controls.Clear();

            foreach (Countdown countdown in CountdownsCollection.GetInstance().Countdowns)
            {
                if (!countdownsUCs.ContainsKey(countdown))
                {
                    ucCountown uc = new ucCountown(countdown);
                    countdownsUCs[countdown] = uc;
                    countdownsUCs[countdown].Dock = DockStyle.Fill;
                }
                tlpCountdowns.Controls.Add(countdownsUCs[countdown]);
            }
            tlpCountdowns.ResumeLayout();
            /*if (full)
            {
                tlpCountdowns.RowCount = CountdownsCollection.GetInstance().Countdowns.Count;
                tlpCountdowns.Controls.Clear();
                foreach (Countdown countdown in CountdownsCollection.GetInstance().Countdowns)
                {
                    ucCountown uc = new ucCountown(countdown);
                    tlpCountdowns.Controls.Add(uc);
                    uc.Dock = DockStyle.Fill;
                    uc.CountdownAdded += tsmiAdd_Click;
                    uc.CountdownEdited += Uc_CountdownEdited;
                    uc.CountdownDeleted += Uc_CountdownDeleted;
                }
            }
            else
                for (int i = 0; i < CountdownsCollection.GetInstance().Countdowns.Count; i++)
                    (tlpCountdowns.Controls[i] as ucCountown).SetCountdown(CountdownsCollection.GetInstance().Countdowns[i]);*/
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            new FormCountdown().ShowDialog();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            foreach (ucCountown control in countdownsUCs.Values)                
                control.RefreshUC(colored);
            colored = !colored;
        }
    }
}