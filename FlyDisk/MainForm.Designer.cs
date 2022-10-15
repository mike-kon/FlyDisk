namespace FlyDisk
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
            this.BoxShootType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.BtnShoot = new System.Windows.Forms.Button();
            this.SmalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxShootType
            // 
            this.BoxShootType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxShootType.FormattingEnabled = true;
            this.BoxShootType.Location = new System.Drawing.Point(110, 51);
            this.BoxShootType.Name = "BoxShootType";
            this.BoxShootType.Size = new System.Drawing.Size(669, 23);
            this.BoxShootType.TabIndex = 0;
            this.BoxShootType.SelectedIndexChanged += new System.EventHandler(this.BoxShootType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип выстрела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стребльба оп тарелкам. Программа для отладки";
            // 
            // PnlSettings
            // 
            this.PnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSettings.Location = new System.Drawing.Point(22, 80);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(757, 299);
            this.PnlSettings.TabIndex = 3;
            this.PnlSettings.Resize += new System.EventHandler(this.PnlSettings_Resize);
            // 
            // BtnShoot
            // 
            this.BtnShoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShoot.Location = new System.Drawing.Point(22, 398);
            this.BtnShoot.Name = "BtnShoot";
            this.BtnShoot.Size = new System.Drawing.Size(757, 23);
            this.BtnShoot.TabIndex = 4;
            this.BtnShoot.Text = "Запуск";
            this.BtnShoot.UseVisualStyleBackColor = true;
            this.BtnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // SmalButton
            // 
            this.SmalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmalButton.Location = new System.Drawing.Point(685, 12);
            this.SmalButton.Name = "SmalButton";
            this.SmalButton.Size = new System.Drawing.Size(94, 23);
            this.SmalButton.TabIndex = 5;
            this.SmalButton.Text = "Минимизация";
            this.SmalButton.UseVisualStyleBackColor = true;
            this.SmalButton.Click += new System.EventHandler(this.SmalButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SmalButton);
            this.Controls.Add(this.BtnShoot);
            this.Controls.Add(this.PnlSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxShootType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Запуск тарелочки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel PnlSettings;
        private Button BtnShoot;
        private Button SmalButton;
        public ComboBox BoxShootType;
    }
}