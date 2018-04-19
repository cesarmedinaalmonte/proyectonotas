namespace notas
{
    partial class historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historial));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgsiglo1 = new System.Windows.Forms.DataGridView();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.cmbhistorial = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsiglo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1104, 58);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(248, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(856, 58);
            this.panel6.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(710, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 30);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 16);
            this.panel2.TabIndex = 32;
            // 
            // dtgsiglo1
            // 
            this.dtgsiglo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsiglo1.Location = new System.Drawing.Point(115, 173);
            this.dtgsiglo1.Name = "dtgsiglo1";
            this.dtgsiglo1.Size = new System.Drawing.Size(572, 268);
            this.dtgsiglo1.TabIndex = 33;
            // 
            // btnhistorial
            // 
            this.btnhistorial.AccessibleDescription = "al";
            this.btnhistorial.Location = new System.Drawing.Point(115, 132);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(75, 23);
            this.btnhistorial.TabIndex = 36;
            this.btnhistorial.Text = "Buscar";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbhistorial
            // 
            this.cmbhistorial.FormattingEnabled = true;
            this.cmbhistorial.Location = new System.Drawing.Point(213, 134);
            this.cmbhistorial.Name = "cmbhistorial";
            this.cmbhistorial.Size = new System.Drawing.Size(121, 21);
            this.cmbhistorial.TabIndex = 37;
            // 
            // historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 730);
            this.Controls.Add(this.cmbhistorial);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.dtgsiglo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "historial";
            this.Text = "historial";
            this.Load += new System.EventHandler(this.historial_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsiglo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgsiglo1;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.ComboBox cmbhistorial;
    }
}