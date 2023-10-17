using Countdowns.Classes;
using Countdowns.Forms;

namespace Countdowns
{
    public partial class MainForm : Form
    {
        bool colored = true;

        public MainForm()
        {
            InitializeComponent();
            RefreshCountdowns(true);
            timerMain.Enabled = true;
        }

        private void RefreshCountdowns(bool full)
        {
            if (full)
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
                    (tlpCountdowns.Controls[i] as ucCountown).SetCountdown(CountdownsCollection.GetInstance().Countdowns[i]);
        }

        private void Uc_CountdownDeleted(object? sender, Countdown e)
        {
            RefreshCountdowns(true);
        }

        private void Uc_CountdownEdited(object? sender, Countdown e)
        {
            RefreshCountdowns(false);
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            Countdown countdown = new Countdown();
            FormCountdown form = new FormCountdown(countdown);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CountdownsCollection.Add(countdown);
            CountdownsCollection.Save();
            RefreshCountdowns(true);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            foreach (Control control in tlpCountdowns.Controls)
                if (control is ucCountown)
                    (control as ucCountown).RefreshUC(colored);
            colored = !colored;
        }
    }
}