namespace CookBooks.Deposito1
{
    partial class CrearAutor
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
            this.aceptar = new System.Windows.Forms.Button();
            this.nacionalidadBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(157, 159);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(87, 23);
            this.aceptar.TabIndex = 18;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // nacionalidadBox
            // 
            this.nacionalidadBox.Location = new System.Drawing.Point(128, 102);
            this.nacionalidadBox.Name = "nacionalidadBox";
            this.nacionalidadBox.Size = new System.Drawing.Size(116, 20);
            this.nacionalidadBox.TabIndex = 17;
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(128, 67);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(116, 20);
            this.apellidoBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nacionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(128, 31);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(116, 20);
            this.nombreBox.TabIndex = 13;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(41, 34);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreLabel.TabIndex = 12;
            this.nombreLabel.Text = "Nombre";
            // 
            // CrearAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.nacionalidadBox);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.nombreLabel);
            this.Name = "CrearAutor";
            this.Text = "CrearAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox nacionalidadBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label nombreLabel;
    }
}