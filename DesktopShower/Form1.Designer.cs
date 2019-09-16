namespace DesktopShower
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IpInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startServerBtn = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonPortFix = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // IpInfo
            // 
            this.IpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IpInfo.Location = new System.Drawing.Point(78, 32);
            this.IpInfo.Name = "IpInfo";
            this.IpInfo.Size = new System.Drawing.Size(76, 18);
            this.IpInfo.TabIndex = 1;
            this.IpInfo.Text = "ipInfo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP of server:";
            // 
            // startServerBtn
            // 
            this.startServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startServerBtn.Location = new System.Drawing.Point(54, 124);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(125, 26);
            this.startServerBtn.TabIndex = 3;
            this.startServerBtn.Text = "ЗАПУСК";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portTextBox.Location = new System.Drawing.Point(45, 53);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(64, 20);
            this.portTextBox.TabIndex = 4;
            this.portTextBox.Text = "8080";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.Location = new System.Drawing.Point(8, 56);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(31, 17);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "Port:";
            // 
            // buttonPortFix
            // 
            this.buttonPortFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPortFix.Location = new System.Drawing.Point(115, 53);
            this.buttonPortFix.Name = "buttonPortFix";
            this.buttonPortFix.Size = new System.Drawing.Size(125, 20);
            this.buttonPortFix.TabIndex = 6;
            this.buttonPortFix.Text = "Зафиксировать порт";
            this.buttonPortFix.UseVisualStyleBackColor = true;
            this.buttonPortFix.Click += new System.EventHandler(this.buttonPortFix_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.Yellow;
            this.labelStatus.Location = new System.Drawing.Point(238, 95);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(212, 187);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Сервер отключен.";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetting.Controls.Add(this.portTextBox);
            this.groupBoxSetting.Controls.Add(this.IpInfo);
            this.groupBoxSetting.Controls.Add(this.startServerBtn);
            this.groupBoxSetting.Controls.Add(this.buttonPortFix);
            this.groupBoxSetting.Controls.Add(this.label1);
            this.groupBoxSetting.Controls.Add(this.labelPort);
            this.groupBoxSetting.Location = new System.Drawing.Point(431, -1);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(246, 156);
            this.groupBoxSetting.TabIndex = 8;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Настройки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 362);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IpInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonPortFix;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxSetting;
    }
}

