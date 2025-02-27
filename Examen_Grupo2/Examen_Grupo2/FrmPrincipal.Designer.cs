namespace Examen_Grupo2
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEncuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.dtgDatos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(654, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(548, 66);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 40);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxSalir);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 60);
            this.panel3.TabIndex = 1;
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxSalir.Image = global::Examen_Grupo2.Properties.Resources.icons8_logout_48;
            this.pictureBoxSalir.Location = new System.Drawing.Point(531, 3);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(57, 54);
            this.pictureBoxSalir.TabIndex = 1;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionServicioToolStripMenuItem,
            this.gestionClientesToolStripMenuItem,
            this.gestionEncuestasToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Examen_Grupo2.Properties.Resources.icons8_menu_96;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 54);
            // 
            // gestionServicioToolStripMenuItem
            // 
            this.gestionServicioToolStripMenuItem.Name = "gestionServicioToolStripMenuItem";
            this.gestionServicioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestionServicioToolStripMenuItem.Text = "GestionServicio";
            this.gestionServicioToolStripMenuItem.Click += new System.EventHandler(this.gestionServicioToolStripMenuItem_Click);
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestionClientesToolStripMenuItem.Text = "GestionClientes";
            this.gestionClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionClientesToolStripMenuItem_Click);
            // 
            // gestionEncuestasToolStripMenuItem
            // 
            this.gestionEncuestasToolStripMenuItem.Name = "gestionEncuestasToolStripMenuItem";
            this.gestionEncuestasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestionEncuestasToolStripMenuItem.Text = "GestionEncuestas";
            this.gestionEncuestasToolStripMenuItem.Click += new System.EventHandler(this.gestionEncuestasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 450);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accesos Directos";
            // 
            // button3
            // 
            this.button3.Image = global::Examen_Grupo2.Properties.Resources.icons8_catalog_26;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Encuestas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Examen_Grupo2.Properties.Resources.icons8_supplier_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Servicios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Examen_Grupo2.Properties.Resources.icons8_users_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(200, 154);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(597, 293);
            this.dtgDatos.TabIndex = 2;
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem gestionServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEncuestasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.DataGridView dtgDatos;
    }
}