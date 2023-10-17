using Countdowns.Classes;

namespace Countdowns.Forms
{
    public partial class FormCountdown : Form
    {
        private Countdown EditedCountdown;

        public FormCountdown(Countdown countdown)
        {
            InitializeComponent();

            EditedCountdown = countdown;

            tbName.Text = countdown.Name;
            chbRegular.Checked = countdown.TotalMinutes.HasValue;
            dtpEndTime.Value = countdown.EndTime;
            btColor.BackColor = countdown.Color;

            if (countdown.TotalMinutes.HasValue)
            {
                decimal minutes = countdown.TotalMinutes.Value;

                if (minutes > 60)
                {
                    decimal hours = Math.Floor(minutes / 60);
                    nudHours.Value = hours;
                    minutes -= hours * 60;
                }
                nudMinutes.Value = minutes;
            }

            if (countdown.DecreaseMinutes.HasValue)
                nudDecrease.Value = countdown.DecreaseMinutes.Value;

            switch (countdown.BlinkType)
            {
                case BlinkType.AfterEnd: rbAfterEnd.Checked = true; break;
                case BlinkType.BeforeEnd: rbBeforeEnd.Checked = true; break;
                case BlinkType.BeforeAndAfterEnd: rbBeforeAndAfterEnd.Checked = true; break;
                case BlinkType.WhileCounting: rbWhileCounting.Checked = true; break;
            }
            if (countdown.BlinkMinutes.HasValue) 
                nudBlinkMinutes.Value = countdown.BlinkMinutes.Value;
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            cdSelect.Color = button.BackColor;
            if (cdSelect.ShowDialog() == DialogResult.OK)
                button.BackColor = cdSelect.Color;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedCountdown.Name = tbName.Text;
            EditedCountdown.TotalMinutes = chbRegular.Checked ? (int)nudHours.Value * 60 + (int)nudMinutes.Value : null;
            EditedCountdown.EndTime = dtpEndTime.Value;
            EditedCountdown.Color = btColor.BackColor;
            EditedCountdown.DecreaseMinutes = nudDecrease.Value > 0 ? (int)nudDecrease.Value : null;

            if (nudBlinkMinutes.Value == 0 && !rbWhileCounting.Checked)
                rbAfterEnd.Checked = true;

            EditedCountdown.BlinkMinutes = null;
            if (rbAfterEnd.Checked)
                EditedCountdown.BlinkType = BlinkType.AfterEnd;
            else if (rbWhileCounting.Checked)
                EditedCountdown.BlinkType = BlinkType.WhileCounting;
            else 
            {
                EditedCountdown.BlinkMinutes = (int)nudBlinkMinutes.Value;
                if (rbBeforeEnd.Checked)
                    EditedCountdown.BlinkType = BlinkType.BeforeEnd;
                else
                    EditedCountdown.BlinkType = BlinkType.BeforeAndAfterEnd;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}