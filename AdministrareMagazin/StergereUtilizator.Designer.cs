namespace AdministrareMagazin
{
    partial class StergereUtilizator
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
            this.txtIdStergere = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblIdStergere = new System.Windows.Forms.Label();
            this.lblParolaStergere = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdStergere
            // 
            this.txtIdStergere.Location = new System.Drawing.Point(94, 53);
            this.txtIdStergere.Name = "txtIdStergere";
            this.txtIdStergere.Size = new System.Drawing.Size(100, 22);
            this.txtIdStergere.TabIndex = 0;
            this.txtIdStergere.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdStergere_Validating);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(94, 88);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 1;
            this.txtParola.Validating += new System.ComponentModel.CancelEventHandler(this.txtParola_Validating);
            // 
            // lblIdStergere
            // 
            this.lblIdStergere.AutoSize = true;
            this.lblIdStergere.Location = new System.Drawing.Point(68, 59);
            this.lblIdStergere.Name = "lblIdStergere";
            this.lblIdStergere.Size = new System.Drawing.Size(20, 16);
            this.lblIdStergere.TabIndex = 2;
            this.lblIdStergere.Text = "ID";
            // 
            // lblParolaStergere
            // 
            this.lblParolaStergere.AutoSize = true;
            this.lblParolaStergere.Location = new System.Drawing.Point(41, 94);
            this.lblParolaStergere.Name = "lblParolaStergere";
            this.lblParolaStergere.Size = new System.Drawing.Size(47, 16);
            this.lblParolaStergere.TabIndex = 3;
            this.lblParolaStergere.Text = "Parola";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(94, 128);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(88, 33);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // StergereUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 239);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblParolaStergere);
            this.Controls.Add(this.lblIdStergere);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtIdStergere);
            this.Name = "StergereUtilizator";
            this.Text = "StergereUtilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdStergere;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblIdStergere;
        private System.Windows.Forms.Label lblParolaStergere;
        private System.Windows.Forms.Button btnConfirmare;
    }
}