using Countdowns.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdowns.Forms
{
    public partial class ucCountown : UserControl
    {
        public Countdown Countdown;

        public ucCountown(Countdown countdown)
        {
            InitializeComponent();

            Countdown = countdown;
            RefreshUC();
        }

        public void RefreshUC(bool colored = true)
        {
            if (lName.Text != Countdown.Name)
                lName.Text = Countdown.Name;
            if (tbEndTime.Text != Countdown.EndTimeString)
                tbEndTime.Text = Countdown.EndTimeString;
            if (Countdown.TotalMinutes.HasValue)
            {
                if (pbProgress.Maximum != Countdown.TotalMinutes.Value)
                {
                    pbProgress.Value = 0;
                    pbProgress.Maximum = Countdown.TotalMinutes.Value;
                }
                int minutesLeft = (int)Countdown.TimeLeft.TotalMinutes;
                int newValue = minutesLeft > 0 ? Countdown.TotalMinutes.Value > minutesLeft ? Countdown.TotalMinutes.Value - minutesLeft : 0 : pbProgress.Maximum;
                if (pbProgress.Value != newValue)
                    pbProgress.Value = newValue;
            }
            bool progressVisible = Countdown.TotalMinutes.HasValue && Countdown.TimeLeft != TimeSpan.Zero;
            if (pbProgress.Visible != progressVisible)
                pbProgress.Visible = progressVisible;
            if (btRestart.Enabled != Countdown.TotalMinutes.HasValue)
                btRestart.Enabled = Countdown.TotalMinutes.HasValue;
            tbTimeLeft.Text = Countdown.TimeLeftString;
            if (BackColor != Countdown.Color)
                BackColor = Countdown.Color;
            else if (Countdown.IsBlinking && !colored)
                BackColor = Color.Transparent;
        }

        public void SetCountdown(Countdown countdown)
        {
            if (Countdown == countdown)
                return;

            Countdown = countdown;
            RefreshUC();
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            if (Countdown.TotalMinutes.HasValue)
                Countdown.EndTime = DateTime.Now.AddMinutes(Countdown.TotalMinutes.Value);
            CountdownsCollection.Save();

            RefreshUC();
            OnCountdownEdited(Countdown);
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            FormCountdown form = new FormCountdown(Countdown);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CountdownsCollection.Save();

            RefreshUC();
            OnCountdownEdited(Countdown);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            CountdownsCollection.GetInstance().Countdowns.Remove(Countdown);
            CountdownsCollection.Save();
            OnCountdownDeleted(Countdown);
        }

        public event EventHandler CountdownAdded;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnCountdownAdded()
        {
            CountdownAdded?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<Countdown> CountdownEdited;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnCountdownEdited(Countdown countdown)
        {
            CountdownEdited?.Invoke(this, countdown);
        }

        public event EventHandler<Countdown> CountdownDeleted;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnCountdownDeleted(Countdown countdown)
        {
            CountdownDeleted?.Invoke(this, countdown);
        }

        private void cmsCountdown_Opening(object sender, CancelEventArgs e)
        {
            tsmiDecrease.Enabled = Countdown.DecreaseMinutes.HasValue;
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            OnCountdownAdded();
        }

        private void tsmiDecrease_Click(object sender, EventArgs e)
        {
            if (!Countdown.DecreaseMinutes.HasValue)
                return;

            Countdown.EndTime -= TimeSpan.FromMinutes(Countdown.DecreaseMinutes.Value);
            CountdownsCollection.Save();

            RefreshUC();
            OnCountdownEdited(Countdown);
        }
    }
}