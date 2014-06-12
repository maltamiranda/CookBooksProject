namespace CookBooks.Deposito1
{
    partial class ModificarLibro
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
            this.editorialLabel = new System.Windows.Forms.Label();
            this.editorialBox = new System.Windows.Forms.TextBox();
            this.temaLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.temaBox = new System.Windows.Forms.TextBox();
            this.precioBox = new System.Windows.Forms.TextBox();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editorialLabel
            // 
            this.editorialLabel.AutoSize = true;
            this.editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialLabel.Location = new System.Drawing.Point(83, 107);
            this.editorialLabel.Name = "editorialLabel";
            this.editorialLabel.Size = new System.Drawing.Size(53, 13);
            this.editorialLabel.TabIndex = 23;
            this.editorialLabel.Text = "Editorial";
            // 
            // editorialBox
            // 
            this.editorialBox.Location = new System.Drawing.Point(170, 104);
            this.editorialBox.Name = "editorialBox";
            this.editorialBox.Size = new System.Drawing.Size(116, 20);
            this.editorialBox.TabIndex = 22;
            // 
            // temaLabel
            // 
            this.temaLabel.AutoSize = true;
            this.temaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temaLabel.Location = new System.Drawing.Point(83, 68);
            this.temaLabel.Name = "temaLabel";
            this.temaLabel.Size = new System.Drawing.Size(38, 13);
            this.temaLabel.TabIndex = 21;
            this.temaLabel.Text = "Tema";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(83, 146);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(43, 13);
            this.precioLabel.TabIndex = 20;
            this.precioLabel.Text = "Precio";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(83, 185);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(57, 13);
            this.cantidadLabel.TabIndex = 19;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(83, 30);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreLabel.TabIndex = 18;
            this.nombreLabel.Text = "Nombre";
            // 
            // temaBox
            // 
            this.temaBox.Location = new System.Drawing.Point(170, 65);
            this.temaBox.Name = "temaBox";
            this.temaBox.Size = new System.Drawing.Size(116, 20);
            this.temaBox.TabIndex = 17;
            // 
            // precioBox
            // 
            this.precioBox.Location = new System.Drawing.Point(170, 143);
            this.precioBox.Name = "precioBox";
            this.precioBox.Size = new System.Drawing.Size(116, 20);
            this.precioBox.TabIndex = 16;
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(170, 182);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(116, 20);
            this.cantidadBox.TabIndex = 15;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(170, 27);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(116, 20);
            this.nombreBox.TabIndex = 14;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(163, 325);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(123, 23);
            this.guardar.TabIndex = 24;
            this.guardar.Text = "Guardar Cambios";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(318, 325);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(83, 23);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(422, 370);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.editorialLabel);
            this.Controls.Add(this.editorialBox);
            this.Controls.Add(this.temaLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.temaBox);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.cantidadBox);
            this.Controls.Add(this.nombreBox);
            this.Name = "ModificarLibro";
            this.Text = "ModificarLibro";
            this.Load += new System.EventHandler(this.ModificarLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editorialLabel;
        private System.Windows.Forms.TextBox editorialBox;
        private System.Windows.Forms.Label temaLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox temaBox;
        private System.Windows.Forms.TextBox precioBox;
        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
    }
}