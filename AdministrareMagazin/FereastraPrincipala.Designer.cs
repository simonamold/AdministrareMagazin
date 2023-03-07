namespace AdministrareMagazin
{
    partial class FormMagazin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagazin));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cmsData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autentificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricCumparaturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCautareId = new System.Windows.Forms.Button();
            this.dgvIstoricVanzari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.cmsData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricVanzari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ContextMenuStrip = this.cmsData;
            this.dgvProduct.Location = new System.Drawing.Point(23, 104);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(851, 321);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // cmsData
            // 
            this.cmsData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCantitateToolStripMenuItem});
            this.cmsData.Name = "cmsData";
            this.cmsData.Size = new System.Drawing.Size(193, 28);
            // 
            // adaugaCantitateToolStripMenuItem
            // 
            this.adaugaCantitateToolStripMenuItem.Name = "adaugaCantitateToolStripMenuItem";
            this.adaugaCantitateToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.adaugaCantitateToolStripMenuItem.Text = "Adauga cantitate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.utilizatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.istoricVanzariToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.meniuToolStripMenuItem.Text = "Produs";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsNouToolStripMenuItem,
            this.modificareCantitateToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.adaugareToolStripMenuItem.Text = "Adaugare Produs";
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.produsNouToolStripMenuItem.Text = "Produs nou";
            this.produsNouToolStripMenuItem.Click += new System.EventHandler(this.produsNouToolStripMenuItem_Click);
            // 
            // modificareCantitateToolStripMenuItem
            // 
            this.modificareCantitateToolStripMenuItem.Name = "modificareCantitateToolStripMenuItem";
            this.modificareCantitateToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.modificareCantitateToolStripMenuItem.Text = "Modificare cantitate";
            this.modificareCantitateToolStripMenuItem.Click += new System.EventHandler(this.modificareCantitateToolStripMenuItem_Click);
            // 
            // istoricVanzariToolStripMenuItem
            // 
            this.istoricVanzariToolStripMenuItem.Name = "istoricVanzariToolStripMenuItem";
            this.istoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.istoricVanzariToolStripMenuItem.Text = "Istoric Vanzari";
            this.istoricVanzariToolStripMenuItem.Click += new System.EventHandler(this.istoricVanzariToolStripMenuItem_Click);
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autentificareToolStripMenuItem,
            this.stergereContToolStripMenuItem,
            this.istoricCumparaturiToolStripMenuItem});
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.utilizatorToolStripMenuItem.Text = " Utilizator";
            // 
            // autentificareToolStripMenuItem
            // 
            this.autentificareToolStripMenuItem.Name = "autentificareToolStripMenuItem";
            this.autentificareToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.autentificareToolStripMenuItem.Text = "Autentificare";
            this.autentificareToolStripMenuItem.Click += new System.EventHandler(this.autentificareToolStripMenuItem_Click);
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.stergereContToolStripMenuItem.Text = "Stergere Utilizator";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // istoricCumparaturiToolStripMenuItem
            // 
            this.istoricCumparaturiToolStripMenuItem.Name = "istoricCumparaturiToolStripMenuItem";
            this.istoricCumparaturiToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.istoricCumparaturiToolStripMenuItem.Text = "Vizualizare Lista Utilizatori";
            this.istoricCumparaturiToolStripMenuItem.Click += new System.EventHandler(this.listaUtilizatoriToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(780, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 25);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(24, 42);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(271, 22);
            this.txtCautare.TabIndex = 3;
            // 
            // btnCautare
            // 
            this.btnCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautare.Location = new System.Drawing.Point(337, 41);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(132, 25);
            this.btnCautare.TabIndex = 4;
            this.btnCautare.Text = "Cautare denumire";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCautareId
            // 
            this.btnCautareId.Location = new System.Drawing.Point(484, 41);
            this.btnCautareId.Name = "btnCautareId";
            this.btnCautareId.Size = new System.Drawing.Size(132, 25);
            this.btnCautareId.TabIndex = 6;
            this.btnCautareId.Text = "Cautare Id";
            this.btnCautareId.UseVisualStyleBackColor = true;
            this.btnCautareId.Click += new System.EventHandler(this.btnCautareId_Click);
            // 
            // dgvIstoricVanzari
            // 
            this.dgvIstoricVanzari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvIstoricVanzari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstoricVanzari.Location = new System.Drawing.Point(24, 104);
            this.dgvIstoricVanzari.Name = "dgvIstoricVanzari";
            this.dgvIstoricVanzari.RowHeadersWidth = 51;
            this.dgvIstoricVanzari.RowTemplate.Height = 24;
            this.dgvIstoricVanzari.Size = new System.Drawing.Size(850, 321);
            this.dgvIstoricVanzari.TabIndex = 7;
            // 
            // FormMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 501);
            this.Controls.Add(this.dgvIstoricVanzari);
            this.Controls.Add(this.btnCautareId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMagazin";
            this.Text = "Magazin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.cmsData.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricVanzari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareCantitateToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.ContextMenuStrip cmsData;
        private System.Windows.Forms.ToolStripMenuItem adaugaCantitateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricVanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem autentificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricCumparaturiToolStripMenuItem;
        private System.Windows.Forms.Button btnCautareId;
        private System.Windows.Forms.DataGridView dgvIstoricVanzari;
    }
}

