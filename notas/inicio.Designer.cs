namespace notas
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCrearperiodo = new System.Windows.Forms.Button();
            this.btnCrearasignatura = new System.Windows.Forms.Button();
            this.btnCrearprofesor = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnSeleccionAsignatura = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1541, 20);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 621);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1541, 36);
            this.panel3.TabIndex = 5;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu.Controls.Add(this.groupBox1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 90);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(308, 531);
            this.menu.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.logo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 527);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(4, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Consulta Historico Academico       ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(4, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Consulta de Pre/Seleccion      ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(4, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consulta de Calificaciones     ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.logo.Location = new System.Drawing.Point(4, 19);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(280, 63);
            this.logo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::notas.Properties.Resources.man_user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.btnCrearperiodo);
            this.panel4.Controls.Add(this.btnCrearasignatura);
            this.panel4.Controls.Add(this.btnCrearprofesor);
            this.panel4.Controls.Add(this.btnCalificaciones);
            this.panel4.Controls.Add(this.btnSeleccionAsignatura);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(308, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1233, 137);
            this.panel4.TabIndex = 15;
            // 
            // btnCrearperiodo
            // 
            this.btnCrearperiodo.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearperiodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearperiodo.FlatAppearance.BorderSize = 0;
            this.btnCrearperiodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearperiodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearperiodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearperiodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearperiodo.ForeColor = System.Drawing.Color.White;
            this.btnCrearperiodo.Image = global::notas.Properties.Resources.inicio_de_una_pagina_web;
            this.btnCrearperiodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearperiodo.Location = new System.Drawing.Point(411, 2);
            this.btnCrearperiodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearperiodo.Name = "btnCrearperiodo";
            this.btnCrearperiodo.Size = new System.Drawing.Size(145, 137);
            this.btnCrearperiodo.TabIndex = 14;
            this.btnCrearperiodo.Text = "Crear Periodo";
            this.btnCrearperiodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearperiodo.UseVisualStyleBackColor = false;
            this.btnCrearperiodo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCrearasignatura
            // 
            this.btnCrearasignatura.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearasignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearasignatura.FlatAppearance.BorderSize = 0;
            this.btnCrearasignatura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearasignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearasignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearasignatura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearasignatura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearasignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearasignatura.Image")));
            this.btnCrearasignatura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearasignatura.Location = new System.Drawing.Point(8, 0);
            this.btnCrearasignatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearasignatura.Name = "btnCrearasignatura";
            this.btnCrearasignatura.Size = new System.Drawing.Size(145, 143);
            this.btnCrearasignatura.TabIndex = 8;
            this.btnCrearasignatura.Text = "Crear Asignaturas ";
            this.btnCrearasignatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearasignatura.UseVisualStyleBackColor = false;
            this.btnCrearasignatura.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCrearprofesor
            // 
            this.btnCrearprofesor.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearprofesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearprofesor.FlatAppearance.BorderSize = 0;
            this.btnCrearprofesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearprofesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnCrearprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearprofesor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearprofesor.ForeColor = System.Drawing.Color.Transparent;
            this.btnCrearprofesor.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearprofesor.Image")));
            this.btnCrearprofesor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearprofesor.Location = new System.Drawing.Point(202, 0);
            this.btnCrearprofesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearprofesor.Name = "btnCrearprofesor";
            this.btnCrearprofesor.Size = new System.Drawing.Size(145, 137);
            this.btnCrearprofesor.TabIndex = 10;
            this.btnCrearprofesor.Text = "Crear Profesores ";
            this.btnCrearprofesor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearprofesor.UseVisualStyleBackColor = false;
            this.btnCrearprofesor.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.Indigo;
            this.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.ForeColor = System.Drawing.Color.White;
            this.btnCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnCalificaciones.Image")));
            this.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalificaciones.Location = new System.Drawing.Point(820, -4);
            this.btnCalificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(145, 137);
            this.btnCalificaciones.TabIndex = 13;
            this.btnCalificaciones.Text = "Calificaciones ";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSeleccionAsignatura
            // 
            this.btnSeleccionAsignatura.BackColor = System.Drawing.Color.Indigo;
            this.btnSeleccionAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeleccionAsignatura.FlatAppearance.BorderSize = 0;
            this.btnSeleccionAsignatura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnSeleccionAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSeleccionAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionAsignatura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionAsignatura.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionAsignatura.Image")));
            this.btnSeleccionAsignatura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionAsignatura.Location = new System.Drawing.Point(611, 0);
            this.btnSeleccionAsignatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionAsignatura.Name = "btnSeleccionAsignatura";
            this.btnSeleccionAsignatura.Size = new System.Drawing.Size(145, 137);
            this.btnSeleccionAsignatura.TabIndex = 11;
            this.btnSeleccionAsignatura.Text = "Seleccionar Asignaturas ";
            this.btnSeleccionAsignatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionAsignatura.UseVisualStyleBackColor = false;
            this.btnSeleccionAsignatura.Click += new System.EventHandler(this.btnSeleccionAsignatura_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::notas.Properties.Resources.blanco;
            this.pictureBox3.Location = new System.Drawing.Point(704, 164);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 34);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 70);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(312, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1225, 66);
            this.panel5.TabIndex = 0;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1541, 657);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCrearprofesor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCrearasignatura;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnSeleccionAsignatura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearperiodo;
        private System.Windows.Forms.Panel panel5;
    }
}