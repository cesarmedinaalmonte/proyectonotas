namespace notas
{
    partial class calificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calificacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnatras = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnatras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 70);
            this.panel1.TabIndex = 48;
            // 
            // btnatras
            // 
            this.btnatras.BackgroundImage = global::notas.Properties.Resources.Utoons_TV_blue_background;
            this.btnatras.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.Image")));
            this.btnatras.Location = new System.Drawing.Point(1377, 32);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(39, 37);
            this.btnatras.TabIndex = 28;
            this.btnatras.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 486);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1495, 36);
            this.panel3.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.CodigoAsignatura,
            this.asignatura,
            this.bimestre,
            this.nota,
            this.profesor});
            this.dataGridView1.Location = new System.Drawing.Point(140, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 252);
            this.dataGridView1.TabIndex = 50;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // CodigoAsignatura
            // 
            this.CodigoAsignatura.HeaderText = "Clave";
            this.CodigoAsignatura.Name = "CodigoAsignatura";
            this.CodigoAsignatura.ReadOnly = true;
            this.CodigoAsignatura.Width = 150;
            // 
            // asignatura
            // 
            this.asignatura.HeaderText = "Asignatura";
            this.asignatura.Name = "asignatura";
            this.asignatura.ReadOnly = true;
            this.asignatura.Width = 500;
            // 
            // bimestre
            // 
            this.bimestre.HeaderText = "Bimestre";
            this.bimestre.Name = "bimestre";
            this.bimestre.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // profesor
            // 
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            this.profesor.ReadOnly = true;
            this.profesor.Width = 160;
            // 
            // calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "calificacion";
            this.Text = "calificacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn bimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesor;
    }
}