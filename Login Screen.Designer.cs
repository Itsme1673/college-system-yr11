namespace College_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.txtLoginCode = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsernameText = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.pcbSchoolLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordText.ForeColor = System.Drawing.Color.White;
            this.lblPasswordText.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordText.Image")));
            this.lblPasswordText.Location = new System.Drawing.Point(57, 71);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(58, 13);
            this.lblPasswordText.TabIndex = 2;
            this.lblPasswordText.Text = "Password:";
            // 
            // txtLoginCode
            // 
            this.txtLoginCode.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginCode.Location = new System.Drawing.Point(119, 71);
            this.txtLoginCode.Name = "txtLoginCode";
            this.txtLoginCode.PasswordChar = '*';
            this.txtLoginCode.Size = new System.Drawing.Size(100, 22);
            this.txtLoginCode.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(104, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsernameText
            // 
            this.lblUsernameText.AutoSize = true;
            this.lblUsernameText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameText.ForeColor = System.Drawing.Color.White;
            this.lblUsernameText.Image = ((System.Drawing.Image)(resources.GetObject("lblUsernameText.Image")));
            this.lblUsernameText.Location = new System.Drawing.Point(55, 46);
            this.lblUsernameText.Name = "lblUsernameText";
            this.lblUsernameText.Size = new System.Drawing.Size(61, 13);
            this.lblUsernameText.TabIndex = 5;
            this.lblUsernameText.Text = "Username:";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.Location = new System.Drawing.Point(119, 43);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(100, 22);
            this.txtLoginUser.TabIndex = 6;
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeText.Image = ((System.Drawing.Image)(resources.GetObject("lblWelcomeText.Image")));
            this.lblWelcomeText.Location = new System.Drawing.Point(115, 9);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(267, 21);
            this.lblWelcomeText.TabIndex = 7;
            this.lblWelcomeText.Text = "Welcome to GG Secondary College";
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProgram.Location = new System.Drawing.Point(80, 136);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(123, 23);
            this.btnCloseProgram.TabIndex = 8;
            this.btnCloseProgram.Text = "Close Program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // pcbSchoolLogo
            // 
            this.pcbSchoolLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbSchoolLogo.Image")));
            this.pcbSchoolLogo.Location = new System.Drawing.Point(277, 36);
            this.pcbSchoolLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pcbSchoolLogo.Name = "pcbSchoolLogo";
            this.pcbSchoolLogo.Size = new System.Drawing.Size(192, 123);
            this.pcbSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSchoolLogo.TabIndex = 9;
            this.pcbSchoolLogo.TabStop = false;
            this.pcbSchoolLogo.Click += new System.EventHandler(this.pcbSchoolLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 183);
            this.ControlBox = false;
            this.Controls.Add(this.pcbSchoolLogo);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.lblWelcomeText);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblUsernameText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginCode);
            this.Controls.Add(this.lblPasswordText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GG Secondary College//Login To Payment System";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSchoolLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.TextBox txtLoginCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsernameText;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Button btnCloseProgram;
        private System.Windows.Forms.PictureBox pcbSchoolLogo;
    }
}

