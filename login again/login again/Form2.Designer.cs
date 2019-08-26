namespace login_again
{
    partial class ventana2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcs = new System.Windows.Forms.CheckBox();
            this.cbvisual = new System.Windows.Forms.CheckBox();
            this.txtcerrar = new System.Windows.Forms.Button();
            this.txtcomprar = new System.Windows.Forms.Button();
            this.rbtarjeta = new System.Windows.Forms.RadioButton();
            this.rbpaypal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSOS EN VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(500, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "FORMAS DE PAGO";
            // 
            // cbcs
            // 
            this.cbcs.AutoSize = true;
            this.cbcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcs.Location = new System.Drawing.Point(51, 114);
            this.cbcs.Name = "cbcs";
            this.cbcs.Size = new System.Drawing.Size(102, 20);
            this.cbcs.TabIndex = 2;
            this.cbcs.Text = "VISUAL C#";
            this.cbcs.UseVisualStyleBackColor = true;
            // 
            // cbvisual
            // 
            this.cbvisual.AutoSize = true;
            this.cbvisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvisual.Location = new System.Drawing.Point(51, 188);
            this.cbvisual.Name = "cbvisual";
            this.cbvisual.Size = new System.Drawing.Size(128, 20);
            this.cbvisual.TabIndex = 3;
            this.cbvisual.Text = "VISUAL BASIC";
            this.cbvisual.UseVisualStyleBackColor = true;
            // 
            // txtcerrar
            // 
            this.txtcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtcerrar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcerrar.Location = new System.Drawing.Point(564, 311);
            this.txtcerrar.Name = "txtcerrar";
            this.txtcerrar.Size = new System.Drawing.Size(148, 79);
            this.txtcerrar.TabIndex = 6;
            this.txtcerrar.Text = "CERRAR";
            this.txtcerrar.UseVisualStyleBackColor = false;
            this.txtcerrar.Click += new System.EventHandler(this.Txtcerrar_Click);
            // 
            // txtcomprar
            // 
            this.txtcomprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtcomprar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomprar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcomprar.Location = new System.Drawing.Point(47, 309);
            this.txtcomprar.Name = "txtcomprar";
            this.txtcomprar.Size = new System.Drawing.Size(132, 81);
            this.txtcomprar.TabIndex = 7;
            this.txtcomprar.Text = "COMPRAR";
            this.txtcomprar.UseVisualStyleBackColor = false;
            this.txtcomprar.Click += new System.EventHandler(this.Txtcomprar_Click);
            // 
            // rbtarjeta
            // 
            this.rbtarjeta.AutoSize = true;
            this.rbtarjeta.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtarjeta.Location = new System.Drawing.Point(560, 114);
            this.rbtarjeta.Name = "rbtarjeta";
            this.rbtarjeta.Size = new System.Drawing.Size(131, 21);
            this.rbtarjeta.TabIndex = 8;
            this.rbtarjeta.TabStop = true;
            this.rbtarjeta.Text = "tarjeta de pago";
            this.rbtarjeta.UseVisualStyleBackColor = true;
            // 
            // rbpaypal
            // 
            this.rbpaypal.AutoSize = true;
            this.rbpaypal.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpaypal.Location = new System.Drawing.Point(583, 198);
            this.rbpaypal.Name = "rbpaypal";
            this.rbpaypal.Size = new System.Drawing.Size(72, 21);
            this.rbpaypal.TabIndex = 9;
            this.rbpaypal.TabStop = true;
            this.rbpaypal.Text = "paypal";
            this.rbpaypal.UseVisualStyleBackColor = true;
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::login_again.Properties.Resources.depositphotos_106074324_stock_illustration_kawaii_eggs_pattern;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbpaypal);
            this.Controls.Add(this.rbtarjeta);
            this.Controls.Add(this.txtcomprar);
            this.Controls.Add(this.txtcerrar);
            this.Controls.Add(this.cbvisual);
            this.Controls.Add(this.cbcs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventana2";
            this.Text = "Ventana2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbcs;
        private System.Windows.Forms.CheckBox cbvisual;
        private System.Windows.Forms.Button txtcerrar;
        private System.Windows.Forms.Button txtcomprar;
        private System.Windows.Forms.RadioButton rbtarjeta;
        private System.Windows.Forms.RadioButton rbpaypal;
    }
}