using Countdowns.Classes;
using System.ComponentModel;

namespace Countdowns.Forms
{
    public partial class ucCountown : UserControl
    {
        public Countdown Countdown;

        public ucCountown(Countdown countdown)
        {
            InitializeComponent();

            Countdown = countdown;

            lName.DataBindings.Add("Text", countdown, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            //tbEndTime.DataBindings.Add("Text", countdown, "EndTimeString", false, DataSourceUpdateMode.OnPropertyChanged); // не обновляет со сменой суток
            pbProgress.DataBindings.Add("Maximum", countdown, "TotalMinutes", false, DataSourceUpdateMode.OnPropertyChanged);

            RefreshUC();
        }

        public void RefreshUC(bool colored = true)
        {
            //if (lName.Text != Countdown.Name)
            //    lName.Text = Countdown.Name;
            if (tbEndTime.Text != Countdown.EndTimeString)
                tbEndTime.Text = Countdown.EndTimeString;
            /*if (Countdown.TotalMinutes.HasValue)
             {
                 if (pbProgress.Maximum != Countdown.TotalMinutes.Value)
                 {
                     pbProgress.Value = 0;
                     pbProgress.Maximum = Countdown.TotalMinutes.Value;
                 }

             }*/
            bool progressVisible = Countdown.TotalMinutes.HasValue && Countdown.TimeLeft != TimeSpan.Zero;
            if (pbProgress.Visible != progressVisible)
                pbProgress.Visible = progressVisible;
            if (progressVisible)
            {
                int minutesLeft = (int)Countdown.TimeLeft.TotalMinutes;
                int newValue = minutesLeft > 0 ?
                    Countdown.TotalMinutes.Value > minutesLeft ?
                        Countdown.TotalMinutes.Value - minutesLeft : 0
                    : pbProgress.Maximum;
                if (pbProgress.Value != newValue)
                    pbProgress.Value = newValue;
            }
            if (btRestart.Enabled != Countdown.TotalMinutes.HasValue)
                btRestart.Enabled = Countdown.TotalMinutes.HasValue;
            tbTimeLeft.Text = Countdown.TimeLeftString;
            if (BackColor != Countdown.Color)
                BackColor = Countdown.Color;
            else if (Countdown.IsBlinking && !colored)
                BackColor = Color.Transparent;
        }

        /*public void SetCountdown(Countdown countdown)
        {
            if (Countdown == countdown)
                return;

            Countdown = countdown;
            RefreshUC();
        }*/

        private void btRestart_Click(object sender, EventArgs e)
        {
            CountdownsCollection.Restart(Countdown);

            RefreshUC();
        }

        private void cmsCountdown_Opening(object sender, CancelEventArgs e)
        {
            tsmiDecrease.Enabled = Countdown.DecreaseMinutes.HasValue;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            FormCountdown form = new FormCountdown(Countdown);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            RefreshUC();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            CountdownsCollection.Delete(Countdown);
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            new FormCountdown().ShowDialog();
        }

        private void tsmiDecrease_Click(object sender, EventArgs e)
        {
            CountdownsCollection.Decrease(Countdown);

            RefreshUC();
        }
    }
}