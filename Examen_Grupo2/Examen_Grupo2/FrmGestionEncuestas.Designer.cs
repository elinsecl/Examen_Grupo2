namespace Examen_Grupo2
{
    partial class FrmGestionEncuestas
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoEncuesta = new System.Windows.Forms.ComboBox();
            this.cmbCalificacionEncuesta = new System.Windows.Forms.ComboBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdEncuesta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.cmbEstadoEncuesta = new System.Windows.Forms.ComboBox();
            this.dtpFechaEncuesta = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "EstadoEncuesta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "TipoEncuesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CalificacionEncuesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Comentarios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IdServicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IdCliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IdEncuesta:";
            // 
            // cmbTipoEncuesta
            // 
            this.cmbTipoEncuesta.FormattingEnabled = true;
            this.cmbTipoEncuesta.Location = new System.Drawing.Point(368, 257);
            this.cmbTipoEncuesta.Name = "cmbTipoEncuesta";
            this.cmbTipoEncuesta.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoEncuesta.TabIndex = 6;
            // 
            // cmbCalificacionEncuesta
            // 
            this.cmbCalificacionEncuesta.FormattingEnabled = true;
            this.cmbCalificacionEncuesta.Location = new System.Drawing.Point(368, 230);
            this.cmbCalificacionEncuesta.Name = "cmbCalificacionEncuesta";
            this.cmbCalificacionEncuesta.Size = new System.Drawing.Size(200, 21);
            this.cmbCalificacionEncuesta.TabIndex = 5;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(368, 178);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(200, 20);
            this.txtComentarios.TabIndex = 3;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(368, 152);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(200, 20);
            this.txtServicio.TabIndex = 2;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(368, 126);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(200, 20);
            this.txtIdCliente.TabIndex = 1;
            // 
            // txtIdEncuesta
            // 
            this.txtIdEncuesta.Location = new System.Drawing.Point(368, 100);
            this.txtIdEncuesta.Name = "txtIdEncuesta";
            this.txtIdEncuesta.Size = new System.Drawing.Size(200, 20);
            this.txtIdEncuesta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.pictureBoxSalir);
            this.panel1.Controls.Add(this.cmbEstadoEncuesta);
            this.panel1.Controls.Add(this.dtpFechaEncuesta);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTipoEncuesta);
            this.panel1.Controls.Add(this.cmbCalificacionEncuesta);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Controls.Add(this.txtServicio);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.txtIdEncuesta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxSalir.Image = global::Examen_Grupo2.Properties.Resources.icons8_logout_48;
            this.pictureBoxSalir.Location = new System.Drawing.Point(731, 12);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(57, 54);
            this.pictureBoxSalir.TabIndex = 19;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // cmbEstadoEncuesta
            // 
            this.cmbEstadoEncuesta.FormattingEnabled = true;
            this.cmbEstadoEncuesta.Location = new System.Drawing.Point(368, 283);
            this.cmbEstadoEncuesta.Name = "cmbEstadoEncuesta";
            this.cmbEstadoEncuesta.Size = new System.Drawing.Size(200, 21);
            this.cmbEstadoEncuesta.TabIndex = 18;
            // 
            // dtpFechaEncuesta
            // 
            this.dtpFechaEncuesta.Location = new System.Drawing.Point(368, 204);
            this.dtpFechaEncuesta.Name = "dtpFechaEncuesta";
            this.dtpFechaEncuesta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEncuesta.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "FechaeEncuesta:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(449, 320);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 25;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(368, 320);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 24;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(287, 320);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 23;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // FrmGestionEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionEncuestas";
            this.Text = "FrmGestionEncuestas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoEncuesta;
        private System.Windows.Forms.ComboBox cmbCalificacionEncuesta;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdEncuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaEncuesta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstadoEncuesta;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}