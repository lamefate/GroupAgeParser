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
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.consoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleTextBox.Location = new System.Drawing.Point(13, 13);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ShortcutsEnabled = false;
            this.consoleTextBox.Size = new System.Drawing.Size(373, 200);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.TabStop = false;
            this.consoleTextBox.Text = "";
            // 
            // fastMode
            // 
            this.fastMode.AutoSize = true;
            this.fastMode.Location = new System.Drawing.Point(392, 13);
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
            this.detailedMode.Location = new System.Drawing.Point(392, 36);
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
            this.parseButton.AutoSize = true;
            this.parseButton.BackColor = System.Drawing.SystemColors.Control;
            this.parseButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.parseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parseButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.parseButton.Image = ((System.Drawing.Image)(resources.GetObject("parseButton.Image")));
            this.parseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parseButton.Location = new System.Drawing.Point(392, 59);
            this.parseButton.Name = "parseButton";
            this.parseButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.parseButton.Size = new System.Drawing.Size(80, 34);
            this.parseButton.TabIndex = 3;
            this.parseButton.Text = "Parse";
            this.parseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parseButton.UseVisualStyleBackColor = false;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // configButton
            // 
            this.configButton.AutoSize = true;
            this.configButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.configButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.configButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.configButton.Image = ((System.Drawing.Image)(resources.GetObject("configButton.Image")));
            this.configButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configButton.Location = new System.Drawing.Point(392, 139);
            this.configButton.Name = "configButton";
            this.configButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.configButton.Size = new System.Drawing.Size(80, 34);
            this.configButton.TabIndex = 4;
            this.configButton.Text = "Config";
            this.configButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(392, 179);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.helpButton.Size = new System.Drawing.Size(80, 34);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopButton.Location = new System.Drawing.Point(392, 99);
            this.stopButton.Name = "stopButton";
            this.stopButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.stopButton.Size = new System.Drawing.Size(80, 34);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.detailedMode);
            this.Controls.Add(this.fastMode);
            this.Controls.Add(this.consoleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 270);
            this.MinimumSize = new System.Drawing.Size(500, 270);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button stopButton;
    }
}

