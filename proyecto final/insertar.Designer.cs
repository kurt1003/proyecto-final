namespace proyecto_final
{
    partial class insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertar));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.textBox_marca = new System.Windows.Forms.TextBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_producto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_codigo);
            this.panel1.Controls.Add(this.textBox_marca);
            this.panel1.Controls.Add(this.textBox_precio);
            this.panel1.Controls.Add(this.textBox_stock);
            this.panel1.Controls.Add(this.textBox_producto);
            this.panel1.Location = new System.Drawing.Point(41, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 318);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_codigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigo.ForeColor = System.Drawing.Color.White;
            this.textBox_codigo.Location = new System.Drawing.Point(68, 37);
            this.textBox_codigo.Multiline = true;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(180, 26);
            this.textBox_codigo.TabIndex = 7;
            this.textBox_codigo.Text = "Código";
            this.textBox_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_codigo.TextChanged += new System.EventHandler(this.textBox_codigo_TextChanged);
            this.textBox_codigo.Enter += new System.EventHandler(this.textBox_codigo_Enter_1);
            this.textBox_codigo.Leave += new System.EventHandler(this.textBox_codigo_Leave_1);
            // 
            // textBox_marca
            // 
            this.textBox_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_marca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_marca.ForeColor = System.Drawing.Color.White;
            this.textBox_marca.Location = new System.Drawing.Point(68, 253);
            this.textBox_marca.Multiline = true;
            this.textBox_marca.Name = "textBox_marca";
            this.textBox_marca.Size = new System.Drawing.Size(180, 26);
            this.textBox_marca.TabIndex = 6;
            this.textBox_marca.Text = "Marca";
            this.textBox_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_marca.Enter += new System.EventHandler(this.textBox_marca_Enter);
            this.textBox_marca.Leave += new System.EventHandler(this.textBox_marca_Leave);
            // 
            // textBox_precio
            // 
            this.textBox_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_precio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_precio.ForeColor = System.Drawing.Color.White;
            this.textBox_precio.Location = new System.Drawing.Point(68, 196);
            this.textBox_precio.Multiline = true;
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(180, 26);
            this.textBox_precio.TabIndex = 5;
            this.textBox_precio.Text = "Precio";
            this.textBox_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_precio.Enter += new System.EventHandler(this.textBox_precio_Enter);
            this.textBox_precio.Leave += new System.EventHandler(this.textBox_precio_Leave);
            // 
            // textBox_stock
            // 
            this.textBox_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stock.ForeColor = System.Drawing.Color.White;
            this.textBox_stock.Location = new System.Drawing.Point(68, 138);
            this.textBox_stock.Multiline = true;
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(180, 26);
            this.textBox_stock.TabIndex = 4;
            this.textBox_stock.Text = "Stock";
            this.textBox_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_stock.Enter += new System.EventHandler(this.textBox_stock_Enter);
            this.textBox_stock.Leave += new System.EventHandler(this.textBox_stock_Leave);
            // 
            // textBox_producto
            // 
            this.textBox_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_producto.ForeColor = System.Drawing.Color.White;
            this.textBox_producto.Location = new System.Drawing.Point(68, 84);
            this.textBox_producto.Multiline = true;
            this.textBox_producto.Name = "textBox_producto";
            this.textBox_producto.Size = new System.Drawing.Size(180, 26);
            this.textBox_producto.TabIndex = 1;
            this.textBox_producto.Text = "Producto";
            this.textBox_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_producto.TextChanged += new System.EventHandler(this.textBox_producto_TextChanged);
            this.textBox_producto.Enter += new System.EventHandler(this.textBox_producto_Enter);
            this.textBox_producto.Leave += new System.EventHandler(this.textBox_producto_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox_correo);
            this.panel3.Controls.Add(this.textBox_direccion);
            this.panel3.Controls.Add(this.textBox_telefono);
            this.panel3.Controls.Add(this.textBox_proveedor);
            this.panel3.Location = new System.Drawing.Point(444, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 318);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox_correo
            // 
            this.textBox_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_correo.ForeColor = System.Drawing.Color.White;
            this.textBox_correo.Location = new System.Drawing.Point(71, 180);
            this.textBox_correo.Multiline = true;
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(190, 26);
            this.textBox_correo.TabIndex = 8;
            this.textBox_correo.Text = "Correo electrónico";
            this.textBox_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_correo.Enter += new System.EventHandler(this.textBox_correo_Enter);
            this.textBox_correo.Leave += new System.EventHandler(this.textBox_correo_Leave);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion.ForeColor = System.Drawing.Color.White;
            this.textBox_direccion.Location = new System.Drawing.Point(71, 244);
            this.textBox_direccion.Multiline = true;
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(190, 26);
            this.textBox_direccion.TabIndex = 7;
            this.textBox_direccion.Text = "Dirección";
            this.textBox_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_direccion.Enter += new System.EventHandler(this.textBox_direccion_Enter);
            this.textBox_direccion.Leave += new System.EventHandler(this.textBox_direccion_Leave);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.ForeColor = System.Drawing.Color.White;
            this.textBox_telefono.Location = new System.Drawing.Point(73, 100);
            this.textBox_telefono.Multiline = true;
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(190, 26);
            this.textBox_telefono.TabIndex = 6;
            this.textBox_telefono.Text = "Número de teléfono";
            this.textBox_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_telefono.Enter += new System.EventHandler(this.textBox_telefono_Enter);
            this.textBox_telefono.Leave += new System.EventHandler(this.textBox_telefono_Leave);
            // 
            // textBox_proveedor
            // 
            this.textBox_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox_proveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_proveedor.ForeColor = System.Drawing.Color.White;
            this.textBox_proveedor.Location = new System.Drawing.Point(73, 37);
            this.textBox_proveedor.Multiline = true;
            this.textBox_proveedor.Name = "textBox_proveedor";
            this.textBox_proveedor.Size = new System.Drawing.Size(190, 26);
            this.textBox_proveedor.TabIndex = 5;
            this.textBox_proveedor.Text = "Proveedor";
            this.textBox_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_proveedor.TextChanged += new System.EventHandler(this.textBox_proveedor_TextChanged);
            this.textBox_proveedor.Enter += new System.EventHandler(this.textBox_proveedor_Enter);
            this.textBox_proveedor.Leave += new System.EventHandler(this.textBox_proveedor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(440, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proveedor";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(21, 463);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(424, 114);
            this.textBox9.TabIndex = 8;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 465);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Controls.Add(this.dataRepeater1.ItemTemplate);
            this.dataRepeater1.Location = new System.Drawing.Point(0, 0);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(240, 150);
            this.dataRepeater1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(517, 557);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha inico de garantia";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha fin de garantia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_insertar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertar.ForeColor = System.Drawing.Color.Black;
            this.button_insertar.Location = new System.Drawing.Point(737, 509);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(102, 33);
            this.button_insertar.TabIndex = 14;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = false;
            this.button_insertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(823, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 37);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(862, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertar";
            this.Opacity = 0.9D;
            this.Text = "insertar";
            this.Load += new System.EventHandler(this.insertar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_producto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.TextBox textBox_marca;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Button button1;
    }
}