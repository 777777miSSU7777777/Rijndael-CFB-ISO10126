namespace Rijndael_CFB_ISO10116
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.CryptoButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.KeyValueLabel = new System.Windows.Forms.Label();
            this.IVValueLabel = new System.Windows.Forms.Label();
            this.EncryptMode = new System.Windows.Forms.RadioButton();
            this.DecryptMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(30, 29);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(400, 100);
            this.InputTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(30, 158);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(400, 100);
            this.OutputTextBox.TabIndex = 1;
            // 
            // CryptoButton
            // 
            this.CryptoButton.Location = new System.Drawing.Point(436, 132);
            this.CryptoButton.Name = "CryptoButton";
            this.CryptoButton.Size = new System.Drawing.Size(120, 23);
            this.CryptoButton.TabIndex = 2;
            this.CryptoButton.Text = "Crypt";
            this.CryptoButton.UseVisualStyleBackColor = true;
            this.CryptoButton.Click += new System.EventHandler(this.CryptoButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(30, 13);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Input";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(30, 132);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Output";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(436, 29);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(66, 13);
            this.ModeLabel.TabIndex = 6;
            this.ModeLabel.Text = "Crypto mode";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(436, 109);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(117, 20);
            this.KeyTextBox.TabIndex = 7;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(436, 88);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(25, 13);
            this.KeyLabel.TabIndex = 8;
            this.KeyLabel.Text = "Key";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(433, 158);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(25, 13);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.Text = "Info";
            // 
            // KeyValueLabel
            // 
            this.KeyValueLabel.AutoSize = true;
            this.KeyValueLabel.Location = new System.Drawing.Point(9, 261);
            this.KeyValueLabel.Name = "KeyValueLabel";
            this.KeyValueLabel.Size = new System.Drawing.Size(52, 13);
            this.KeyValueLabel.TabIndex = 10;
            this.KeyValueLabel.Text = "KeyValue";
            // 
            // IVValueLabel
            // 
            this.IVValueLabel.AutoSize = true;
            this.IVValueLabel.Location = new System.Drawing.Point(9, 305);
            this.IVValueLabel.Name = "IVValueLabel";
            this.IVValueLabel.Size = new System.Drawing.Size(47, 13);
            this.IVValueLabel.TabIndex = 11;
            this.IVValueLabel.Text = "IV Value";
            // 
            // EncryptMode
            // 
            this.EncryptMode.AutoSize = true;
            this.EncryptMode.Location = new System.Drawing.Point(439, 45);
            this.EncryptMode.Name = "EncryptMode";
            this.EncryptMode.Size = new System.Drawing.Size(61, 17);
            this.EncryptMode.TabIndex = 12;
            this.EncryptMode.TabStop = true;
            this.EncryptMode.Text = "Encrypt";
            this.EncryptMode.UseVisualStyleBackColor = true;
            // 
            // DecryptMode
            // 
            this.DecryptMode.AutoSize = true;
            this.DecryptMode.Location = new System.Drawing.Point(439, 68);
            this.DecryptMode.Name = "DecryptMode";
            this.DecryptMode.Size = new System.Drawing.Size(62, 17);
            this.DecryptMode.TabIndex = 13;
            this.DecryptMode.TabStop = true;
            this.DecryptMode.Text = "Decrypt";
            this.DecryptMode.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.DecryptMode);
            this.Controls.Add(this.EncryptMode);
            this.Controls.Add(this.IVValueLabel);
            this.Controls.Add(this.KeyValueLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.CryptoButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View";
            this.Text = "Rijndael CFB ISO 10126";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button CryptoButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label KeyValueLabel;
        private System.Windows.Forms.Label IVValueLabel;
        private System.Windows.Forms.RadioButton EncryptMode;
        private System.Windows.Forms.RadioButton DecryptMode;
    }
}

