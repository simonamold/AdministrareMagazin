namespace AdministrareMagazin
{
    partial class ModificaCantitate
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCantitateNoua = new System.Windows.Forms.Label();
            this.nudAddQ = new System.Windows.Forms.NumericUpDown();
            this.btnAddQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(44, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // lblCantitateNoua
            // 
            this.lblCantitateNoua.AutoSize = true;
            this.lblCantitateNoua.Location = new System.Drawing.Point(12, 76);
            this.lblCantitateNoua.Name = "lblCantitateNoua";
            this.lblCantitateNoua.Size = new System.Drawing.Size(59, 16);
            this.lblCantitateNoua.TabIndex = 2;
            this.lblCantitateNoua.Text = "Cantitate";
            // 
            // nudAddQ
            // 
            this.nudAddQ.Location = new System.Drawing.Point(95, 74);
            this.nudAddQ.Name = "nudAddQ";
            this.nudAddQ.Size = new System.Drawing.Size(100, 22);
            this.nudAddQ.TabIndex = 3;
            // 
            // btnAddQ
            // 
            this.btnAddQ.Location = new System.Drawing.Point(84, 125);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(83, 26);
            this.btnAddQ.TabIndex = 4;
            this.btnAddQ.Text = "Adauga";
            this.btnAddQ.UseVisualStyleBackColor = true;
            this.btnAddQ.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // ModificaCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 201);
            this.Controls.Add(this.btnAddQ);
            this.Controls.Add(this.nudAddQ);
            this.Controls.Add(this.lblCantitateNoua);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "ModificaCantitate";
            this.Text = "Modifica Cantitate";
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCantitateNoua;
        private System.Windows.Forms.NumericUpDown nudAddQ;
        private System.Windows.Forms.Button btnAddQ;
    }
}