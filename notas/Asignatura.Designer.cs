﻿using System;

namespace notas
{
    partial class Asignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asignatura));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cuatrimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pensumDataSet1 = new notas.pensumDataSet1();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboxCuatrimestre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprereq2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprereq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcr = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txtasig = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboxbuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtgdatos = new System.Windows.Forms.DataGridView();
            this.pensumDataSet = new notas.pensumDataSet();
            this.pensumDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuatrimestreTableAdapter = new notas.pensumDataSet1TableAdapters.cuatrimestreTableAdapter();
            this.menu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuatrimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.buscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSetBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 20);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 862);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1472, 36);
            this.panel3.TabIndex = 7;
            // 
            // cuatrimestreBindingSource
            // 
            this.cuatrimestreBindingSource.DataMember = "cuatrimestre";
            this.cuatrimestreBindingSource.DataSource = this.pensumDataSet1;
            // 
            // pensumDataSet1
            // 
            this.pensumDataSet1.DataSetName = "pensumDataSet1";
            this.pensumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(251, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 772);
            this.panel4.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ComboxCuatrimestre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtprereq2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtprereq);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcr);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.txthp);
            this.groupBox1.Controls.Add(this.txtasig);
            this.groupBox1.Controls.Add(this.txtht);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(630, 772);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE ASIGNATURAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(256, 501);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(56, 53);
            this.btnactualizar.TabIndex = 25;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 429);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "PREREQUISITO 2:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // ComboxCuatrimestre
            // 
            this.ComboxCuatrimestre.FormattingEnabled = true;
            this.ComboxCuatrimestre.Location = new System.Drawing.Point(178, 328);
            this.ComboxCuatrimestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboxCuatrimestre.Name = "ComboxCuatrimestre";
            this.ComboxCuatrimestre.Size = new System.Drawing.Size(252, 30);
            this.ComboxCuatrimestre.TabIndex = 23;
            this.ComboxCuatrimestre.SelectedIndexChanged += new System.EventHandler(this.ComboxCuatrimestre_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "CUATRIMESTRE:";
            // 
            // txtprereq2
            // 
            this.txtprereq2.Location = new System.Drawing.Point(178, 428);
            this.txtprereq2.Margin = new System.Windows.Forms.Padding(4);
            this.txtprereq2.Name = "txtprereq2";
            this.txtprereq2.Size = new System.Drawing.Size(93, 29);
            this.txtprereq2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnguardar.Image = global::notas.Properties.Resources.guardar_archivo_opcion;
            this.btnguardar.Location = new System.Drawing.Point(173, 501);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 53);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(337, 501);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(56, 53);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "ASIGNATURA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "HT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "HP:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::notas.Properties.Resources.community_users_12977;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::notas.Properties.Resources.community_users_12977;
            this.pictureBox2.Location = new System.Drawing.Point(467, 113);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 156);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "CR:";
            // 
            // txtprereq
            // 
            this.txtprereq.Location = new System.Drawing.Point(178, 379);
            this.txtprereq.Margin = new System.Windows.Forms.Padding(4);
            this.txtprereq.Name = "txtprereq";
            this.txtprereq.Size = new System.Drawing.Size(93, 29);
            this.txtprereq.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "PREREQUISITO 1:";
            // 
            // txtcr
            // 
            this.txtcr.Location = new System.Drawing.Point(178, 279);
            this.txtcr.Margin = new System.Windows.Forms.Padding(4);
            this.txtcr.Name = "txtcr";
            this.txtcr.Size = new System.Drawing.Size(249, 29);
            this.txtcr.TabIndex = 11;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(178, 84);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(249, 29);
            this.txtclave.TabIndex = 7;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(178, 228);
            this.txthp.Margin = new System.Windows.Forms.Padding(4);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(249, 29);
            this.txthp.TabIndex = 10;
            // 
            // txtasig
            // 
            this.txtasig.Location = new System.Drawing.Point(178, 132);
            this.txtasig.Margin = new System.Windows.Forms.Padding(4);
            this.txtasig.Name = "txtasig";
            this.txtasig.Size = new System.Drawing.Size(249, 29);
            this.txtasig.TabIndex = 8;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(178, 183);
            this.txtht.Margin = new System.Windows.Forms.Padding(4);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(249, 29);
            this.txtht.TabIndex = 9;
            // 
            // buscar
            // 
            this.buscar.Controls.Add(this.groupBox2);
            this.buscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buscar.Location = new System.Drawing.Point(949, 90);
            this.buscar.Margin = new System.Windows.Forms.Padding(4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(523, 772);
            this.buscar.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxbuscar);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.dtgdatos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(523, 772);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR ASIGNATURA";
            // 
            // comboxbuscar
            // 
            this.comboxbuscar.FormattingEnabled = true;
            this.comboxbuscar.Items.AddRange(new object[] {
            "Nombre",
            "Clave"});
            this.comboxbuscar.Location = new System.Drawing.Point(107, 57);
            this.comboxbuscar.Name = "comboxbuscar";
            this.comboxbuscar.Size = new System.Drawing.Size(92, 24);
            this.comboxbuscar.TabIndex = 9;
            this.comboxbuscar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(211, 53);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(251, 30);
            this.txtbuscar.TabIndex = 8;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbuscar.Image = global::notas.Properties.Resources.search__1_;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.Location = new System.Drawing.Point(8, 52);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(92, 31);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgdatos
            // 
            this.dtgdatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdatos.Location = new System.Drawing.Point(8, 106);
            this.dtgdatos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgdatos.Name = "dtgdatos";
            this.dtgdatos.Size = new System.Drawing.Size(459, 238);
            this.dtgdatos.TabIndex = 0;
            this.dtgdatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdatos_CellClick);
            this.dtgdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdatos_CellContentClick_1);
            // 
            // pensumDataSet
            // 
            this.pensumDataSet.DataSetName = "pensumDataSet";
            this.pensumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pensumDataSetBindingSource
            // 
            this.pensumDataSetBindingSource.DataSource = this.pensumDataSet;
            this.pensumDataSetBindingSource.Position = 0;
            // 
            // cuatrimestreTableAdapter
            // 
            this.cuatrimestreTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.logo);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 90);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(251, 772);
            this.menu.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::notas.Properties.Resources.adelante;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Consulta Historico Academico     ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::notas.Properties.Resources.adelante;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 111);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Consulta de Pre/Seleccion      ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::notas.Properties.Resources.adelante;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Consulta de Calificaciones     ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.logo.BackColor = System.Drawing.Color.LimeGreen;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Controls.Add(this.pictureBox1);
            this.logo.Controls.Add(this.label1);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(247, 63);
            this.logo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::notas.Properties.Resources.man_user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Participante ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnatras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 70);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1468, 71);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(327, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1141, 71);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(947, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 37);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnatras
            // 
            this.btnatras.BackgroundImage = global::notas.Properties.Resources.Utoons_TV_blue_background;
            this.btnatras.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.Image")));
            this.btnatras.Location = new System.Drawing.Point(1393, 32);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(39, 37);
            this.btnatras.TabIndex = 29;
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // Asignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 898);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Asignatura";
            this.Text = "Asignatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Asignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuatrimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.buscar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensumDataSetBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ComboxCuatrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgdatos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.BindingSource pensumDataSetBindingSource;
        private pensumDataSet pensumDataSet;
        private pensumDataSet1 pensumDataSet1;
        private System.Windows.Forms.BindingSource cuatrimestreBindingSource;
        private pensumDataSet1TableAdapters.cuatrimestreTableAdapter cuatrimestreTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboxCuatrimestre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprereq2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprereq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcr;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txtasig;
        private System.Windows.Forms.TextBox txtht;
    }
}