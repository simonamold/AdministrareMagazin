namespace AdministrareMagazin
{
    partial class Vanzare
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
            this.lblCantitateVanzare = new System.Windows.Forms.Label();
            this.nudVanzare = new System.Windows.Forms.NumericUpDown();
            this.btnVanzare = new System.Windows.Forms.Button();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVanzare)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantitateVanzare
            // 
            this.lblCantitateVanzare.AutoSize = true;
            this.lblCantitateVanzare.Location = new System.Drawing.Point(82, 151);
            this.lblCantitateVanzare.Name = "lblCantitateVanzare";
            this.lblCantitateVanzare.Size = new System.Drawing.Size(59, 16);
            this.lblCantitateVanzare.TabIndex = 0;
            this.lblCantitateVanzare.Text = "Cantitate";
            // 
            // nudVanzare
            // 
            this.nudVanzare.Location = new System.Drawing.Point(159, 151);
            this.nudVanzare.Name = "nudVanzare";
            this.nudVanzare.Size = new System.Drawing.Size(100, 22);
            this.nudVanzare.TabIndex = 1;
            // 
            // btnVanzare
            // 
            this.btnVanzare.Location = new System.Drawing.Point(132, 196);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(75, 23);
            this.btnVanzare.TabIndex = 2;
            this.btnVanzare.Text = "Confirma";
            this.btnVanzare.UseVisualStyleBackColor = true;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(67, 104);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(74, 16);
            this.lblIdUser.TabIndex = 4;
            this.lblIdUser.Text = "ID Utilizator";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Location = new System.Drawing.Point(159, 101);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(100, 22);
            this.txtIDUser.TabIndex = 5;
            this.txtIDUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDUser_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduceti Id-ul cumparatorului si cantitatea de produs";
            // 
            // Vanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.btnVanzare);
            this.Controls.Add(this.nudVanzare);
            this.Controls.Add(this.lblCantitateVanzare);
            this.Name = "Vanzare";
            this.Text = "Vanzare";
            ((System.ComponentModel.ISupportInitialize)(this.nudVanzare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantitateVanzare;
        private System.Windows.Forms.NumericUpDown nudVanzare;
        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label1;
    }
}