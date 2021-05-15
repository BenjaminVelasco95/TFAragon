namespace TFAragon
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.barDesplazamiento = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDesplazamiento)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Clientes";
            // 
            // btnGestionar
            // 
            this.btnGestionar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGestionar.Location = new System.Drawing.Point(51, 79);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(75, 50);
            this.btnGestionar.TabIndex = 34;
            this.btnGestionar.Text = "Gestionar Clientes";
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGestionar);
            this.groupBox2.Controls.Add(this.btnDetalle);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 197);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDetalle.Location = new System.Drawing.Point(195, 79);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 50);
            this.btnDetalle.TabIndex = 39;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Location = new System.Drawing.Point(12, 57);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgClientes);
            this.groupBox1.Controls.Add(this.lblActualizar);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 197);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.ColumnHeadersHeight = 25;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgClientes.EnableHeadersVisualStyles = false;
            this.dtgClientes.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dtgClientes.Location = new System.Drawing.Point(6, 17);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(664, 174);
            this.dtgClientes.TabIndex = 0;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblActualizar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizar.Location = new System.Drawing.Point(6, -1);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(55, 15);
            this.lblActualizar.TabIndex = 29;
            this.lblActualizar.Text = "Clientes";
            this.lblActualizar.Click += new System.EventHandler(this.lblActualizar_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minimizar.Image = global::TFAragon.Properties.Resources.minimizar;
            this.minimizar.Location = new System.Drawing.Point(633, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 28;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cerrar.Image = global::TFAragon.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(669, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 27;
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
            this.barDesplazamiento.TabIndex = 26;
            this.barDesplazamiento.TabStop = false;
            this.barDesplazamiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseDown);
            this.barDesplazamiento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseMove);
            this.barDesplazamiento.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barDesplazamiento_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cliente :";
            // 
            // btnExpediente
            // 
            this.btnExpediente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnExpediente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpediente.Location = new System.Drawing.Point(117, 61);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(80, 25);
            this.btnExpediente.TabIndex = 38;
            this.btnExpediente.Text = "Expediente";
            this.btnExpediente.UseVisualStyleBackColor = false;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnExpediente);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(357, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 197);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(87, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 15);
            this.lblCliente.TabIndex = 39;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.barDesplazamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDesplazamiento)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox barDesplazamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblActualizar;
        public System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCliente;
    }
}