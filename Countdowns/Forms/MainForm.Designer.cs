namespace Countdowns
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlpCountdowns = new TableLayoutPanel();
            timerMain = new System.Windows.Forms.Timer(components);
            cmsMain = new ContextMenuStrip(components);
            tsmiAdd = new ToolStripMenuItem();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCountdowns
            // 
            tlpCountdowns.AutoSize = true;
            tlpCountdowns.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCountdowns.ColumnCount = 1;
            tlpCountdowns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCountdowns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCountdowns.Dock = DockStyle.Top;
            tlpCountdowns.Location = new Point(0, 0);
            tlpCountdowns.Name = "tlpCountdowns";
            tlpCountdowns.RowCount = 1;
            tlpCountdowns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCountdowns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCountdowns.Size = new Size(846, 0);
            tlpCountdowns.TabIndex = 1;
            // 
            // timerMain
            // 
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // cmsMain
            // 
            cmsMain.ImageScalingSize = new Size(24, 24);
            cmsMain.Items.AddRange(new ToolStripItem[] { tsmiAdd });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new Size(171, 36);
            // 
            // tsmiAdd
            // 
            tsmiAdd.Image = Properties.Resources.IconPlus;
            tsmiAdd.Name = "tsmiAdd";
            tsmiAdd.Size = new Size(170, 32);
            tsmiAdd.Text = "Добавить";
            tsmiAdd.Click += tsmiAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(846, 1077);
            ContextMenuStrip = cmsMain;
            Controls.Add(tlpCountdowns);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Счетчики";
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpCountdowns;
        private System.Windows.Forms.Timer timerMain;
        private ContextMenuStrip cmsMain;
        private ToolStripMenuItem tsmiAdd;
    }
}