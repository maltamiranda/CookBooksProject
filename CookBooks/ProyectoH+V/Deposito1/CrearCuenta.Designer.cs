namespace CookBooks.Deposito1
{
    partial class CrearCuenta
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.pwconfirmarBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pwError = new System.Windows.Forms.Label();
            this.espacioError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(215, 31);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(121, 20);
            this.userBox.TabIndex = 0;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(215, 73);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(121, 20);
            this.pwBox.TabIndex = 1;
            this.pwBox.UseSystemPasswordChar = true;
            // 
            // pwconfirmarBox
            // 
            this.pwconfirmarBox.Location = new System.Drawing.Point(215, 117);
            this.pwconfirmarBox.Name = "pwconfirmarBox";
            this.pwconfirmarBox.Size = new System.Drawing.Size(121, 20);
            this.pwconfirmarBox.TabIndex = 2;
            this.pwconfirmarBox.UseSystemPasswordChar = true;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(215, 158);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(121, 20);
            this.mailBox.TabIndex = 3;
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(215, 202);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.Size = new System.Drawing.Size(121, 20);
            this.direccionBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(81, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(243, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pwError
            // 
            this.pwError.AutoSize = true;
            this.pwError.Location = new System.Drawing.Point(144, 296);
            this.pwError.Name = "pwError";
            this.pwError.Size = new System.Drawing.Size(133, 13);
            this.pwError.TabIndex = 8;
            this.pwError.Text = "La contraseña no coincide";
            this.pwError.Visible = false;
            // 
            // espacioError
            // 
            this.espacioError.AutoSize = true;
            this.espacioError.Location = new System.Drawing.Point(129, 321);
            this.espacioError.Name = "espacioError";
            this.espacioError.Size = new System.Drawing.Size(167, 13);
            this.espacioError.TabIndex = 9;
            this.espacioError.Text = "Debe completar todos los campos";
            this.espacioError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre de la cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nivel de la cuenta";
            // 
            // userError
            // 
            this.userError.AutoSize = true;
            this.userError.Location = new System.Drawing.Point(135, 346);
            this.userError.Name = "userError";
            this.userError.Size = new System.Drawing.Size(153, 13);
            this.userError.TabIndex = 16;
            this.userError.Text = "Ingrese otro nombre de usuario";
            this.userError.Visible = false;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 411);
            this.Controls.Add(this.userError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.espacioError);
            this.Controls.Add(this.pwError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.direccionBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.pwconfirmarBox);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.userBox);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.TextBox pwconfirmarBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox direccionBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label pwError;
        private System.Windows.Forms.Label espacioError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label userError;
    }
}