namespace CookBooks.Deposito1
{
    partial class ComprarLibro
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
            this.nombreText = new System.Windows.Forms.TextBox();
            this.editorialText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.cantidadText = new System.Windows.Forms.TextBox();
            this.botonCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(233, 45);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(100, 22);
            this.nombreText.TabIndex = 0;
            // 
            // editorialText
            // 
            this.editorialText.Location = new System.Drawing.Point(233, 86);
            this.editorialText.Name = "editorialText";
            this.editorialText.Size = new System.Drawing.Size(100, 22);
            this.editorialText.TabIndex = 1;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(233, 142);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(100, 22);
            this.precioText.TabIndex = 2;
            // 
            // cantidadText
            // 
            this.cantidadText.Location = new System.Drawing.Point(233, 203);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(100, 22);
            this.cantidadText.TabIndex = 3;
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(233, 263);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(100, 56);
            this.botonCompra.TabIndex = 4;
            this.botonCompra.Text = "Comprar!";
            this.botonCompra.UseVisualStyleBackColor = true;
            this.botonCompra.Click += new System.EventHandler(this.botonCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Editorial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio por unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de la compra";
            // 
            // ComprarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.cantidadText);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.editorialText);
            this.Controls.Add(this.nombreText);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "ComprarLibro";
            this.Text = "ComprarLibro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox editorialText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox cantidadText;
        private System.Windows.Forms.Button botonCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}