namespace AdministrareMagazin
{
    partial class AddProduct
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
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lblDataIntrare = new System.Windows.Forms.Label();
            this.lblDataValabilitate = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.dtpIntrare = new System.Windows.Forms.DateTimePicker();
            this.dtpValabilitate = new System.Windows.Forms.DateTimePicker();
            this.nudCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugareProdus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(23, 22);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(65, 16);
            this.lblDenumire.TabIndex = 1;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(22, 70);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(66, 16);
            this.lblDescriere.TabIndex = 2;
            this.lblDescriere.Text = "Descriere";
            // 
            // lblDataIntrare
            // 
            this.lblDataIntrare.AutoSize = true;
            this.lblDataIntrare.Location = new System.Drawing.Point(23, 177);
            this.lblDataIntrare.Name = "lblDataIntrare";
            this.lblDataIntrare.Size = new System.Drawing.Size(95, 16);
            this.lblDataIntrare.TabIndex = 3;
            this.lblDataIntrare.Text = "Data de intrare";
            // 
            // lblDataValabilitate
            // 
            this.lblDataValabilitate.AutoSize = true;
            this.lblDataValabilitate.Location = new System.Drawing.Point(23, 231);
            this.lblDataValabilitate.Name = "lblDataValabilitate";
            this.lblDataValabilitate.Size = new System.Drawing.Size(104, 16);
            this.lblDataValabilitate.TabIndex = 4;
            this.lblDataValabilitate.Text = "Data valabilitate";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(23, 283);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(59, 16);
            this.lblCantitate.TabIndex = 5;
            this.lblCantitate.Text = "Cantitate";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(144, 22);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 7;
            this.txtDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.txtDenumire_Validating);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(144, 70);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(280, 84);
            this.txtDescriere.TabIndex = 8;
            this.txtDescriere.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescriere_Validating);
            // 
            // dtpIntrare
            // 
            this.dtpIntrare.Location = new System.Drawing.Point(144, 177);
            this.dtpIntrare.Name = "dtpIntrare";
            this.dtpIntrare.Size = new System.Drawing.Size(200, 22);
            this.dtpIntrare.TabIndex = 9;
            // 
            // dtpValabilitate
            // 
            this.dtpValabilitate.Location = new System.Drawing.Point(144, 225);
            this.dtpValabilitate.Name = "dtpValabilitate";
            this.dtpValabilitate.Size = new System.Drawing.Size(200, 22);
            this.dtpValabilitate.TabIndex = 10;
            // 
            // nudCantitate
            // 
            this.nudCantitate.Location = new System.Drawing.Point(144, 277);
            this.nudCantitate.Name = "nudCantitate";
            this.nudCantitate.Size = new System.Drawing.Size(120, 22);
            this.nudCantitate.TabIndex = 11;
            // 
            // btnAdaugareProdus
            // 
            this.btnAdaugareProdus.Location = new System.Drawing.Point(25, 337);
            this.btnAdaugareProdus.Name = "btnAdaugareProdus";
            this.btnAdaugareProdus.Size = new System.Drawing.Size(92, 29);
            this.btnAdaugareProdus.TabIndex = 12;
            this.btnAdaugareProdus.Text = "Adaugare";
            this.btnAdaugareProdus.UseVisualStyleBackColor = true;
            this.btnAdaugareProdus.Click += new System.EventHandler(this.btnAdaugareProdus_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.btnAdaugareProdus);
            this.Controls.Add(this.nudCantitate);
            this.Controls.Add(this.dtpValabilitate);
            this.Controls.Add(this.dtpIntrare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblDataValabilitate);
            this.Controls.Add(this.lblDataIntrare);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblDenumire);
            this.Name = "AddProduct";
            this.Text = "Adaugare Produs";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Label lblDataIntrare;
        private System.Windows.Forms.Label lblDataValabilitate;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.DateTimePicker dtpIntrare;
        private System.Windows.Forms.DateTimePicker dtpValabilitate;
        private System.Windows.Forms.NumericUpDown nudCantitate;
        private System.Windows.Forms.Button btnAdaugareProdus;
    }
}