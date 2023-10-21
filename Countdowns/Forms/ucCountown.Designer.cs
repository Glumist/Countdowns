namespace Countdowns.Forms
{
    partial class ucCountown
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lName = new Label();
            pbProgress = new ProgressBar();
            btRestart = new Button();
            tbTimeLeft = new TextBox();
            tbEndTime = new TextBox();
            cmsCountdown = new ContextMenuStrip(components);
            tsmiRestart = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            tsmiDecrease = new ToolStripMenuItem();
            tsmiDelete = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiAdd = new ToolStripMenuItem();
            cmsCountdown.SuspendLayout();
            SuspendLayout();
            // 
            // lName
            // 
            lName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lName.AutoSize = true;
            lName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lName.Location = new Point(3, 11);
            lName.Name = "lName";
            lName.Size = new Size(74, 32);
            lName.TabIndex = 0;
            lName.Text = "name";
            // 
            // pbProgress
            // 
            pbProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbProgress.Location = new Point(458, 11);
            pbProgress.Maximum = 10000;
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(216, 34);
            pbProgress.TabIndex = 2;
            // 
            // btRestart
            // 
            btRestart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRestart.Image = Properties.Resources.IconPlay;
            btRestart.Location = new Point(883, 8);
            btRestart.Name = "btRestart";
            btRestart.Size = new Size(41, 37);
            btRestart.TabIndex = 5;
            btRestart.UseVisualStyleBackColor = true;
            btRestart.Click += btRestart_Click;
            // 
            // tbTimeLeft
            // 
            tbTimeLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTimeLeft.Location = new Point(791, 10);
            tbTimeLeft.Name = "tbTimeLeft";
            tbTimeLeft.ReadOnly = true;
            tbTimeLeft.Size = new Size(86, 31);
            tbTimeLeft.TabIndex = 8;
            tbTimeLeft.TextAlign = HorizontalAlignment.Right;
            // 
            // tbEndTime
            // 
            tbEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEndTime.Location = new Point(680, 11);
            tbEndTime.Name = "tbEndTime";
            tbEndTime.ReadOnly = true;
            tbEndTime.Size = new Size(105, 31);
            tbEndTime.TabIndex = 9;
            tbEndTime.TextAlign = HorizontalAlignment.Right;
            // 
            // cmsCountdown
            // 
            cmsCountdown.ImageScalingSize = new Size(24, 24);
            cmsCountdown.Items.AddRange(new ToolStripItem[] { tsmiRestart, tsmiEdit, tsmiDecrease, tsmiDelete, toolStripSeparator1, tsmiAdd });
            cmsCountdown.Name = "cmsCountdown";
            cmsCountdown.Size = new Size(214, 170);
            cmsCountdown.Opening += cmsCountdown_Opening;
            // 
            // tsmiRestart
            // 
            tsmiRestart.Image = Properties.Resources.IconPlay;
            tsmiRestart.Name = "tsmiRestart";
            tsmiRestart.Size = new Size(213, 32);
            tsmiRestart.Text = "Перезапустить";
            tsmiRestart.Click += btRestart_Click;
            // 
            // tsmiEdit
            // 
            tsmiEdit.Image = Properties.Resources.IconEdit;
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(213, 32);
            tsmiEdit.Text = "Редактировать";
            tsmiEdit.Click += tsmiEdit_Click;
            // 
            // tsmiDecrease
            // 
            tsmiDecrease.Image = Properties.Resources.IconDown;
            tsmiDecrease.Name = "tsmiDecrease";
            tsmiDecrease.Size = new Size(213, 32);
            tsmiDecrease.Text = "Снизить";
            tsmiDecrease.Click += tsmiDecrease_Click;
            // 
            // tsmiDelete
            // 
            tsmiDelete.Image = Properties.Resources.IconTrash;
            tsmiDelete.Name = "tsmiDelete";
            tsmiDelete.Size = new Size(213, 32);
            tsmiDelete.Text = "Удалить";
            tsmiDelete.Click += tsmiDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // tsmiAdd
            // 
            tsmiAdd.Image = Properties.Resources.IconPlus;
            tsmiAdd.Name = "tsmiAdd";
            tsmiAdd.Size = new Size(213, 32);
            tsmiAdd.Text = "Добавить";
            tsmiAdd.Click += tsmiAdd_Click;
            // 
            // ucCountown
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = cmsCountdown;
            Controls.Add(tbEndTime);
            Controls.Add(tbTimeLeft);
            Controls.Add(btRestart);
            Controls.Add(pbProgress);
            Controls.Add(lName);
            Name = "ucCountown";
            Size = new Size(931, 53);
            cmsCountdown.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lName;
        private ProgressBar pbProgress;
        private Button btRestart;
        private TextBox tbTimeLeft;
        private TextBox tbEndTime;
        private ContextMenuStrip cmsCountdown;
        private ToolStripMenuItem tsmiRestart;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiDecrease;
        private ToolStripMenuItem tsmiDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiAdd;
    }
}
