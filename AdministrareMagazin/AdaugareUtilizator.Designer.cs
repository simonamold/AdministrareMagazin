namespace AdministrareMagazin
{
    partial class AdaugareUtilizator
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
            this.lblUNume = new System.Windows.Forms.Label();
            this.lblUPrenume = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUNume = new System.Windows.Forms.TextBox();
            this.txtUPrenume = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnUAutentificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUNume
            // 
            this.lblUNume.AutoSize = true;
            this.lblUNume.Location = new System.Drawing.Point(80, 63);
            this.lblUNume.Name = "lblUNume";
            this.lblUNume.Size = new System.Drawing.Size(43, 16);
            this.lblUNume.TabIndex = 0;
            this.lblUNume.Text = "Nume";
            // 
            // lblUPrenume
            // 
            this.lblUPrenume.AutoSize = true;
            this.lblUPrenume.Location = new System.Drawing.Point(62, 97);
            this.lblUPrenume.Name = "lblUPrenume";
            this.lblUPrenume.Size = new System.Drawing.Size(61, 16);
            this.lblUPrenume.TabIndex = 1;
            this.lblUPrenume.Text = "Prenume";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(53, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(76, 169);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(47, 16);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // txtUNume
            // 
            this.txtUNume.Location = new System.Drawing.Point(162, 63);
            this.txtUNume.Name = "txtUNume";
            this.txtUNume.Size = new System.Drawing.Size(100, 22);
            this.txtUNume.TabIndex = 4;
            // 
            // txtUPrenume
            // 
            this.txtUPrenume.Location = new System.Drawing.Point(162, 97);
            this.txtUPrenume.Name = "txtUPrenume";
            this.txtUPrenume.Size = new System.Drawing.Size(100, 22);
            this.txtUPrenume.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(162, 135);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(162, 169);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 7;
            // 
            // btnUAutentificare
            // 
            this.btnUAutentificare.Location = new System.Drawing.Point(108, 219);
            this.btnUAutentificare.Name = "btnUAutentificare";
            this.btnUAutentificare.Size = new System.Drawing.Size(101, 25);
            this.btnUAutentificare.TabIndex = 8;
            this.btnUAutentificare.Text = "Autentificare";
            this.btnUAutentificare.UseVisualStyleBackColor = true;
            this.btnUAutentificare.Click += new System.EventHandler(this.btnUAutentificare_Click);
            // 
            // AdaugareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.btnUAutentificare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtUPrenume);
            this.Controls.Add(this.txtUNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUPrenume);
            this.Controls.Add(this.lblUNume);
            this.Name = "AdaugareUtilizator";
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUNume;
        private System.Windows.Forms.Label lblUPrenume;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUNume;
        private System.Windows.Forms.TextBox txtUPrenume;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnUAutentificare;
    }
}