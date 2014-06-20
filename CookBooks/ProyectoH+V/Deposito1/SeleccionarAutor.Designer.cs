namespace CookBooks.Deposito1
{
    partial class SeleccionarAutor
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Location = new System.Drawing.Point(237, 178);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(108, 28);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Location = new System.Drawing.Point(93, 178);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(108, 28);
            this.aceptar.TabIndex = 9;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(51, 71);
            this.autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(48, 18);
            this.autor.TabIndex = 8;
            this.autor.Text = "Autor";
            // 
            // SeleccionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(417, 278);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SeleccionarAutor";
            this.Text = "SeleccionarAutor";
            this.Load += new System.EventHandler(this.SeleccionarAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label autor;
    }
}