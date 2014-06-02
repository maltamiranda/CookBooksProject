namespace CookBooks.Deposito1
{
    partial class agregarLibro
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
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(86, 6);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadBox.TabIndex = 0;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(12, 9);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(57, 13);
            this.cantidad.TabIndex = 1;
            this.cantidad.Text = "Cantidad";
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aceptar.Location = new System.Drawing.Point(111, 47);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // agregarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(202, 80);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.cantidadBox);
            this.Name = "agregarCantidad";
            this.Text = "agregarCantidad";
            this.Load += new System.EventHandler(this.agregarCantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Button aceptar;
    }
}