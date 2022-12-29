namespace assignment11_AndreiKazakov
{
    partial class Form1
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
            this.BrakeButton = new System.Windows.Forms.Button();
            this.AccelerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrakeButton
            // 
            this.BrakeButton.Location = new System.Drawing.Point(13, 13);
            this.BrakeButton.Name = "BrakeButton";
            this.BrakeButton.Size = new System.Drawing.Size(75, 74);
            this.BrakeButton.TabIndex = 0;
            this.BrakeButton.Text = "Brake";
            this.BrakeButton.UseVisualStyleBackColor = true;
            // 
            // AccelerateButton
            // 
            this.AccelerateButton.Location = new System.Drawing.Point(228, 13);
            this.AccelerateButton.Name = "AccelerateButton";
            this.AccelerateButton.Size = new System.Drawing.Size(75, 74);
            this.AccelerateButton.TabIndex = 1;
            this.AccelerateButton.Text = "Wroom!";
            this.AccelerateButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(142, 13);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(0, 13);
            this.YearLabel.TabIndex = 5;
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(142, 29);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(0, 13);
            this.MakeLabel.TabIndex = 6;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(142, 47);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.SpeedLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 99);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccelerateButton);
            this.Controls.Add(this.BrakeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrakeButton;
        private System.Windows.Forms.Button AccelerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

