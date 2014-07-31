namespace Sistema_compras.Formularios
{
    partial class frm_Proveedor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grb_DatosProveedor = new System.Windows.Forms.GroupBox();
            this.btn_consultar_Proveedor = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_razonSocial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_RUC = new System.Windows.Forms.Label();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.gpb_tipoProveedor = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_DatosProveedor.SuspendLayout();
            this.gpb_tipoProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_user,
            this.tss_lbl_fecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_lbl_user
            // 
            this.tss_lbl_user.Name = "tss_lbl_user";
            this.tss_lbl_user.Size = new System.Drawing.Size(47, 17);
            this.tss_lbl_user.Text = "lbl_user";
            // 
            // tss_lbl_fecha
            // 
            this.tss_lbl_fecha.Name = "tss_lbl_fecha";
            this.tss_lbl_fecha.Size = new System.Drawing.Size(54, 17);
            this.tss_lbl_fecha.Text = "lbl_fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(337, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos que despacha";
            // 
            // grb_DatosProveedor
            // 
            this.grb_DatosProveedor.Controls.Add(this.btn_consultar_Proveedor);
            this.grb_DatosProveedor.Controls.Add(this.textBox3);
            this.grb_DatosProveedor.Controls.Add(this.txt_direccion);
            this.grb_DatosProveedor.Controls.Add(this.txt_correo);
            this.grb_DatosProveedor.Controls.Add(this.txt_telefono);
            this.grb_DatosProveedor.Controls.Add(this.textBox5);
            this.grb_DatosProveedor.Controls.Add(this.textBox4);
            this.grb_DatosProveedor.Controls.Add(this.textBox2);
            this.grb_DatosProveedor.Controls.Add(this.lbl_direccion);
            this.grb_DatosProveedor.Controls.Add(this.label2);
            this.grb_DatosProveedor.Controls.Add(this.lbl_correo);
            this.grb_DatosProveedor.Controls.Add(this.lbl_telefono);
            this.grb_DatosProveedor.Controls.Add(this.lbl_razonSocial);
            this.grb_DatosProveedor.Controls.Add(this.label3);
            this.grb_DatosProveedor.Controls.Add(this.label1);
            this.grb_DatosProveedor.Location = new System.Drawing.Point(36, 29);
            this.grb_DatosProveedor.Name = "grb_DatosProveedor";
            this.grb_DatosProveedor.Size = new System.Drawing.Size(612, 162);
            this.grb_DatosProveedor.TabIndex = 4;
            this.grb_DatosProveedor.TabStop = false;
            this.grb_DatosProveedor.Text = "Datos Generales:";
            // 
            // btn_consultar_Proveedor
            // 
            this.btn_consultar_Proveedor.Location = new System.Drawing.Point(260, 31);
            this.btn_consultar_Proveedor.Name = "btn_consultar_Proveedor";
            this.btn_consultar_Proveedor.Size = new System.Drawing.Size(39, 20);
            this.btn_consultar_Proveedor.TabIndex = 5;
            this.btn_consultar_Proveedor.Text = "...";
            this.btn_consultar_Proveedor.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(467, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(125, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(467, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // lbl_razonSocial
            // 
            this.lbl_razonSocial.AutoSize = true;
            this.lbl_razonSocial.Location = new System.Drawing.Point(28, 65);
            this.lbl_razonSocial.Name = "lbl_razonSocial";
            this.lbl_razonSocial.Size = new System.Drawing.Size(73, 13);
            this.lbl_razonSocial.TabIndex = 0;
            this.lbl_razonSocial.Text = "Razon Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Responsable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(337, 301);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 5;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(517, 301);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(429, 332);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "&Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(429, 301);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(28, 95);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 0;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(125, 92);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(130, 20);
            this.txt_telefono.TabIndex = 1;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(28, 126);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 0;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(125, 123);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(130, 20);
            this.txt_direccion.TabIndex = 1;
            // 
            // lbl_RUC
            // 
            this.lbl_RUC.AutoSize = true;
            this.lbl_RUC.Location = new System.Drawing.Point(5, 137);
            this.lbl_RUC.Name = "lbl_RUC";
            this.lbl_RUC.Size = new System.Drawing.Size(33, 13);
            this.lbl_RUC.TabIndex = 0;
            this.lbl_RUC.Text = "RUC:";
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(125, 134);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(130, 20);
            this.txt_ruc.TabIndex = 1;
            // 
            // gpb_tipoProveedor
            // 
            this.gpb_tipoProveedor.Controls.Add(this.label5);
            this.gpb_tipoProveedor.Controls.Add(this.radioButton2);
            this.gpb_tipoProveedor.Controls.Add(this.radioButton1);
            this.gpb_tipoProveedor.Controls.Add(this.textBox1);
            this.gpb_tipoProveedor.Controls.Add(this.txt_ruc);
            this.gpb_tipoProveedor.Controls.Add(this.label6);
            this.gpb_tipoProveedor.Controls.Add(this.lbl_RUC);
            this.gpb_tipoProveedor.Location = new System.Drawing.Point(36, 200);
            this.gpb_tipoProveedor.Name = "gpb_tipoProveedor";
            this.gpb_tipoProveedor.Size = new System.Drawing.Size(270, 171);
            this.gpb_tipoProveedor.TabIndex = 6;
            this.gpb_tipoProveedor.TabStop = false;
            this.gpb_tipoProveedor.Text = "Tipo de Provedor";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "&Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(111, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "&No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "¿Esta Obligado a llevar Contabilidad?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cedula o Pasaporte:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(368, 99);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(39, 13);
            this.lbl_correo.TabIndex = 0;
            this.lbl_correo.Text = "E-Mail:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(465, 96);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(130, 20);
            this.txt_correo.TabIndex = 1;
            // 
            // frm_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 407);
            this.Controls.Add(this.gpb_tipoProveedor);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.grb_DatosProveedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_Proveedor";
            this.Text = "Mantenimiento - Proveedor";
            this.Load += new System.EventHandler(this.frm_Proveedor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_DatosProveedor.ResumeLayout(false);
            this.grb_DatosProveedor.PerformLayout();
            this.gpb_tipoProveedor.ResumeLayout(false);
            this.gpb_tipoProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_user;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grb_DatosProveedor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar_Proveedor;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_razonSocial;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ruc;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_RUC;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.GroupBox gpb_tipoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
    }
}