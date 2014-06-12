namespace CookBooks.Deposito1
{
    partial class CrearLibro
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
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.precioBox = new System.Windows.Forms.TextBox();
            this.temaBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.temaLabel = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.editorialLabel = new System.Windows.Forms.Label();
            this.editorialBox = new System.Windows.Forms.TextBox();
            //this.agregarAutores = new System.Windows.Forms.Button();
            this.crearAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(136, 12);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(116, 20);
            this.nombreBox.TabIndex = 0;
            this.nombreBox.TextChanged += new System.EventHandler(this.nombreBox_TextChanged);
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(136, 167);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(116, 20);
            this.cantidadBox.TabIndex = 1;
            // 
            // precioBox
            // 
            this.precioBox.Location = new System.Drawing.Point(136, 128);
            this.precioBox.Name = "precioBox";
            this.precioBox.Size = new System.Drawing.Size(116, 20);
            this.precioBox.TabIndex = 2;
            // 
            // temaBox
            // 
            this.temaBox.Location = new System.Drawing.Point(136, 50);
            this.temaBox.Name = "temaBox";
            this.temaBox.Size = new System.Drawing.Size(116, 20);
            this.temaBox.TabIndex = 3;
            this.temaBox.TextChanged += new System.EventHandler(this.temaBox_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(49, 15);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(49, 170);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(57, 13);
            this.cantidadLabel.TabIndex = 5;
            this.cantidadLabel.Text = "Cantidad";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(49, 131);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(43, 13);
            this.precioLabel.TabIndex = 6;
            this.precioLabel.Text = "Precio";
            // 
            // temaLabel
            // 
            this.temaLabel.AutoSize = true;
            this.temaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temaLabel.Location = new System.Drawing.Point(49, 53);
            this.temaLabel.Name = "temaLabel";
            this.temaLabel.Size = new System.Drawing.Size(38, 13);
            this.temaLabel.TabIndex = 7;
            this.temaLabel.Text = "Tema";
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(282, 334);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(87, 23);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // editorialLabel
            // 
            this.editorialLabel.AutoSize = true;
            this.editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialLabel.Location = new System.Drawing.Point(49, 92);
            this.editorialLabel.Name = "editorialLabel";
            this.editorialLabel.Size = new System.Drawing.Size(53, 13);
            this.editorialLabel.TabIndex = 13;
            this.editorialLabel.Text = "Editorial";
            // 
            // editorialBox
            // 
            this.editorialBox.Location = new System.Drawing.Point(136, 89);
            this.editorialBox.Name = "editorialBox";
            this.editorialBox.Size = new System.Drawing.Size(116, 20);
            this.editorialBox.TabIndex = 12;
            // 
            // agregarAutores
            // 
            /*
            this.agregarAutores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.agregarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAutores.Location = new System.Drawing.Point(136, 225);
            this.agregarAutores.Name = "agregarAutores";
            this.agregarAutores.Size = new System.Drawing.Size(116, 23);
            this.agregarAutores.TabIndex = 14;
            this.agregarAutores.Text = "Agregar Autores";
            this.agregarAutores.UseVisualStyleBackColor = false;
            // 
             */
            // crearAutor
            // 
            this.crearAutor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.crearAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearAutor.Location = new System.Drawing.Point(136, 272);
            this.crearAutor.Name = "crearAutor";
            this.crearAutor.Size = new System.Drawing.Size(116, 23);
            this.crearAutor.TabIndex = 15;
            this.crearAutor.Text = "CrearAutor";
            this.crearAutor.UseVisualStyleBackColor = false;
            this.crearAutor.Click += new System.EventHandler(this.crearAutor_Click);
            // 
            // CrearLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(391, 384);
            this.Controls.Add(this.crearAutor);
            //this.Controls.Add(this.agregarAutores);
            this.Controls.Add(this.editorialLabel);
            this.Controls.Add(this.editorialBox);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.temaLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.temaBox);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.cantidadBox);
            this.Controls.Add(this.nombreBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CrearLibro";
            this.Text = "CrearProducto";
            this.Load += new System.EventHandler(this.CrearLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.TextBox precioBox;
        private System.Windows.Forms.TextBox temaBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label temaLabel;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label editorialLabel;
        private System.Windows.Forms.TextBox editorialBox;
        //private System.Windows.Forms.Button agregarAutores;
        private System.Windows.Forms.Button crearAutor;
    }
}