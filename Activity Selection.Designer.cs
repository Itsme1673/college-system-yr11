namespace College_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnAthleticsActivity = new System.Windows.Forms.Button();
            this.btnLogOutFromActivitySelection = new System.Windows.Forms.Button();
            this.lblDesignText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAthleticsActivity
            // 
            this.btnAthleticsActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAthleticsActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAthleticsActivity.Location = new System.Drawing.Point(46, 39);
            this.btnAthleticsActivity.Name = "btnAthleticsActivity";
            this.btnAthleticsActivity.Size = new System.Drawing.Size(193, 23);
            this.btnAthleticsActivity.TabIndex = 0;
            this.btnAthleticsActivity.Text = "Go To Athletics Activity Selection\r\n";
            this.btnAthleticsActivity.UseVisualStyleBackColor = true;
            this.btnAthleticsActivity.Click += new System.EventHandler(this.btnAthleticsActivity_Click);
            // 
            // btnLogOutFromActivitySelection
            // 
            this.btnLogOutFromActivitySelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOutFromActivitySelection.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutFromActivitySelection.Location = new System.Drawing.Point(100, 186);
            this.btnLogOutFromActivitySelection.Name = "btnLogOutFromActivitySelection";
            this.btnLogOutFromActivitySelection.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutFromActivitySelection.TabIndex = 1;
            this.btnLogOutFromActivitySelection.Text = "Log Out";
            this.btnLogOutFromActivitySelection.UseVisualStyleBackColor = true;
            this.btnLogOutFromActivitySelection.Click += new System.EventHandler(this.btnLogOutFromActivitySelection_Click);
            // 
            // lblDesignText
            // 
            this.lblDesignText.AutoSize = true;
            this.lblDesignText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignText.ForeColor = System.Drawing.Color.White;
            this.lblDesignText.Image = ((System.Drawing.Image)(resources.GetObject("lblDesignText.Image")));
            this.lblDesignText.Location = new System.Drawing.Point(24, 112);
            this.lblDesignText.Name = "lblDesignText";
            this.lblDesignText.Size = new System.Drawing.Size(249, 13);
            this.lblDesignText.TabIndex = 2;
            this.lblDesignText.Text = "Buttons for other activity payments will go here";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(285, 237);
            this.ControlBox = false;
            this.Controls.Add(this.lblDesignText);
            this.Controls.Add(this.btnLogOutFromActivitySelection);
            this.Controls.Add(this.btnAthleticsActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "GG Secondary College//Activity Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAthleticsActivity;
        private System.Windows.Forms.Button btnLogOutFromActivitySelection;
        private System.Windows.Forms.Label lblDesignText;
    }
}