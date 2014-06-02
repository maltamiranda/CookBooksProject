namespace CookBooks.Deposito1
{
    partial class agregarLote
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
            this.descripcionBox = new System.Windows.Forms.TextBox();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.vencimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.vencimientoBox = new System.Windows.Forms.DateTimePicker();
            this.descripcion = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(96, 26);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionBox.TabIndex = 0;
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(96, 64);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadBox.TabIndex = 1;
            // 
            // vencimientoCheckBox
            //
            /*
            this.vencimientoCheckBox.AutoSize = true;
            this.vencimientoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoCheckBox.Location = new System.Drawing.Point(96, 105);
            this.vencimientoCheckBox.Name = "vencimientoCheckBox";
            this.vencimientoCheckBox.Size = new System.Drawing.Size(148, 17);
            this.vencimientoCheckBox.TabIndex = 2;
            this.vencimientoCheckBox.Text = "Contiene vencimiento";
            this.vencimientoCheckBox.UseVisualStyleBackColor = true;
            this.vencimientoCheckBox.CheckedChanged += new System.EventHandler(this.vencimientoCheckBox_CheckedChanged);
            // */
            // vencimientoBox
            // 
            this.vencimientoBox.Location = new System.Drawing.Point(96, 140);
            this.vencimientoBox.Name = "vencimientoBox";
            this.vencimientoBox.Size = new System.Drawing.Size(200, 20);
            this.vencimientoBox.TabIndex = 3;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(13, 29);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(74, 13);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "Descripción";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(13, 67);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(57, 13);
            this.cantidad.TabIndex = 5;
            this.cantidad.Text = "Cantidad";
            // 
            // aceptar
            // 
            /*
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(221, 188);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 6;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // agregarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(319, 232);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.vencimientoBox);
            this.Controls.Add(this.vencimientoCheckBox);
            this.Controls.Add(this.cantidadBox);
            this.Controls.Add(this.descripcionBox);
            this.Name = "agregarLote";
            this.Text = "agregarLote";
            this.Load += new System.EventHandler(this.agregarLote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            */
        }

        #endregion

        private System.Windows.Forms.TextBox descripcionBox;
        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.CheckBox vencimientoCheckBox;
        private System.Windows.Forms.DateTimePicker vencimientoBox;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Button aceptar;
    }
}