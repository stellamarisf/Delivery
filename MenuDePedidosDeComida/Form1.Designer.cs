
namespace MenuDePedidosDeComida
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbOtOp = new System.Windows.Forms.RadioButton();
            this.RdbEnYoAg = new System.Windows.Forms.RadioButton();
            this.RdbPiNuRe = new System.Windows.Forms.RadioButton();
            this.RdbHamPaRef = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtyogourth = new System.Windows.Forms.TextBox();
            this.txtEnsalada = new System.Windows.Forms.TextBox();
            this.txtNugghets = new System.Windows.Forms.TextBox();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.txtRefresco = new System.Windows.Forms.TextBox();
            this.txtpapas = new System.Windows.Forms.TextBox();
            this.txtHamburguesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.btnvolveraUsar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.RdbOtOp);
            this.groupBox1.Controls.Add(this.RdbEnYoAg);
            this.groupBox1.Controls.Add(this.RdbPiNuRe);
            this.groupBox1.Controls.Add(this.RdbHamPaRef);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(71, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdbOtOp
            // 
            this.RdbOtOp.AutoSize = true;
            this.RdbOtOp.Location = new System.Drawing.Point(27, 159);
            this.RdbOtOp.Name = "RdbOtOp";
            this.RdbOtOp.Size = new System.Drawing.Size(118, 21);
            this.RdbOtOp.TabIndex = 3;
            this.RdbOtOp.TabStop = true;
            this.RdbOtOp.Text = "Otras opciones";
            this.RdbOtOp.UseVisualStyleBackColor = true;
            this.RdbOtOp.CheckedChanged += new System.EventHandler(this.RdbOtOp_CheckedChanged);
            // 
            // RdbEnYoAg
            // 
            this.RdbEnYoAg.AutoSize = true;
            this.RdbEnYoAg.Location = new System.Drawing.Point(27, 117);
            this.RdbEnYoAg.Name = "RdbEnYoAg";
            this.RdbEnYoAg.Size = new System.Drawing.Size(186, 21);
            this.RdbEnYoAg.TabIndex = 2;
            this.RdbEnYoAg.TabStop = true;
            this.RdbEnYoAg.Text = "Ensalada,yogourth y agua";
            this.RdbEnYoAg.UseVisualStyleBackColor = true;
            this.RdbEnYoAg.CheckedChanged += new System.EventHandler(this.RdbEnYoAg_CheckedChanged);
            // 
            // RdbPiNuRe
            // 
            this.RdbPiNuRe.AutoSize = true;
            this.RdbPiNuRe.Location = new System.Drawing.Point(27, 75);
            this.RdbPiNuRe.Name = "RdbPiNuRe";
            this.RdbPiNuRe.Size = new System.Drawing.Size(185, 21);
            this.RdbPiNuRe.TabIndex = 1;
            this.RdbPiNuRe.TabStop = true;
            this.RdbPiNuRe.Text = "Pizza,Nugghets y refresco";
            this.RdbPiNuRe.UseVisualStyleBackColor = true;
            this.RdbPiNuRe.CheckedChanged += new System.EventHandler(this.RdbPiNuRe_CheckedChanged);
            // 
            // RdbHamPaRef
            // 
            this.RdbHamPaRef.AutoSize = true;
            this.RdbHamPaRef.Location = new System.Drawing.Point(27, 36);
            this.RdbHamPaRef.Name = "RdbHamPaRef";
            this.RdbHamPaRef.Size = new System.Drawing.Size(216, 21);
            this.RdbHamPaRef.TabIndex = 0;
            this.RdbHamPaRef.TabStop = true;
            this.RdbHamPaRef.Text = "Hamburguesa,papas y refresco";
            this.RdbHamPaRef.UseVisualStyleBackColor = true;
            this.RdbHamPaRef.CheckedChanged += new System.EventHandler(this.RdbHamPaRef_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.txtAgua);
            this.groupBox2.Controls.Add(this.txtyogourth);
            this.groupBox2.Controls.Add(this.txtEnsalada);
            this.groupBox2.Controls.Add(this.txtNugghets);
            this.groupBox2.Controls.Add(this.txtPizza);
            this.groupBox2.Controls.Add(this.txtRefresco);
            this.groupBox2.Controls.Add(this.txtpapas);
            this.groupBox2.Controls.Add(this.txtHamburguesa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(446, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtAgua
            // 
            this.txtAgua.Enabled = false;
            this.txtAgua.Location = new System.Drawing.Point(38, 197);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(87, 25);
            this.txtAgua.TabIndex = 15;
            // 
            // txtyogourth
            // 
            this.txtyogourth.Enabled = false;
            this.txtyogourth.Location = new System.Drawing.Point(38, 170);
            this.txtyogourth.Name = "txtyogourth";
            this.txtyogourth.Size = new System.Drawing.Size(87, 25);
            this.txtyogourth.TabIndex = 14;
            // 
            // txtEnsalada
            // 
            this.txtEnsalada.Enabled = false;
            this.txtEnsalada.Location = new System.Drawing.Point(38, 142);
            this.txtEnsalada.Name = "txtEnsalada";
            this.txtEnsalada.Size = new System.Drawing.Size(87, 25);
            this.txtEnsalada.TabIndex = 13;
            // 
            // txtNugghets
            // 
            this.txtNugghets.Enabled = false;
            this.txtNugghets.Location = new System.Drawing.Point(38, 117);
            this.txtNugghets.Name = "txtNugghets";
            this.txtNugghets.Size = new System.Drawing.Size(87, 25);
            this.txtNugghets.TabIndex = 12;
            // 
            // txtPizza
            // 
            this.txtPizza.Enabled = false;
            this.txtPizza.Location = new System.Drawing.Point(38, 91);
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.Size = new System.Drawing.Size(87, 25);
            this.txtPizza.TabIndex = 11;
            // 
            // txtRefresco
            // 
            this.txtRefresco.Enabled = false;
            this.txtRefresco.Location = new System.Drawing.Point(38, 67);
            this.txtRefresco.Name = "txtRefresco";
            this.txtRefresco.Size = new System.Drawing.Size(87, 25);
            this.txtRefresco.TabIndex = 10;
            // 
            // txtpapas
            // 
            this.txtpapas.Enabled = false;
            this.txtpapas.Location = new System.Drawing.Point(38, 42);
            this.txtpapas.Name = "txtpapas";
            this.txtpapas.Size = new System.Drawing.Size(87, 25);
            this.txtpapas.TabIndex = 9;
            // 
            // txtHamburguesa
            // 
            this.txtHamburguesa.Enabled = false;
            this.txtHamburguesa.Location = new System.Drawing.Point(38, 16);
            this.txtHamburguesa.Name = "txtHamburguesa";
            this.txtHamburguesa.Size = new System.Drawing.Size(87, 25);
            this.txtHamburguesa.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Agua                 $12.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yogourth          $15.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ensalada           $30.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nugghets         $25.00";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pizza                  $70.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Refresco           $12.00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Papas                $15.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hamburguesa $ 35.00";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnterminar);
            this.groupBox3.Controls.Add(this.btnvolveraUsar);
            this.groupBox3.Controls.Add(this.btnPagar);
            this.groupBox3.Controls.Add(this.txtCambio);
            this.groupBox3.Controls.Add(this.txtPago);
            this.groupBox3.Controls.Add(this.txtTotalaPagar);
            this.groupBox3.Controls.Add(this.txtiva);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(71, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caja";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(654, 78);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 33);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(547, 78);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 33);
            this.btnterminar.TabIndex = 12;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click_1);
            // 
            // btnvolveraUsar
            // 
            this.btnvolveraUsar.Location = new System.Drawing.Point(654, 23);
            this.btnvolveraUsar.Name = "btnvolveraUsar";
            this.btnvolveraUsar.Size = new System.Drawing.Size(102, 35);
            this.btnvolveraUsar.TabIndex = 11;
            this.btnvolveraUsar.Text = "Volver a Usar";
            this.btnvolveraUsar.UseVisualStyleBackColor = true;
            this.btnvolveraUsar.Click += new System.EventHandler(this.btnvolveraUsar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(547, 23);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 35);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(430, 88);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 25);
            this.txtCambio.TabIndex = 9;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(430, 59);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 25);
            this.txtPago.TabIndex = 8;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.Location = new System.Drawing.Point(430, 23);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(100, 25);
            this.txtTotalaPagar.TabIndex = 7;
            this.txtTotalaPagar.TextChanged += new System.EventHandler(this.txtTotalaPagar_TextChanged);
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(151, 64);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(100, 25);
            this.txtiva.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(151, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 25);
            this.txtSubtotal.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cambio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total a Pagar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "IVA 16%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Menu de pedidos ♥";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbHamPaRef;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdbOtOp;
        private System.Windows.Forms.RadioButton RdbEnYoAg;
        private System.Windows.Forms.RadioButton RdbPiNuRe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtyogourth;
        private System.Windows.Forms.TextBox txtEnsalada;
        private System.Windows.Forms.TextBox txtNugghets;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.TextBox txtRefresco;
        private System.Windows.Forms.TextBox txtpapas;
        private System.Windows.Forms.TextBox txtHamburguesa;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Button btnvolveraUsar;
    }
}

