namespace GroupAgeParser
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.valueInput = new System.Windows.Forms.TextBox();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.checkConfig = new System.Windows.Forms.Button();
            this.keysBoxList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(20, 39);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(121, 20);
            this.valueInput.TabIndex = 1;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.AutoSize = true;
            this.saveConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveConfigButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveConfigButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("saveConfigButton.Image")));
            this.saveConfigButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveConfigButton.Location = new System.Drawing.Point(31, 110);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.saveConfigButton.Size = new System.Drawing.Size(110, 34);
            this.saveConfigButton.TabIndex = 2;
            this.saveConfigButton.Text = "Save Config";
            this.saveConfigButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // checkConfig
            // 
            this.checkConfig.AutoSize = true;
            this.checkConfig.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkConfig.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkConfig.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkConfig.Image = ((System.Drawing.Image)(resources.GetObject("checkConfig.Image")));
            this.checkConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkConfig.Location = new System.Drawing.Point(31, 70);
            this.checkConfig.Name = "checkConfig";
            this.checkConfig.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.checkConfig.Size = new System.Drawing.Size(110, 34);
            this.checkConfig.TabIndex = 4;
            this.checkConfig.Text = "Check Value";
            this.checkConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkConfig.UseVisualStyleBackColor = true;
            this.checkConfig.Click += new System.EventHandler(this.checkConfig_Click);
            // 
            // keysBoxList
            // 
            this.keysBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keysBoxList.FormattingEnabled = true;
            this.keysBoxList.Location = new System.Drawing.Point(20, 12);
            this.keysBoxList.Name = "keysBoxList";
            this.keysBoxList.Size = new System.Drawing.Size(121, 21);
            this.keysBoxList.TabIndex = 5;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 156);
            this.Controls.Add(this.keysBoxList);
            this.Controls.Add(this.checkConfig);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.valueInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(180, 195);
            this.MinimumSize = new System.Drawing.Size(180, 195);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.Button checkConfig;
        private System.Windows.Forms.ComboBox keysBoxList;
    }
}