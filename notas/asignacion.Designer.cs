﻿namespace notas
{
    partial class asignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asignacion));
            this.btnterminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnatras = new System.Windows.Forms.Button();
            this.pensumDataSet1 = new notas.pensumDataSet1();
            this.cuatrimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuatrimestreTableAdapter = new notas.pensumDataSet1TableAdapters.cuatrimestreTableAdapter();
            this.cbxbimestre = new System.Windows.Forms.ComboBox();
            this.cbxcuatrimestre = new System.Windows.Forms.ComboBox();
            this.CodigoAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuatrimestreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(561, 114);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(107, 23);
            this.btnterminar.TabIndex = 46;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Bimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cuatrimestre";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(168, 83);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(105, 20);
            this.txtdescripcion.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(1070, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(47, 164);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1145, 150);
            this.dataGridView2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAsignatura,
            this.asignatura,
            this.cr,
            this.ht,
            this.hp});
            this.dataGridView1.Location = new System.Drawing.Point(47, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Periodo";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Enabled = false;
            this.txtperiodo.Location = new System.Drawing.Point(108, 83);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(58, 20);
            this.txtperiodo.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Seleccionar Asginaturas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnatras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 58);
            this.panel1.TabIndex = 47;
            // 
            // btnatras
            // 
            this.btnatras.BackgroundImage = global::notas.Properties.Resources.Utoons_TV_blue_background;
            this.btnatras.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.Image")));
            this.btnatras.Location = new System.Drawing.Point(1033, 26);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(29, 30);
            this.btnatras.TabIndex = 28;
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // pensumDataSet1
            // 
            this.pensumDataSet1.DataSetName = "pensumDataSet1";
            this.pensumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuatrimestreBindingSource
            // 
            this.cuatrimestreBindingSource.DataMember = "cuatrimestre";
            this.cuatrimestreBindingSource.DataSource = this.pensumDataSet1;
            // 
            // cuatrimestreTableAdapter
            // 
            this.cuatrimestreTableAdapter.ClearBeforeFill = true;
            // 
            // cbxbimestre
            // 
            this.cbxbimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbimestre.FormattingEnabled = true;
            this.cbxbimestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxbimestre.Location = new System.Drawing.Point(478, 116);
            this.cbxbimestre.Name = "cbxbimestre";
            this.cbxbimestre.Size = new System.Drawing.Size(44, 21);
            this.cbxbimestre.TabIndex = 45;
            // 
            // cbxcuatrimestre
            // 
            this.cbxcuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcuatrimestre.FormattingEnabled = true;
            this.cbxcuatrimestre.Location = new System.Drawing.Point(143, 118);
            this.cbxcuatrimestre.Name = "cbxcuatrimestre";
            this.cbxcuatrimestre.Size = new System.Drawing.Size(240, 21);
            this.cbxcuatrimestre.TabIndex = 44;
            this.cbxcuatrimestre.SelectedValueChanged += new System.EventHandler(this.cbxcuatrimestre_SelectedValueChanged);
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
            this.asignatura.Width = 600;
            // 
            // cr
            // 
            this.cr.HeaderText = "Credito";
            this.cr.Name = "cr";
            this.cr.ReadOnly = true;
            this.cr.Width = 50;
            // 
            // ht
            // 
            this.ht.HeaderText = "HT";
            this.ht.Name = "ht";
            this.ht.ReadOnly = true;
            this.ht.Width = 50;
            // 
            // hp
            // 
            this.hp.HeaderText = "HP";
            this.hp.Name = "hp";
            this.hp.ReadOnly = true;
            this.hp.Width = 50;
            // 
            // asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.cbxbimestre);
            this.Controls.Add(this.cbxcuatrimestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.label2);
            this.Name = "asignacion";
            this.Text = "asignacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.asignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuatrimestreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnatras;
        private pensumDataSet1 pensumDataSet1;
        private System.Windows.Forms.BindingSource cuatrimestreBindingSource;
        private pensumDataSet1TableAdapters.cuatrimestreTableAdapter cuatrimestreTableAdapter;
        private System.Windows.Forms.ComboBox cbxbimestre;
        private System.Windows.Forms.ComboBox cbxcuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn hp;
    }
}