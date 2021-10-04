
namespace InsuranceHandling
{
    partial class lossTypeForm
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
            this.lossWelcomeLabel = new System.Windows.Forms.Label();
            this.lossInstructions = new System.Windows.Forms.Label();
            this.lossCodeLabel = new System.Windows.Forms.Label();
            this.lossDescriptionLabel = new System.Windows.Forms.Label();
            this.lossCodeCombo = new System.Windows.Forms.ComboBox();
            this.lossDescCombo = new System.Windows.Forms.ComboBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.logOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lossWelcomeLabel
            // 
            this.lossWelcomeLabel.AutoSize = true;
            this.lossWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossWelcomeLabel.Location = new System.Drawing.Point(77, 34);
            this.lossWelcomeLabel.Name = "lossWelcomeLabel";
            this.lossWelcomeLabel.Size = new System.Drawing.Size(584, 25);
            this.lossWelcomeLabel.TabIndex = 0;
            this.lossWelcomeLabel.Text = "Welcome to Crawford and Company Loss Type Data Viewer";
            // 
            // lossInstructions
            // 
            this.lossInstructions.AutoSize = true;
            this.lossInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossInstructions.Location = new System.Drawing.Point(129, 97);
            this.lossInstructions.Name = "lossInstructions";
            this.lossInstructions.Size = new System.Drawing.Size(463, 24);
            this.lossInstructions.TabIndex = 1;
            this.lossInstructions.Text = "Please select any of the options below to view the data";
            // 
            // lossCodeLabel
            // 
            this.lossCodeLabel.AutoSize = true;
            this.lossCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossCodeLabel.Location = new System.Drawing.Point(130, 177);
            this.lossCodeLabel.Name = "lossCodeLabel";
            this.lossCodeLabel.Size = new System.Drawing.Size(123, 20);
            this.lossCodeLabel.TabIndex = 3;
            this.lossCodeLabel.Text = "Loss Type Code";
            // 
            // lossDescriptionLabel
            // 
            this.lossDescriptionLabel.AutoSize = true;
            this.lossDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossDescriptionLabel.Location = new System.Drawing.Point(431, 177);
            this.lossDescriptionLabel.Name = "lossDescriptionLabel";
            this.lossDescriptionLabel.Size = new System.Drawing.Size(165, 20);
            this.lossDescriptionLabel.TabIndex = 4;
            this.lossDescriptionLabel.Text = "Loss Type Description";
            // 
            // lossCodeCombo
            // 
            this.lossCodeCombo.FormattingEnabled = true;
            this.lossCodeCombo.Location = new System.Drawing.Point(134, 209);
            this.lossCodeCombo.Name = "lossCodeCombo";
            this.lossCodeCombo.Size = new System.Drawing.Size(121, 21);
            this.lossCodeCombo.TabIndex = 6;
            this.lossCodeCombo.SelectedIndexChanged += new System.EventHandler(this.lossCodeCombo_SelectedIndexChanged);
            // 
            // lossDescCombo
            // 
            this.lossDescCombo.FormattingEnabled = true;
            this.lossDescCombo.Location = new System.Drawing.Point(435, 209);
            this.lossDescCombo.Name = "lossDescCombo";
            this.lossDescCombo.Size = new System.Drawing.Size(121, 21);
            this.lossDescCombo.TabIndex = 7;
            this.lossDescCombo.SelectedIndexChanged += new System.EventHandler(this.lossDescCombo_SelectedIndexChanged);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(152, 271);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 24);
            this.resultsLabel.TabIndex = 8;
            // 
            // logOffButton
            // 
            this.logOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffButton.Location = new System.Drawing.Point(586, 339);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(120, 38);
            this.logOffButton.TabIndex = 9;
            this.logOffButton.Text = "Sign Out";
            this.logOffButton.UseVisualStyleBackColor = true;
            this.logOffButton.Click += new System.EventHandler(this.logOffButton_Click);
            // 
            // lossTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.lossDescCombo);
            this.Controls.Add(this.lossCodeCombo);
            this.Controls.Add(this.lossDescriptionLabel);
            this.Controls.Add(this.lossCodeLabel);
            this.Controls.Add(this.lossInstructions);
            this.Controls.Add(this.lossWelcomeLabel);
            this.Name = "lossTypeForm";
            this.Text = "Loss Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lossWelcomeLabel;
        private System.Windows.Forms.Label lossInstructions;
        private System.Windows.Forms.Label lossCodeLabel;
        private System.Windows.Forms.Label lossDescriptionLabel;
        private System.Windows.Forms.ComboBox lossCodeCombo;
        private System.Windows.Forms.ComboBox lossDescCombo;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button logOffButton;
    }
}