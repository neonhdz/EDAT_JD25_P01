namespace UI.NumerosAleatorios
{
    partial class DatosAleatorios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_Click = new System.Windows.Forms.Button();
            this.sm = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.CheckBox();
            this.m = new System.Windows.Forms.CheckBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sueldo);
            this.groupBox1.Controls.Add(this.tb_Nombre);
            this.groupBox1.Controls.Add(this.tb_Numero);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1_Click);
            this.groupBox1.Controls.Add(this.sm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.f);
            this.groupBox1.Controls.Add(this.m);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1_Click
            // 
            this.button1_Click.Location = new System.Drawing.Point(196, 440);
            this.button1_Click.Name = "button1_Click";
            this.button1_Click.Size = new System.Drawing.Size(230, 23);
            this.button1_Click.TabIndex = 16;
            this.button1_Click.Text = "Generar datos aleatorios";
            this.button1_Click.UseVisualStyleBackColor = true;
            this.button1_Click.Click += new System.EventHandler(this.button1_Click_Click);
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(29, 393);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(121, 20);
            this.sm.TabIndex = 15;
            this.sm.Text = "Seguro medico";
            this.sm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sueldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grupo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genero";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(29, 207);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(89, 20);
            this.f.TabIndex = 8;
            this.f.Text = "Femenino";
            this.f.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(29, 181);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(90, 20);
            this.m.TabIndex = 7;
            this.m.Text = "Masculino";
            this.m.UseVisualStyleBackColor = true;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(174, 130);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(252, 22);
            this.fecha.TabIndex = 6;
            this.fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(103, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_Numero
            // 
            this.tb_Numero.Location = new System.Drawing.Point(87, 36);
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(168, 22);
            this.tb_Numero.TabIndex = 18;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(87, 77);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(222, 22);
            this.tb_Nombre.TabIndex = 19;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(87, 319);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(171, 22);
            this.sueldo.TabIndex = 20;
            // 
            // DatosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatosAleatorios";
            this.Text = "Empleado con datos aleatorios";
            this.Load += new System.EventHandler(this.DatosAleatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox f;
        private System.Windows.Forms.CheckBox m;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1_Click;
        private System.Windows.Forms.CheckBox sm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.TextBox sueldo;
    }
}

