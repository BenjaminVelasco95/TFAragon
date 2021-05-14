namespace TFAragon.FomormsEmpleado
{
    partial class EntradaSalidaE
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
            this.btnRSalida = new System.Windows.Forms.Button();
            this.btnREntrada = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHSalida = new System.Windows.Forms.TextBox();
            this.labelapellido = new System.Windows.Forms.Label();
            this.txtHEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgES = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.llblX = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgES)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRSalida
            // 
            this.btnRSalida.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSalida.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnRSalida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRSalida.Location = new System.Drawing.Point(299, 433);
            this.btnRSalida.Name = "btnRSalida";
            this.btnRSalida.Size = new System.Drawing.Size(135, 25);
            this.btnRSalida.TabIndex = 58;
            this.btnRSalida.Text = "Registrar salida";
            this.btnRSalida.UseVisualStyleBackColor = false;
            this.btnRSalida.Click += new System.EventHandler(this.btnRSalida_Click);
            // 
            // btnREntrada
            // 
            this.btnREntrada.BackColor = System.Drawing.Color.DarkCyan;
            this.btnREntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREntrada.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnREntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnREntrada.Location = new System.Drawing.Point(120, 433);
            this.btnREntrada.Name = "btnREntrada";
            this.btnREntrada.Size = new System.Drawing.Size(135, 25);
            this.btnREntrada.TabIndex = 59;
            this.btnREntrada.Text = "Registrar entrada";
            this.btnREntrada.UseVisualStyleBackColor = false;
            this.btnREntrada.Click += new System.EventHandler(this.btnREntrada_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.llblX);
            this.groupBox2.Controls.Add(this.cbIE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHSalida);
            this.groupBox2.Controls.Add(this.labelapellido);
            this.groupBox2.Controls.Add(this.txtHEntrada);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 73);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // cbIE
            // 
            this.cbIE.FormattingEnabled = true;
            this.cbIE.Location = new System.Drawing.Point(21, 39);
            this.cbIE.Name = "cbIE";
            this.cbIE.Size = new System.Drawing.Size(123, 23);
            this.cbIE.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hora Salida";
            // 
            // txtHSalida
            // 
            this.txtHSalida.Enabled = false;
            this.txtHSalida.Location = new System.Drawing.Point(408, 39);
            this.txtHSalida.Name = "txtHSalida";
            this.txtHSalida.Size = new System.Drawing.Size(123, 23);
            this.txtHSalida.TabIndex = 34;
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.BackColor = System.Drawing.Color.Transparent;
            this.labelapellido.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.Location = new System.Drawing.Point(276, 19);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(88, 15);
            this.labelapellido.TabIndex = 33;
            this.labelapellido.Text = "Hora Entrada";
            // 
            // txtHEntrada
            // 
            this.txtHEntrada.Enabled = false;
            this.txtHEntrada.Location = new System.Drawing.Point(279, 39);
            this.txtHEntrada.Name = "txtHEntrada";
            this.txtHEntrada.Size = new System.Drawing.Size(123, 23);
            this.txtHEntrada.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha (AA/MM/DD)";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(150, 39);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(123, 23);
            this.txtFecha.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "IE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgES);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 336);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro entrada/salida";
            // 
            // dtgES
            // 
            this.dtgES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgES.Location = new System.Drawing.Point(6, 17);
            this.dtgES.Name = "dtgES";
            this.dtgES.Size = new System.Drawing.Size(539, 313);
            this.dtgES.TabIndex = 0;
            // 
            // llblX
            // 
            this.llblX.ActiveLinkColor = System.Drawing.Color.Red;
            this.llblX.AutoSize = true;
            this.llblX.Location = new System.Drawing.Point(6, -3);
            this.llblX.Name = "llblX";
            this.llblX.Size = new System.Drawing.Size(14, 15);
            this.llblX.TabIndex = 60;
            this.llblX.TabStop = true;
            this.llblX.Text = "x";
            this.llblX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblX_LinkClicked);
            // 
            // EntradaSalidaE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(575, 470);
            this.Controls.Add(this.btnREntrada);
            this.Controls.Add(this.btnRSalida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EntradaSalidaE";
            this.Text = "EntradaSalida";
            this.Load += new System.EventHandler(this.EntradaSalidaE_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRSalida;
        private System.Windows.Forms.Button btnREntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHSalida;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.TextBox txtHEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgES;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel llblX;
    }
}