namespace GroupAgeParser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.fastMode = new System.Windows.Forms.RadioButton();
            this.detailedMode = new System.Windows.Forms.RadioButton();
            this.parseButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.consoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleTextBox.Location = new System.Drawing.Point(13, 13);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ShortcutsEnabled = false;
            this.consoleTextBox.Size = new System.Drawing.Size(360, 140);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.TabStop = false;
            this.consoleTextBox.Text = "";
            // 
            // fastMode
            // 
            this.fastMode.AutoSize = true;
            this.fastMode.Location = new System.Drawing.Point(145, 159);
            this.fastMode.Name = "fastMode";
            this.fastMode.Size = new System.Drawing.Size(75, 17);
            this.fastMode.TabIndex = 1;
            this.fastMode.TabStop = true;
            this.fastMode.Text = "Fast Mode";
            this.fastMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fastMode.UseVisualStyleBackColor = true;
            this.fastMode.CheckedChanged += new System.EventHandler(this.fastMode_CheckedChanged);
            // 
            // detailedMode
            // 
            this.detailedMode.AutoSize = true;
            this.detailedMode.Location = new System.Drawing.Point(145, 182);
            this.detailedMode.Name = "detailedMode";
            this.detailedMode.Size = new System.Drawing.Size(94, 17);
            this.detailedMode.TabIndex = 2;
            this.detailedMode.TabStop = true;
            this.detailedMode.Text = "Detailed Mode";
            this.detailedMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailedMode.UseVisualStyleBackColor = true;
            this.detailedMode.CheckedChanged += new System.EventHandler(this.detailedMode_CheckedChanged);
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(164, 205);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 3;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // configButton
            // 
            this.configButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configButton.Location = new System.Drawing.Point(164, 234);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(75, 23);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(164, 263);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.detailedMode);
            this.Controls.Add(this.fastMode);
            this.Controls.Add(this.consoleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 340);
            this.MinimumSize = new System.Drawing.Size(400, 340);
            this.Name = "MainForm";
            this.Text = "GroupAgeParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.RadioButton fastMode;
        private System.Windows.Forms.RadioButton detailedMode;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button helpButton;
    }
}

