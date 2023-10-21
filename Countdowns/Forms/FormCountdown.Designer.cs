namespace Countdowns.Forms
{
    partial class FormCountdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountdown));
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chbRegular = new CheckBox();
            nudHours = new NumericUpDown();
            nudMinutes = new NumericUpDown();
            label4 = new Label();
            dtpEndTime = new DateTimePicker();
            btColor = new Button();
            btOk = new Button();
            btCancel = new Button();
            cdSelect = new ColorDialog();
            nudDecrease = new NumericUpDown();
            label5 = new Label();
            gbBlink = new GroupBox();
            nudBlinkMinutes = new NumericUpDown();
            rbBeforeAndAfterEnd = new RadioButton();
            rbBeforeEnd = new RadioButton();
            rbWhileCounting = new RadioButton();
            rbAfterEnd = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDecrease).BeginInit();
            gbBlink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBlinkMinutes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(12, 37);
            tbName.Name = "tbName";
            tbName.Size = new Size(577, 31);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Часы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 84);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = "Минуты";
            // 
            // chbRegular
            // 
            chbRegular.AutoSize = true;
            chbRegular.Location = new Point(12, 84);
            chbRegular.Name = "chbRegular";
            chbRegular.Size = new Size(135, 29);
            chbRegular.TabIndex = 4;
            chbRegular.Text = "Регулярный";
            chbRegular.UseVisualStyleBackColor = true;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(257, 82);
            nudHours.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(117, 31);
            nudHours.TabIndex = 5;
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(480, 82);
            nudMinutes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(106, 31);
            nudMinutes.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 131);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Окончание";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpEndTime.CustomFormat = "ddMMMMyyyy HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(113, 131);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(261, 31);
            dtpEndTime.TabIndex = 8;
            // 
            // btColor
            // 
            btColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btColor.FlatStyle = FlatStyle.Flat;
            btColor.Location = new Point(12, 295);
            btColor.Name = "btColor";
            btColor.Size = new Size(578, 34);
            btColor.TabIndex = 9;
            btColor.Text = "Цвет";
            btColor.UseVisualStyleBackColor = true;
            btColor.Click += btColor_Click;
            // 
            // btOk
            // 
            btOk.Anchor = AnchorStyles.Top;
            btOk.Location = new Point(165, 350);
            btOk.Name = "btOk";
            btOk.Size = new Size(112, 34);
            btOk.TabIndex = 10;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Top;
            btCancel.Location = new Point(283, 350);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(112, 34);
            btCancel.TabIndex = 11;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // nudDecrease
            // 
            nudDecrease.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDecrease.Location = new Point(480, 129);
            nudDecrease.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudDecrease.Name = "nudDecrease";
            nudDecrease.Size = new Size(106, 31);
            nudDecrease.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(380, 131);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 12;
            label5.Text = "Снижение";
            // 
            // gbBlink
            // 
            gbBlink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBlink.Controls.Add(nudBlinkMinutes);
            gbBlink.Controls.Add(rbBeforeAndAfterEnd);
            gbBlink.Controls.Add(rbBeforeEnd);
            gbBlink.Controls.Add(rbWhileCounting);
            gbBlink.Controls.Add(rbAfterEnd);
            gbBlink.Location = new Point(12, 168);
            gbBlink.Name = "gbBlink";
            gbBlink.Size = new Size(577, 110);
            gbBlink.TabIndex = 14;
            gbBlink.TabStop = false;
            gbBlink.Text = "Мерцание";
            // 
            // nudBlinkMinutes
            // 
            nudBlinkMinutes.Location = new Point(468, 63);
            nudBlinkMinutes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBlinkMinutes.Name = "nudBlinkMinutes";
            nudBlinkMinutes.Size = new Size(100, 31);
            nudBlinkMinutes.TabIndex = 4;
            // 
            // rbBeforeAndAfterEnd
            // 
            rbBeforeAndAfterEnd.AutoSize = true;
            rbBeforeAndAfterEnd.Location = new Point(214, 65);
            rbBeforeAndAfterEnd.Name = "rbBeforeAndAfterEnd";
            rbBeforeAndAfterEnd.Size = new Size(250, 29);
            rbBeforeAndAfterEnd.TabIndex = 3;
            rbBeforeAndAfterEnd.Text = "Перед и после окончания";
            rbBeforeAndAfterEnd.UseVisualStyleBackColor = true;
            // 
            // rbBeforeEnd
            // 
            rbBeforeEnd.AutoSize = true;
            rbBeforeEnd.Location = new Point(15, 65);
            rbBeforeEnd.Name = "rbBeforeEnd";
            rbBeforeEnd.Size = new Size(196, 29);
            rbBeforeEnd.TabIndex = 2;
            rbBeforeEnd.Text = "Перед окончанием";
            rbBeforeEnd.UseVisualStyleBackColor = true;
            // 
            // rbWhileCounting
            // 
            rbWhileCounting.AutoSize = true;
            rbWhileCounting.Location = new Point(214, 30);
            rbWhileCounting.Name = "rbWhileCounting";
            rbWhileCounting.Size = new Size(135, 29);
            rbWhileCounting.TabIndex = 1;
            rbWhileCounting.Text = "Пока тикает";
            rbWhileCounting.UseVisualStyleBackColor = true;
            // 
            // rbAfterEnd
            // 
            rbAfterEnd.AutoSize = true;
            rbAfterEnd.Checked = true;
            rbAfterEnd.Location = new Point(15, 30);
            rbAfterEnd.Name = "rbAfterEnd";
            rbAfterEnd.Size = new Size(181, 29);
            rbAfterEnd.TabIndex = 0;
            rbAfterEnd.TabStop = true;
            rbAfterEnd.Text = "После окончания";
            rbAfterEnd.UseVisualStyleBackColor = true;
            // 
            // FormCountdown
            // 
            AcceptButton = btOk;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new Size(601, 400);
            Controls.Add(gbBlink);
            Controls.Add(nudDecrease);
            Controls.Add(label5);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(btColor);
            Controls.Add(dtpEndTime);
            Controls.Add(label4);
            Controls.Add(nudMinutes);
            Controls.Add(nudHours);
            Controls.Add(chbRegular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCountdown";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Счетчик";
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDecrease).EndInit();
            gbBlink.ResumeLayout(false);
            gbBlink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBlinkMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private CheckBox chbRegular;
        private NumericUpDown nudHours;
        private NumericUpDown nudMinutes;
        private Label label4;
        private DateTimePicker dtpEndTime;
        private Button btColor;
        private Button btOk;
        private Button btCancel;
        private ColorDialog cdSelect;
        private NumericUpDown nudDecrease;
        private Label label5;
        private GroupBox gbBlink;
        private NumericUpDown nudBlinkMinutes;
        private RadioButton rbBeforeAndAfterEnd;
        private RadioButton rbBeforeEnd;
        private RadioButton rbWhileCounting;
        private RadioButton rbAfterEnd;
    }
}