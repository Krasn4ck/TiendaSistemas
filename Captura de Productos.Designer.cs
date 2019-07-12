namespace TiendaElectronica
{
    partial class CapturaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturaProductos));
            this.RealTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.ProductCode = new System.Windows.Forms.TextBox();
            this.PriceProduct = new System.Windows.Forms.TextBox();
            this.MinimumProduct = new System.Windows.Forms.TextBox();
            this.SoldProduct = new System.Windows.Forms.ComboBox();
            this.StockTotal = new System.Windows.Forms.TextBox();
            this.LimitStock = new System.Windows.Forms.TextBox();
            this.DirDatasheet = new System.Windows.Forms.TextBox();
            this.AddPdf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FamilyProduct = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StockMaxim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchProd = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AddRadio = new System.Windows.Forms.RadioButton();
            this.EditRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Erasebutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RealTime
            // 
            this.RealTime.AutoSize = true;
            this.RealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTime.Location = new System.Drawing.Point(550, 13);
            this.RealTime.Name = "RealTime";
            this.RealTime.Size = new System.Drawing.Size(159, 20);
            this.RealTime.TabIndex = 0;
            this.RealTime.Text = "00:00:00  DD/MM/YY";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el Nombre del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa el Codigo de Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa el Precio de Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidades Minimas de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Se vende por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stock Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Limite de Stock Bajo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cargar Datasheet del Producto:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(673, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NameProduct
            // 
            this.NameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.Location = new System.Drawing.Point(262, 92);
            this.NameProduct.Multiline = true;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(260, 30);
            this.NameProduct.TabIndex = 11;
            // 
            // ProductCode
            // 
            this.ProductCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode.Location = new System.Drawing.Point(262, 134);
            this.ProductCode.Multiline = true;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Size = new System.Drawing.Size(103, 31);
            this.ProductCode.TabIndex = 12;
            // 
            // PriceProduct
            // 
            this.PriceProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceProduct.Location = new System.Drawing.Point(262, 180);
            this.PriceProduct.Multiline = true;
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(103, 31);
            this.PriceProduct.TabIndex = 13;
            // 
            // MinimumProduct
            // 
            this.MinimumProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumProduct.Location = new System.Drawing.Point(262, 230);
            this.MinimumProduct.Multiline = true;
            this.MinimumProduct.Name = "MinimumProduct";
            this.MinimumProduct.Size = new System.Drawing.Size(103, 31);
            this.MinimumProduct.TabIndex = 14;
            // 
            // SoldProduct
            // 
            this.SoldProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "Mt",
            "Caja",
            "Paquete",
            "Unidades",
            "Kg"});
            this.SoldProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldProduct.FormattingEnabled = true;
            this.SoldProduct.Location = new System.Drawing.Point(262, 274);
            this.SoldProduct.Name = "SoldProduct";
            this.SoldProduct.Size = new System.Drawing.Size(121, 29);
            this.SoldProduct.TabIndex = 15;
            // 
            // StockTotal
            // 
            this.StockTotal.Location = new System.Drawing.Point(262, 315);
            this.StockTotal.Multiline = true;
            this.StockTotal.Name = "StockTotal";
            this.StockTotal.Size = new System.Drawing.Size(103, 31);
            this.StockTotal.TabIndex = 16;
            // 
            // LimitStock
            // 
            this.LimitStock.Location = new System.Drawing.Point(262, 357);
            this.LimitStock.Multiline = true;
            this.LimitStock.Name = "LimitStock";
            this.LimitStock.Size = new System.Drawing.Size(103, 31);
            this.LimitStock.TabIndex = 17;
            // 
            // DirDatasheet
            // 
            this.DirDatasheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirDatasheet.Location = new System.Drawing.Point(262, 441);
            this.DirDatasheet.Multiline = true;
            this.DirDatasheet.Name = "DirDatasheet";
            this.DirDatasheet.Size = new System.Drawing.Size(334, 31);
            this.DirDatasheet.TabIndex = 18;
            // 
            // AddPdf
            // 
            this.AddPdf.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddPdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPdf.Image = ((System.Drawing.Image)(resources.GetObject("AddPdf.Image")));
            this.AddPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPdf.Location = new System.Drawing.Point(624, 441);
            this.AddPdf.Name = "AddPdf";
            this.AddPdf.Size = new System.Drawing.Size(125, 38);
            this.AddPdf.TabIndex = 19;
            this.AddPdf.Text = "Cargar";
            this.AddPdf.UseVisualStyleBackColor = false;
            this.AddPdf.Click += new System.EventHandler(this.AddPdf_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(184, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Agregar al inventario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(438, 144);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(94, 21);
            this.Description.TabIndex = 22;
            this.Description.Text = "Descripcion:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(441, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 181);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // FamilyProduct
            // 
            this.FamilyProduct.AutoSize = true;
            this.FamilyProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyProduct.Location = new System.Drawing.Point(34, 501);
            this.FamilyProduct.Name = "FamilyProduct";
            this.FamilyProduct.Size = new System.Drawing.Size(154, 21);
            this.FamilyProduct.TabIndex = 24;
            this.FamilyProduct.Text = "Familia del Producto:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "TTL";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 493);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 29);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Limite de Stock Maximo:";
            // 
            // StockMaxim
            // 
            this.StockMaxim.Location = new System.Drawing.Point(262, 395);
            this.StockMaxim.Multiline = true;
            this.StockMaxim.Name = "StockMaxim";
            this.StockMaxim.Size = new System.Drawing.Size(103, 31);
            this.StockMaxim.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Editar Producto: ";
            this.label10.Visible = false;
            // 
            // SearchProd
            // 
            this.SearchProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProd.Location = new System.Drawing.Point(262, 57);
            this.SearchProd.Multiline = true;
            this.SearchProd.Name = "SearchProd";
            this.SearchProd.Size = new System.Drawing.Size(260, 29);
            this.SearchProd.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(554, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 30);
            this.button4.TabIndex = 30;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // AddRadio
            // 
            this.AddRadio.AutoSize = true;
            this.AddRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRadio.Location = new System.Drawing.Point(0, 15);
            this.AddRadio.Name = "AddRadio";
            this.AddRadio.Size = new System.Drawing.Size(157, 19);
            this.AddRadio.TabIndex = 31;
            this.AddRadio.TabStop = true;
            this.AddRadio.Text = "Agregar Producto Nuevo";
            this.AddRadio.UseVisualStyleBackColor = true;
            this.AddRadio.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // EditRadio
            // 
            this.EditRadio.AutoSize = true;
            this.EditRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRadio.Location = new System.Drawing.Point(159, 15);
            this.EditRadio.Name = "EditRadio";
            this.EditRadio.Size = new System.Drawing.Size(110, 19);
            this.EditRadio.TabIndex = 32;
            this.EditRadio.TabStop = true;
            this.EditRadio.Text = "Editar Producto ";
            this.EditRadio.UseVisualStyleBackColor = true;
            this.EditRadio.CheckedChanged += new System.EventHandler(this.EditRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddRadio);
            this.groupBox1.Controls.Add(this.EditRadio);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(216, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 40);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona una opcion:";
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Image = ((System.Drawing.Image)(resources.GetObject("Updatebutton.Image")));
            this.Updatebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Updatebutton.Location = new System.Drawing.Point(589, 498);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(183, 40);
            this.Updatebutton.TabIndex = 43;
            this.Updatebutton.Text = "Actualizar Producto";
            this.Updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatebutton.UseVisualStyleBackColor = false;
            // 
            // Erasebutton
            // 
            this.Erasebutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Erasebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erasebutton.Image = ((System.Drawing.Image)(resources.GetObject("Erasebutton.Image")));
            this.Erasebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Erasebutton.Location = new System.Drawing.Point(597, 544);
            this.Erasebutton.Name = "Erasebutton";
            this.Erasebutton.Size = new System.Drawing.Size(175, 40);
            this.Erasebutton.TabIndex = 42;
            this.Erasebutton.Text = "Eliminar Producto";
            this.Erasebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Erasebutton.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(442, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 41);
            this.button3.TabIndex = 44;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CapturaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Erasebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StockMaxim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FamilyProduct);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddPdf);
            this.Controls.Add(this.DirDatasheet);
            this.Controls.Add(this.LimitStock);
            this.Controls.Add(this.StockTotal);
            this.Controls.Add(this.SoldProduct);
            this.Controls.Add(this.MinimumProduct);
            this.Controls.Add(this.PriceProduct);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RealTime);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CapturaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RealTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.TextBox ProductCode;
        private System.Windows.Forms.TextBox PriceProduct;
        private System.Windows.Forms.TextBox MinimumProduct;
        private System.Windows.Forms.ComboBox SoldProduct;
        private System.Windows.Forms.TextBox StockTotal;
        private System.Windows.Forms.TextBox LimitStock;
        private System.Windows.Forms.TextBox DirDatasheet;
        private System.Windows.Forms.Button AddPdf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label FamilyProduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StockMaxim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SearchProd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton AddRadio;
        private System.Windows.Forms.RadioButton EditRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Erasebutton;
        private System.Windows.Forms.Button button3;
    }
}