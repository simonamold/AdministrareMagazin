namespace AdministrareMagazin
{
    partial class YesNo
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btsNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(47, 69);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(392, 25);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Actiunea este definitiva! Doriti sa continuati?";
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(132, 131);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Da";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btsNo
            // 
            this.btsNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btsNo.Location = new System.Drawing.Point(243, 131);
            this.btsNo.Name = "btsNo";
            this.btsNo.Size = new System.Drawing.Size(75, 23);
            this.btsNo.TabIndex = 2;
            this.btsNo.Text = "Nu";
            this.btsNo.UseVisualStyleBackColor = true;
            this.btsNo.Click += new System.EventHandler(this.btsNo_Click);
            // 
            // YesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 229);
            this.Controls.Add(this.btsNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMesaj);
            this.Name = "YesNo";
            this.Text = "YesNo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btsNo;
    }
}