namespace Formulario_TP4
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gbPaquetes = new System.Windows.Forms.GroupBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.gbPaquetes.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.gbEstados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.ForeColor = System.Drawing.Color.Crimson;
            this.lblTrackingID.Location = new System.Drawing.Point(16, 49);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(91, 17);
            this.lblTrackingID.TabIndex = 6;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.Crimson;
            this.lblDireccion.Location = new System.Drawing.Point(16, 136);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(76, 17);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección";
            // 
            // gbPaquetes
            // 
            this.gbPaquetes.BackColor = System.Drawing.Color.Transparent;
            this.gbPaquetes.Controls.Add(this.mtxtTrackingID);
            this.gbPaquetes.Controls.Add(this.btnMostrarTodos);
            this.gbPaquetes.Controls.Add(this.btnAgregar);
            this.gbPaquetes.Controls.Add(this.lblDireccion);
            this.gbPaquetes.Controls.Add(this.lblTrackingID);
            this.gbPaquetes.Controls.Add(this.txtDireccion);
            this.gbPaquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaquetes.ForeColor = System.Drawing.Color.BlueViolet;
            this.gbPaquetes.Location = new System.Drawing.Point(726, 408);
            this.gbPaquetes.Name = "gbPaquetes";
            this.gbPaquetes.Size = new System.Drawing.Size(482, 241);
            this.gbPaquetes.TabIndex = 9;
            this.gbPaquetes.TabStop = false;
            this.gbPaquetes.Text = "Paquetes";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(6, 69);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(249, 22);
            this.mtxtTrackingID.TabIndex = 13;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMostrarTodos.Location = new System.Drawing.Point(285, 142);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(191, 51);
            this.btnMostrarTodos.TabIndex = 11;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(285, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(191, 51);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 156);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.BackColor = System.Drawing.SystemColors.Control;
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 16;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(843, 59);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(347, 308);
            this.lstEstadoEntregado.TabIndex = 0;
            // 
            // cmsListas
            // 
            this.cmsListas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(211, 56);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.mostrarToolStripMenuItem.Text = "Mostrar elemento";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.BackColor = System.Drawing.SystemColors.Control;
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 16;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(25, 59);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(347, 308);
            this.lstEstadoIngresado.TabIndex = 2;
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.ForeColor = System.Drawing.Color.Crimson;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(38, 39);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(80, 17);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.ForeColor = System.Drawing.Color.Crimson;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(456, 39);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(68, 17);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.ForeColor = System.Drawing.Color.Crimson;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(863, 39);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(83, 17);
            this.lblEstadoEntregado.TabIndex = 5;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // gbEstados
            // 
            this.gbEstados.BackColor = System.Drawing.Color.Transparent;
            this.gbEstados.Controls.Add(this.lstEstadoEnViaje);
            this.gbEstados.Controls.Add(this.lblEstadoEntregado);
            this.gbEstados.Controls.Add(this.lblEstadoIngresado);
            this.gbEstados.Controls.Add(this.lblEstadoEnViaje);
            this.gbEstados.Controls.Add(this.lstEstadoEntregado);
            this.gbEstados.Controls.Add(this.lstEstadoIngresado);
            this.gbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstados.ForeColor = System.Drawing.Color.BlueViolet;
            this.gbEstados.Location = new System.Drawing.Point(12, 12);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(1196, 377);
            this.gbEstados.TabIndex = 8;
            this.gbEstados.TabStop = false;
            this.gbEstados.Text = "Estados Paquetes";
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.BackColor = System.Drawing.SystemColors.Control;
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 16;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(436, 59);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(347, 308);
            this.lstEstadoEnViaje.TabIndex = 6;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMostrar.Location = new System.Drawing.Point(13, 408);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(684, 241);
            this.rtbMostrar.TabIndex = 10;
            this.rtbMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulario_TP4.Properties.Resources.muchas_letras_y_sobres_con_el_correo_de_los_sellos_garabatean_el_fondo_inconsútil_del_modelo_72702462;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 668);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.gbEstados);
            this.Controls.Add(this.gbPaquetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Tomas.Giron.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.gbPaquetes.ResumeLayout(false);
            this.gbPaquetes.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox gbPaquetes;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
    }
}

