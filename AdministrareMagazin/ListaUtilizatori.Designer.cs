namespace AdministrareMagazin
{
    partial class ListaUtilizatori
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
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.btnRefreshU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtilizatori
            // 
            this.dgvUtilizatori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori.Location = new System.Drawing.Point(45, 96);
            this.dgvUtilizatori.Name = "dgvUtilizatori";
            this.dgvUtilizatori.RowHeadersWidth = 51;
            this.dgvUtilizatori.RowTemplate.Height = 24;
            this.dgvUtilizatori.Size = new System.Drawing.Size(666, 258);
            this.dgvUtilizatori.TabIndex = 0;
            // 
            // btnRefreshU
            // 
            this.btnRefreshU.Location = new System.Drawing.Point(635, 57);
            this.btnRefreshU.Name = "btnRefreshU";
            this.btnRefreshU.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshU.TabIndex = 1;
            this.btnRefreshU.Text = "Refresh";
            this.btnRefreshU.UseVisualStyleBackColor = true;
            this.btnRefreshU.Click += new System.EventHandler(this.btnRefreshU_Click);
            // 
            // ListaUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshU);
            this.Controls.Add(this.dgvUtilizatori);
            this.Name = "ListaUtilizatori";
            this.Text = "ListaUtilizatori";
            this.Load += new System.EventHandler(this.ListaUtilizatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.Button btnRefreshU;
    }
}