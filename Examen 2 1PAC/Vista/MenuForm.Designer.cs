namespace Vista
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnNuevoTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem,
            this.opcionesDelProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnNuevoTicketToolStripMenuItem,
            this.agregarClientesToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ticketsToolStripMenuItem.Text = "TICKETS";
            // 
            // agregarUnNuevoTicketToolStripMenuItem
            // 
            this.agregarUnNuevoTicketToolStripMenuItem.Name = "agregarUnNuevoTicketToolStripMenuItem";
            this.agregarUnNuevoTicketToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarUnNuevoTicketToolStripMenuItem.Text = "Agregar un nuevo ticket";
            this.agregarUnNuevoTicketToolStripMenuItem.Click += new System.EventHandler(this.agregarUnNuevoTicketToolStripMenuItem_Click);
            // 
            // opcionesDelProgramaToolStripMenuItem
            // 
            this.opcionesDelProgramaToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.opcionesDelProgramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reToolStripMenuItem,
            this.cerrarProgramaToolStripMenuItem});
            this.opcionesDelProgramaToolStripMenuItem.Name = "opcionesDelProgramaToolStripMenuItem";
            this.opcionesDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.opcionesDelProgramaToolStripMenuItem.Text = "OPCIONES DEL PROGRAMA";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.reToolStripMenuItem.Text = "Regresar e iniciar sesión con otro usuario";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPARACIONES PC BULDING SIMULATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.LOGOINDIEDB_1;
            this.pictureBox1.Location = new System.Drawing.Point(186, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Los mejores desde 1992";
            // 
            // agregarClientesToolStripMenuItem
            // 
            this.agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            this.agregarClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarClientesToolStripMenuItem.Text = "Agregar clientes";
            this.agregarClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarClientesToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 488);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnNuevoTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem agregarClientesToolStripMenuItem;
    }
}