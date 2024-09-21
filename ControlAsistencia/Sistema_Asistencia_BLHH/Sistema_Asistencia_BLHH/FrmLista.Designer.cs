namespace Sistema_Asistencia_BLHH
{
    partial class FrmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.ptbBuscar = new System.Windows.Forms.PictureBox();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(81, 143);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 62;
            this.dgvLista.Size = new System.Drawing.Size(525, 365);
            this.dgvLista.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 52);
            this.label1.TabIndex = 84;
            this.label1.Text = "Listar Empleados";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(495, 97);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(163, 26);
            this.txtLista.TabIndex = 85;
            // 
            // ptbBuscar
            // 
            this.ptbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.ptbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("ptbBuscar.Image")));
            this.ptbBuscar.Location = new System.Drawing.Point(649, 97);
            this.ptbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBuscar.Name = "ptbBuscar";
            this.ptbBuscar.Size = new System.Drawing.Size(31, 26);
            this.ptbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBuscar.TabIndex = 87;
            this.ptbBuscar.TabStop = false;
            // 
            // ptbSalir
            // 
            this.ptbSalir.BackColor = System.Drawing.Color.Transparent;
            this.ptbSalir.Image = ((System.Drawing.Image)(resources.GetObject("ptbSalir.Image")));
            this.ptbSalir.Location = new System.Drawing.Point(702, 22);
            this.ptbSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(55, 40);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 88;
            this.ptbSalir.TabStop = false;
            // 
            // ptbHome
            // 
            this.ptbHome.BackColor = System.Drawing.Color.Transparent;
            this.ptbHome.Image = ((System.Drawing.Image)(resources.GetObject("ptbHome.Image")));
            this.ptbHome.Location = new System.Drawing.Point(32, 22);
            this.ptbHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(55, 40);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHome.TabIndex = 89;
            this.ptbHome.TabStop = false;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 542);
            this.Controls.Add(this.ptbHome);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.ptbBuscar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmLista";
            this.Text = "FrmLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.PictureBox ptbBuscar;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.PictureBox ptbHome;
    }
}