namespace Vista
{
    partial class ClienteForm
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
            this.ModificarButton = new System.Windows.Forms.Button();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegresarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(209, 263);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(86, 33);
            this.ModificarButton.TabIndex = 66;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Enabled = false;
            this.TelefonoTextBox.Location = new System.Drawing.Point(238, 88);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(362, 22);
            this.TelefonoTextBox.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Telefono";
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.Enabled = false;
            this.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(238, 198);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.FechaNacimientoDateTimePicker.TabIndex = 63;
            this.FechaNacimientoDateTimePicker.Value = new System.DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Enabled = false;
            this.DireccionTextBox.Location = new System.Drawing.Point(238, 162);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(362, 22);
            this.DireccionTextBox.TabIndex = 61;
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(3, 313);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(727, 185);
            this.ClientesDataGridView.TabIndex = 60;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(485, 263);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(86, 33);
            this.CancelarButton.TabIndex = 59;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(393, 263);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(86, 33);
            this.EliminarButton.TabIndex = 58;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(301, 263);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 33);
            this.GuardarButton.TabIndex = 57;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(117, 263);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(86, 33);
            this.NuevoButton.TabIndex = 56;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dirección:";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Location = new System.Drawing.Point(238, 125);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(362, 22);
            this.CorreoTextBox.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Correo:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(238, 48);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(362, 22);
            this.NombreTextBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre:";
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Enabled = false;
            this.IdentidadTextBox.Location = new System.Drawing.Point(238, 12);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(362, 22);
            this.IdentidadTextBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Identidad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegresarButton
            // 
            this.RegresarButton.Location = new System.Drawing.Point(577, 263);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(85, 33);
            this.RegresarButton.TabIndex = 67;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 501);
            this.ControlBox = false;
            this.Controls.Add(this.RegresarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdentidadTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteForm";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button RegresarButton;
    }
}