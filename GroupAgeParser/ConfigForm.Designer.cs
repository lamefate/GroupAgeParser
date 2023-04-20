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
            this.keyListView = new System.Windows.Forms.ListView();
            this.checkConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(12, 248);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(260, 20);
            this.valueInput.TabIndex = 1;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(170, 274);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(102, 25);
            this.saveConfigButton.TabIndex = 2;
            this.saveConfigButton.Text = "Save Config";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // keyListView
            // 
            this.keyListView.HideSelection = false;
            this.keyListView.Location = new System.Drawing.Point(12, 12);
            this.keyListView.Name = "keyListView";
            this.keyListView.Size = new System.Drawing.Size(260, 230);
            this.keyListView.TabIndex = 3;
            this.keyListView.UseCompatibleStateImageBehavior = false;
            // 
            // checkConfig
            // 
            this.checkConfig.Location = new System.Drawing.Point(12, 274);
            this.checkConfig.Name = "checkConfig";
            this.checkConfig.Size = new System.Drawing.Size(102, 25);
            this.checkConfig.TabIndex = 4;
            this.checkConfig.Text = "Check Value";
            this.checkConfig.UseVisualStyleBackColor = true;
            this.checkConfig.Click += new System.EventHandler(this.checkConfig_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.checkConfig);
            this.Controls.Add(this.keyListView);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.valueInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "ConfigForm";
            this.Text = "Change Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.ListView keyListView;
        private System.Windows.Forms.Button checkConfig;
    }
}