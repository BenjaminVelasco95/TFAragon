﻿namespace TFAragon
{
    partial class GastosEmpresa
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
            this.label3 = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.barDesplazamiento = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelapellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCobrador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIGT = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbIE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDesplazamiento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gastos de la empresa";
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizar.Image = global::TFAragon.Properties.Resources.minimizar;
            this.minimizar.Location = new System.Drawing.Point(634, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 25;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cerrar.Image = global::TFAragon.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(670, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 24;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // barDesplazamiento
            // 
            this.barDesplazamiento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.barDesplazamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this.barDesplazamiento.Name = "barDesplazamiento";
            this.barDesplazamiento.Size = new System.Drawing.Size(700, 30);
            this.barDesplazamiento.TabIndex = 23;
            this.barDesplazamiento.TabStop = false;
            this.barDesplazamiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseDown);
            this.barDesplazamiento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseMove);
            this.barDesplazamiento.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseUp);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Location = new System.Drawing.Point(371, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(452, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIE);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.labelapellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCobrador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIGT);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 122);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Fecha(AA/MM/DD)";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(18, 88);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(123, 23);
            this.txtFecha.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(534, 40);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(123, 23);
            this.txtMonto.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(405, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(123, 23);
            this.txtDescripcion.TabIndex = 34;
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.BackColor = System.Drawing.Color.Transparent;
            this.labelapellido.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.Location = new System.Drawing.Point(273, 20);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(84, 15);
            this.labelapellido.TabIndex = 33;
            this.labelapellido.Text = "Id Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cobrador";
            // 
            // txtCobrador
            // 
            this.txtCobrador.Location = new System.Drawing.Point(147, 40);
            this.txtCobrador.Name = "txtCobrador";
            this.txtCobrador.Size = new System.Drawing.Size(123, 23);
            this.txtCobrador.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "IGT";
            // 
            // txtIGT
            // 
            this.txtIGT.Location = new System.Drawing.Point(18, 40);
            this.txtIGT.Name = "txtIGT";
            this.txtIGT.Size = new System.Drawing.Size(123, 23);
            this.txtIGT.TabIndex = 0;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnMod.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMod.Location = new System.Drawing.Point(533, 42);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 25);
            this.btnMod.TabIndex = 58;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgGastos);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 287);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos";
            // 
            // dtgGastos
            // 
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGastos.Location = new System.Drawing.Point(6, 22);
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.Size = new System.Drawing.Size(664, 259);
            this.dtgGastos.TabIndex = 0;
            this.dtgGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellContentClick);
            // 
            // btnDell
            // 
            this.btnDell.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDell.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnDell.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDell.Location = new System.Drawing.Point(614, 42);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(75, 25);
            this.btnDell.TabIndex = 57;
            this.btnDell.Text = "Eliminar";
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Location = new System.Drawing.Point(12, 42);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 56;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbIE
            // 
            this.cbIE.FormattingEnabled = true;
            this.cbIE.Location = new System.Drawing.Point(276, 40);
            this.cbIE.Name = "cbIE";
            this.cbIE.Size = new System.Drawing.Size(121, 23);
            this.cbIE.TabIndex = 40;
            // 
            // GastosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.barDesplazamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GastosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastosEmpresa";
            this.Load += new System.EventHandler(this.GastosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDesplazamiento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox barDesplazamiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCobrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIGT;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbIE;
    }
}