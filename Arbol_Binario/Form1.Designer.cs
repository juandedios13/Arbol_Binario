
namespace arbol
{
    partial class Form1
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
            this.Insertar = new System.Windows.Forms.Button();
            this.Button_eliminar = new System.Windows.Forms.Button();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtDatoEliminar = new System.Windows.Forms.TextBox();
            this.txtDatoBuscar = new System.Windows.Forms.TextBox();
            this.Enorden = new System.Windows.Forms.Button();
            this.Preorden = new System.Windows.Forms.Button();
            this.PostOrden = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.Mayor = new System.Windows.Forms.Button();
            this.Altura = new System.Windows.Forms.Button();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumatoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Insertar
            // 
            this.Insertar.BackColor = System.Drawing.Color.Transparent;
            this.Insertar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Insertar.FlatAppearance.BorderSize = 2;
            this.Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Insertar.Location = new System.Drawing.Point(28, 93);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(92, 29);
            this.Insertar.TabIndex = 0;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = false;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Button_eliminar
            // 
            this.Button_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Button_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Button_eliminar.FlatAppearance.BorderSize = 2;
            this.Button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_eliminar.Location = new System.Drawing.Point(28, 128);
            this.Button_eliminar.Name = "Button_eliminar";
            this.Button_eliminar.Size = new System.Drawing.Size(92, 28);
            this.Button_eliminar.TabIndex = 1;
            this.Button_eliminar.Text = "Eliminar";
            this.Button_eliminar.UseVisualStyleBackColor = false;
            this.Button_eliminar.Click += new System.EventHandler(this.Button_eliminar_Click);
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Button_Buscar.FlatAppearance.BorderSize = 2;
            this.Button_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Buscar.Location = new System.Drawing.Point(28, 162);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(92, 28);
            this.Button_Buscar.TabIndex = 2;
            this.Button_Buscar.Text = "Buscar";
            this.Button_Buscar.UseVisualStyleBackColor = false;
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(143, 97);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 3;
            // 
            // txtDatoEliminar
            // 
            this.txtDatoEliminar.Location = new System.Drawing.Point(143, 133);
            this.txtDatoEliminar.Name = "txtDatoEliminar";
            this.txtDatoEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtDatoEliminar.TabIndex = 4;
            // 
            // txtDatoBuscar
            // 
            this.txtDatoBuscar.Location = new System.Drawing.Point(143, 169);
            this.txtDatoBuscar.Name = "txtDatoBuscar";
            this.txtDatoBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtDatoBuscar.TabIndex = 5;
            // 
            // Enorden
            // 
            this.Enorden.BackColor = System.Drawing.Color.Transparent;
            this.Enorden.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Enorden.FlatAppearance.BorderSize = 2;
            this.Enorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enorden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enorden.Location = new System.Drawing.Point(28, 234);
            this.Enorden.Name = "Enorden";
            this.Enorden.Size = new System.Drawing.Size(92, 28);
            this.Enorden.TabIndex = 6;
            this.Enorden.Text = "En orden";
            this.Enorden.UseVisualStyleBackColor = false;
            this.Enorden.Click += new System.EventHandler(this.Orden);
            // 
            // Preorden
            // 
            this.Preorden.BackColor = System.Drawing.Color.Transparent;
            this.Preorden.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Preorden.FlatAppearance.BorderSize = 2;
            this.Preorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preorden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Preorden.Location = new System.Drawing.Point(143, 233);
            this.Preorden.Name = "Preorden";
            this.Preorden.Size = new System.Drawing.Size(92, 28);
            this.Preorden.TabIndex = 7;
            this.Preorden.Text = "Pre-orden";
            this.Preorden.UseVisualStyleBackColor = false;
            this.Preorden.Click += new System.EventHandler(this.preOrden);
            // 
            // PostOrden
            // 
            this.PostOrden.BackColor = System.Drawing.Color.Transparent;
            this.PostOrden.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.PostOrden.FlatAppearance.BorderSize = 2;
            this.PostOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PostOrden.Location = new System.Drawing.Point(84, 270);
            this.PostOrden.Name = "PostOrden";
            this.PostOrden.Size = new System.Drawing.Size(92, 28);
            this.PostOrden.TabIndex = 8;
            this.PostOrden.Text = "Post-orden";
            this.PostOrden.UseVisualStyleBackColor = false;
            this.PostOrden.Click += new System.EventHandler(this.postOrden);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.Transparent;
            this.Suma.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Suma.FlatAppearance.BorderSize = 2;
            this.Suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Suma.Location = new System.Drawing.Point(28, 347);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(92, 28);
            this.Suma.TabIndex = 9;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(28, 386);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 28);
            this.button8.TabIndex = 10;
            this.button8.Text = "Multiplos";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Menor
            // 
            this.Menor.BackColor = System.Drawing.Color.Transparent;
            this.Menor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Menor.FlatAppearance.BorderSize = 2;
            this.Menor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menor.Location = new System.Drawing.Point(28, 423);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(92, 28);
            this.Menor.TabIndex = 13;
            this.Menor.Text = "Menor";
            this.Menor.UseVisualStyleBackColor = false;
            this.Menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // Mayor
            // 
            this.Mayor.BackColor = System.Drawing.Color.Transparent;
            this.Mayor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Mayor.FlatAppearance.BorderSize = 2;
            this.Mayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mayor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mayor.Location = new System.Drawing.Point(143, 423);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(92, 28);
            this.Mayor.TabIndex = 14;
            this.Mayor.Text = "Mayor";
            this.Mayor.UseVisualStyleBackColor = false;
            this.Mayor.Click += new System.EventHandler(this.Mayor_Click);
            // 
            // Altura
            // 
            this.Altura.BackColor = System.Drawing.Color.Transparent;
            this.Altura.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Altura.FlatAppearance.BorderSize = 2;
            this.Altura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Altura.Location = new System.Drawing.Point(738, 39);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(92, 28);
            this.Altura.TabIndex = 19;
            this.Altura.Text = "Altura";
            this.Altura.UseVisualStyleBackColor = false;
            this.Altura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // textbox5
            // 
            this.textbox5.Location = new System.Drawing.Point(836, 44);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(53, 20);
            this.textbox5.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 33);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(910, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(885, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Árbol Númerico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Recorrer";
            // 
            // sumatoria
            // 
            this.sumatoria.Location = new System.Drawing.Point(143, 351);
            this.sumatoria.Name = "sumatoria";
            this.sumatoria.ReadOnly = true;
            this.sumatoria.Size = new System.Drawing.Size(92, 20);
            this.sumatoria.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Operaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(143, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Modificar árbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 521);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.sumatoria);
            this.Controls.Add(this.Mayor);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.PostOrden);
            this.Controls.Add(this.Preorden);
            this.Controls.Add(this.Enorden);
            this.Controls.Add(this.txtDatoBuscar);
            this.Controls.Add(this.txtDatoEliminar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.Button_Buscar);
            this.Controls.Add(this.Button_eliminar);
            this.Controls.Add(this.Insertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button Button_eliminar;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtDatoEliminar;
        private System.Windows.Forms.TextBox txtDatoBuscar;
        private System.Windows.Forms.Button Enorden;
        private System.Windows.Forms.Button Preorden;
        private System.Windows.Forms.Button PostOrden;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Menor;
        private System.Windows.Forms.Button Mayor;
        private System.Windows.Forms.Button Altura;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sumatoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

