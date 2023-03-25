namespace Vista
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MostrarOcultarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(91, 48);
            this.ContraseñaTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(195, 22);
            this.ContraseñaTextBox.TabIndex = 23;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(90, 15);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(196, 22);
            this.UsuarioTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario:";
            // 
            // MostrarOcultarButton
            // 
            this.MostrarOcultarButton.Image = global::Vista.Properties.Resources.show;
            this.MostrarOcultarButton.Location = new System.Drawing.Point(289, 48);
            this.MostrarOcultarButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MostrarOcultarButton.Name = "MostrarOcultarButton";
            this.MostrarOcultarButton.Size = new System.Drawing.Size(25, 22);
            this.MostrarOcultarButton.TabIndex = 21;
            this.MostrarOcultarButton.UseVisualStyleBackColor = true;
            this.MostrarOcultarButton.Click += new System.EventHandler(this.MostrarOcultarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources._207_2073249_open_user_icon_for_login_page;
            this.pictureBox1.Location = new System.Drawing.Point(328, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Vista.Properties.Resources.boton_eliminar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(200, 79);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(105, 42);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Image = global::Vista.Properties.Resources.cheque;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(90, 79);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(103, 42);
            this.AceptarButton.TabIndex = 16;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(456, 136);
            this.ControlBox = false;
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.MostrarOcultarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Button MostrarOcultarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}