namespace Vista
{
    partial class TicketsForm
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
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.SolicitudGroupBox = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DescripcionSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripcionRespuestaTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RegresarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SolicitudGroupBox.SuspendLayout();
            this.ClienteGroupBox.SuspendLayout();
            this.UsuarioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(12, 362);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(1009, 178);
            this.DetalleDataGridView.TabIndex = 43;
            // 
            // SolicitudGroupBox
            // 
            this.SolicitudGroupBox.Controls.Add(this.CantidadTextBox);
            this.SolicitudGroupBox.Controls.Add(this.label13);
            this.SolicitudGroupBox.Controls.Add(this.PrecioTextBox);
            this.SolicitudGroupBox.Controls.Add(this.label3);
            this.SolicitudGroupBox.Controls.Add(this.TipoSoporteComboBox);
            this.SolicitudGroupBox.Controls.Add(this.label4);
            this.SolicitudGroupBox.Controls.Add(this.DescripcionSolicitudTextBox);
            this.SolicitudGroupBox.Controls.Add(this.label5);
            this.SolicitudGroupBox.Controls.Add(this.DescripcionRespuestaTextBox);
            this.SolicitudGroupBox.Controls.Add(this.DescuentoTextBox);
            this.SolicitudGroupBox.Controls.Add(this.label6);
            this.SolicitudGroupBox.Controls.Add(this.label9);
            this.SolicitudGroupBox.Location = new System.Drawing.Point(14, 207);
            this.SolicitudGroupBox.Name = "SolicitudGroupBox";
            this.SolicitudGroupBox.Size = new System.Drawing.Size(1007, 149);
            this.SolicitudGroupBox.TabIndex = 39;
            this.SolicitudGroupBox.TabStop = false;
            this.SolicitudGroupBox.Text = "Solicitud";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(110, 107);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadTextBox.TabIndex = 19;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cantidad:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(110, 51);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Costo:";
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Computadora",
            "Celular"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(110, 21);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(162, 24);
            this.TipoSoporteComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Soporte:";
            // 
            // DescripcionSolicitudTextBox
            // 
            this.DescripcionSolicitudTextBox.Location = new System.Drawing.Point(501, 21);
            this.DescripcionSolicitudTextBox.Name = "DescripcionSolicitudTextBox";
            this.DescripcionSolicitudTextBox.Size = new System.Drawing.Size(477, 22);
            this.DescripcionSolicitudTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion (Solicitud):";
            // 
            // DescripcionRespuestaTextBox
            // 
            this.DescripcionRespuestaTextBox.Location = new System.Drawing.Point(501, 61);
            this.DescripcionRespuestaTextBox.Name = "DescripcionRespuestaTextBox";
            this.DescripcionRespuestaTextBox.Size = new System.Drawing.Size(477, 22);
            this.DescripcionRespuestaTextBox.TabIndex = 15;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(110, 79);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescuentoTextBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripcion (Respuesta):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Descuento:";
            // 
            // ClienteGroupBox
            // 
            this.ClienteGroupBox.Controls.Add(this.BuscarButton);
            this.ClienteGroupBox.Controls.Add(this.IdentidadTextBox);
            this.ClienteGroupBox.Controls.Add(this.label12);
            this.ClienteGroupBox.Controls.Add(this.ClienteTextBox);
            this.ClienteGroupBox.Location = new System.Drawing.Point(12, 118);
            this.ClienteGroupBox.Name = "ClienteGroupBox";
            this.ClienteGroupBox.Size = new System.Drawing.Size(1009, 74);
            this.ClienteGroupBox.TabIndex = 38;
            this.ClienteGroupBox.TabStop = false;
            this.ClienteGroupBox.Text = "Cliente";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(278, 32);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(27, 22);
            this.BuscarButton.TabIndex = 26;
            this.BuscarButton.Text = "...";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(81, 32);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(191, 22);
            this.IdentidadTextBox.TabIndex = 25;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Identidad:";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(311, 32);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.ReadOnly = true;
            this.ClienteTextBox.Size = new System.Drawing.Size(667, 22);
            this.ClienteTextBox.TabIndex = 13;
            // 
            // UsuarioGroupBox
            // 
            this.UsuarioGroupBox.Controls.Add(this.UsuarioTextBox);
            this.UsuarioGroupBox.Controls.Add(this.label2);
            this.UsuarioGroupBox.Controls.Add(this.FechaDateTimePicker);
            this.UsuarioGroupBox.Controls.Add(this.label1);
            this.UsuarioGroupBox.Location = new System.Drawing.Point(12, 39);
            this.UsuarioGroupBox.Name = "UsuarioGroupBox";
            this.UsuarioGroupBox.Size = new System.Drawing.Size(987, 61);
            this.UsuarioGroupBox.TabIndex = 37;
            this.UsuarioGroupBox.TabStop = false;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(81, 18);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(246, 22);
            this.UsuarioTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(850, 18);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.FechaDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 27);
            this.label11.TabIndex = 36;
            this.label11.Text = "NUEVO TICKET";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(890, 602);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 35;
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Location = new System.Drawing.Point(890, 574);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.ReadOnly = true;
            this.ImpuestoTextBox.Size = new System.Drawing.Size(100, 22);
            this.ImpuestoTextBox.TabIndex = 33;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(890, 546);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubTotalTextBox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(766, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "ISV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sub Total:";
            // 
            // RegresarButton
            // 
            this.RegresarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarButton.Image = global::Vista.Properties.Resources.flecha_hacia_atras;
            this.RegresarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegresarButton.Location = new System.Drawing.Point(258, 549);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(114, 63);
            this.RegresarButton.TabIndex = 42;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Vista.Properties.Resources.boton_eliminar;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(132, 549);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 63);
            this.CancelarButton.TabIndex = 41;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Image = global::Vista.Properties.Resources.cheque;
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(14, 549);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(103, 63);
            this.AceptarButton.TabIndex = 40;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1022, 630);
            this.ControlBox = false;
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.RegresarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.SolicitudGroupBox);
            this.Controls.Add(this.ClienteGroupBox);
            this.Controls.Add(this.UsuarioGroupBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.ImpuestoTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.SolicitudGroupBox.ResumeLayout(false);
            this.SolicitudGroupBox.PerformLayout();
            this.ClienteGroupBox.ResumeLayout(false);
            this.ClienteGroupBox.PerformLayout();
            this.UsuarioGroupBox.ResumeLayout(false);
            this.UsuarioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button RegresarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.GroupBox SolicitudGroupBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescripcionSolicitudTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripcionRespuestaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox ClienteGroupBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.GroupBox UsuarioGroupBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}