namespace PlayerUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.btnCargaInicialObras = new System.Windows.Forms.Button();
            this.btnComprasPClientes = new System.Windows.Forms.Button();
            this.btnRecortes = new System.Windows.Forms.Button();
            this.btnEnviosDProveedor = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnSalidaEventual = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.Obras = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.Fletes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMaximizar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnSalir);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMovimientos);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnGestion);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 560);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.button10);
            this.panelToolsSubMenu.Controls.Add(this.button12);
            this.panelToolsSubMenu.Controls.Add(this.button13);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 841);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(233, 130);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Silver;
            this.button10.Location = new System.Drawing.Point(0, 80);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(233, 40);
            this.button10.TabIndex = 2;
            this.button10.Text = "Informe de obras";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Silver;
            this.button12.Location = new System.Drawing.Point(0, 40);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(233, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "Kardex";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Silver;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(233, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "Stock";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.btnCargaInicialObras);
            this.panelPlaylistSubMenu.Controls.Add(this.btnComprasPClientes);
            this.panelPlaylistSubMenu.Controls.Add(this.btnRecortes);
            this.panelPlaylistSubMenu.Controls.Add(this.btnEnviosDProveedor);
            this.panelPlaylistSubMenu.Controls.Add(this.btnDevolucion);
            this.panelPlaylistSubMenu.Controls.Add(this.btnSalidaEventual);
            this.panelPlaylistSubMenu.Controls.Add(this.btnSalida);
            this.panelPlaylistSubMenu.Controls.Add(this.btnEntrada);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 465);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(233, 331);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // btnCargaInicialObras
            // 
            this.btnCargaInicialObras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargaInicialObras.FlatAppearance.BorderSize = 0;
            this.btnCargaInicialObras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnCargaInicialObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnCargaInicialObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaInicialObras.ForeColor = System.Drawing.Color.Silver;
            this.btnCargaInicialObras.Location = new System.Drawing.Point(0, 280);
            this.btnCargaInicialObras.Name = "btnCargaInicialObras";
            this.btnCargaInicialObras.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCargaInicialObras.Size = new System.Drawing.Size(233, 40);
            this.btnCargaInicialObras.TabIndex = 7;
            this.btnCargaInicialObras.Text = "Carga inicial obras";
            this.btnCargaInicialObras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaInicialObras.UseVisualStyleBackColor = true;
            // 
            // btnComprasPClientes
            // 
            this.btnComprasPClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprasPClientes.FlatAppearance.BorderSize = 0;
            this.btnComprasPClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnComprasPClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnComprasPClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasPClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnComprasPClientes.Location = new System.Drawing.Point(0, 240);
            this.btnComprasPClientes.Name = "btnComprasPClientes";
            this.btnComprasPClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnComprasPClientes.Size = new System.Drawing.Size(233, 40);
            this.btnComprasPClientes.TabIndex = 6;
            this.btnComprasPClientes.Text = "Compras para clientes";
            this.btnComprasPClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasPClientes.UseVisualStyleBackColor = true;
            // 
            // btnRecortes
            // 
            this.btnRecortes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecortes.FlatAppearance.BorderSize = 0;
            this.btnRecortes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnRecortes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnRecortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecortes.ForeColor = System.Drawing.Color.Silver;
            this.btnRecortes.Location = new System.Drawing.Point(0, 200);
            this.btnRecortes.Name = "btnRecortes";
            this.btnRecortes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecortes.Size = new System.Drawing.Size(233, 40);
            this.btnRecortes.TabIndex = 5;
            this.btnRecortes.Text = "Recortes";
            this.btnRecortes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecortes.UseVisualStyleBackColor = true;
            // 
            // btnEnviosDProveedor
            // 
            this.btnEnviosDProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnviosDProveedor.FlatAppearance.BorderSize = 0;
            this.btnEnviosDProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnEnviosDProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnEnviosDProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviosDProveedor.ForeColor = System.Drawing.Color.Silver;
            this.btnEnviosDProveedor.Location = new System.Drawing.Point(0, 160);
            this.btnEnviosDProveedor.Name = "btnEnviosDProveedor";
            this.btnEnviosDProveedor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEnviosDProveedor.Size = new System.Drawing.Size(233, 40);
            this.btnEnviosDProveedor.TabIndex = 4;
            this.btnEnviosDProveedor.Text = "Envíos desde proveedor";
            this.btnEnviosDProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviosDProveedor.UseVisualStyleBackColor = true;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.ForeColor = System.Drawing.Color.Silver;
            this.btnDevolucion.Location = new System.Drawing.Point(0, 120);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDevolucion.Size = new System.Drawing.Size(233, 40);
            this.btnDevolucion.TabIndex = 3;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalidaEventual
            // 
            this.btnSalidaEventual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalidaEventual.FlatAppearance.BorderSize = 0;
            this.btnSalidaEventual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnSalidaEventual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnSalidaEventual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaEventual.ForeColor = System.Drawing.Color.Silver;
            this.btnSalidaEventual.Location = new System.Drawing.Point(0, 80);
            this.btnSalidaEventual.Name = "btnSalidaEventual";
            this.btnSalidaEventual.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSalidaEventual.Size = new System.Drawing.Size(233, 40);
            this.btnSalidaEventual.TabIndex = 2;
            this.btnSalidaEventual.Text = "Salida eventual";
            this.btnSalidaEventual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaEventual.UseVisualStyleBackColor = true;
            this.btnSalidaEventual.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.ForeColor = System.Drawing.Color.Silver;
            this.btnSalida.Location = new System.Drawing.Point(0, 40);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSalida.Size = new System.Drawing.Size(233, 40);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.Silver;
            this.btnEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(233, 40);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.Obras);
            this.panelMediaSubMenu.Controls.Add(this.btnDestinos);
            this.panelMediaSubMenu.Controls.Add(this.Fletes);
            this.panelMediaSubMenu.Controls.Add(this.btnProveedores);
            this.panelMediaSubMenu.Controls.Add(this.btnClientes);
            this.panelMediaSubMenu.Controls.Add(this.btnCategorias);
            this.panelMediaSubMenu.Controls.Add(this.btnMateriales);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 131);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(233, 289);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // Obras
            // 
            this.Obras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Obras.FlatAppearance.BorderSize = 0;
            this.Obras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.Obras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.Obras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obras.ForeColor = System.Drawing.Color.Silver;
            this.Obras.Location = new System.Drawing.Point(0, 240);
            this.Obras.Name = "Obras";
            this.Obras.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Obras.Size = new System.Drawing.Size(233, 40);
            this.Obras.TabIndex = 6;
            this.Obras.Text = "Obras";
            this.Obras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Obras.UseVisualStyleBackColor = true;
            // 
            // btnDestinos
            // 
            this.btnDestinos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDestinos.FlatAppearance.BorderSize = 0;
            this.btnDestinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnDestinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinos.ForeColor = System.Drawing.Color.Silver;
            this.btnDestinos.Location = new System.Drawing.Point(0, 200);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDestinos.Size = new System.Drawing.Size(233, 40);
            this.btnDestinos.TabIndex = 5;
            this.btnDestinos.Text = "Destinos";
            this.btnDestinos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestinos.UseVisualStyleBackColor = true;
            // 
            // Fletes
            // 
            this.Fletes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Fletes.FlatAppearance.BorderSize = 0;
            this.Fletes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.Fletes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.Fletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fletes.ForeColor = System.Drawing.Color.Silver;
            this.Fletes.Location = new System.Drawing.Point(0, 160);
            this.Fletes.Name = "Fletes";
            this.Fletes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Fletes.Size = new System.Drawing.Size(233, 40);
            this.Fletes.TabIndex = 4;
            this.Fletes.Text = "Fletes";
            this.Fletes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fletes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.Silver;
            this.btnProveedores.Location = new System.Drawing.Point(0, 120);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(233, 40);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnClientes.Location = new System.Drawing.Point(0, 80);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.Color.Silver;
            this.btnCategorias.Location = new System.Drawing.Point(0, 40);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(233, 40);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMateriales.FlatAppearance.BorderSize = 0;
            this.btnMateriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(28)))));
            this.btnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriales.ForeColor = System.Drawing.Color.Silver;
            this.btnMateriales.Location = new System.Drawing.Point(0, 0);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMateriales.Size = new System.Drawing.Size(233, 40);
            this.btnMateriales.TabIndex = 0;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMateriales.UseVisualStyleBackColor = true;
            this.btnMateriales.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 86);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 40);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 560);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panelMaximizar
            // 
            this.panelMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMaximizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaximizar.Location = new System.Drawing.Point(0, 0);
            this.panelMaximizar.Name = "panelMaximizar";
            this.panelMaximizar.Size = new System.Drawing.Size(950, 40);
            this.panelMaximizar.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelMaximizar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelMaximizar;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(195, 120);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(299, 329);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Silver;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 1016);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(233, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 971);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Inventario";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Silver;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 796);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(233, 45);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.ForeColor = System.Drawing.Color.Silver;
            this.btnMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Image")));
            this.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.Location = new System.Drawing.Point(0, 420);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMovimientos.Size = new System.Drawing.Size(233, 45);
            this.btnMovimientos.TabIndex = 3;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimientos.UseVisualStyleBackColor = true;
            this.btnMovimientos.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.ForeColor = System.Drawing.Color.Silver;
            this.btnGestion.Image = ((System.Drawing.Image)(resources.GetObject("btnGestion.Image")));
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.Location = new System.Drawing.Point(0, 86);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestion.Size = new System.Drawing.Size(233, 45);
            this.btnGestion.TabIndex = 1;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelMaximizar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnSalidaEventual;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Obras;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button Fletes;
        private System.Windows.Forms.Button btnCargaInicialObras;
        private System.Windows.Forms.Button btnComprasPClientes;
        private System.Windows.Forms.Button btnRecortes;
        private System.Windows.Forms.Button btnEnviosDProveedor;
        private System.Windows.Forms.Button btnSalir;
        private Guna.UI2.WinForms.Guna2Panel panelMaximizar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

