namespace ControlDeVentasDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuarios = new Button();
            btnRubros = new Button();
            btnProveedores = new Button();
            btnProductos = new Button();
            btnPedidos = new Button();
            gbRubros = new GroupBox();
            BtnEliminarRubro = new Button();
            BtnActualizarRubro = new Button();
            txtNombreRubros = new TextBox();
            nombreRubros = new Label();
            dataGridView1 = new DataGridView();
            mensaje = new Label();
            btnSalir = new Button();
            gbUsuarios = new GroupBox();
            txtTelefonoUsuarios = new TextBox();
            txtEmailUsuarios = new TextBox();
            txtDireccionUsuarios = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BtnEliminarUsuario = new Button();
            BtnActualizarUsuario = new Button();
            txtNombreUsuarios = new TextBox();
            label3 = new Label();
            gbProveedores = new GroupBox();
            BtnEliminarProveedores = new Button();
            BtnActualizarProveedores = new Button();
            txtNombreProveedores = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            gbProductos = new GroupBox();
            txtPrecioProductos = new TextBox();
            txtCostoProductos = new TextBox();
            txtNombreProductos = new TextBox();
            lblPrecioPr = new Label();
            lblCostoPr = new Label();
            lblProveedor = new Label();
            lblRubroPr = new Label();
            lblNombrePr = new Label();
            cbxProveedorProductos = new ComboBox();
            cbxRubroProductos = new ComboBox();
            btnElimiarProductos = new Button();
            btnActualizarPr = new Button();
            gbPedidos = new GroupBox();
            btnAbrirpedidos = new Button();
            label1 = new Label();
            cmbUsuario = new ComboBox();
            lblPrecio = new Label();
            label10 = new Label();
            label8 = new Label();
            label2 = new Label();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            gbItempedido = new GroupBox();
            txtPrecio = new TextBox();
            txtDto = new TextBox();
            label12 = new Label();
            label11 = new Label();
            dgvDetalles = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            gbRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbUsuarios.SuspendLayout();
            gbProveedores.SuspendLayout();
            gbProductos.SuspendLayout();
            gbPedidos.SuspendLayout();
            gbItempedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(48, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(75, 23);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Clientes";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnRubros
            // 
            btnRubros.Location = new Point(129, 12);
            btnRubros.Name = "btnRubros";
            btnRubros.Size = new Size(94, 23);
            btnRubros.TabIndex = 1;
            btnRubros.Text = "Rubros";
            btnRubros.UseVisualStyleBackColor = true;
            btnRubros.Click += btnRubros_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(229, 13);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(101, 23);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(338, 13);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(101, 23);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(445, 12);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(101, 23);
            btnPedidos.TabIndex = 4;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // gbRubros
            // 
            gbRubros.Controls.Add(BtnEliminarRubro);
            gbRubros.Controls.Add(BtnActualizarRubro);
            gbRubros.Controls.Add(txtNombreRubros);
            gbRubros.Controls.Add(nombreRubros);
            gbRubros.Location = new Point(767, 222);
            gbRubros.Name = "gbRubros";
            gbRubros.Size = new Size(100, 62);
            gbRubros.TabIndex = 5;
            gbRubros.TabStop = false;
            gbRubros.Tag = "";
            gbRubros.Text = "Rubros";
            gbRubros.Visible = false;
            // 
            // BtnEliminarRubro
            // 
            BtnEliminarRubro.Location = new Point(622, 50);
            BtnEliminarRubro.Name = "BtnEliminarRubro";
            BtnEliminarRubro.Size = new Size(75, 23);
            BtnEliminarRubro.TabIndex = 3;
            BtnEliminarRubro.Text = "Eliminar";
            BtnEliminarRubro.UseVisualStyleBackColor = true;
            BtnEliminarRubro.Click += BtnEliminarRubro_Click;
            // 
            // BtnActualizarRubro
            // 
            BtnActualizarRubro.Location = new Point(622, 21);
            BtnActualizarRubro.Name = "BtnActualizarRubro";
            BtnActualizarRubro.Size = new Size(75, 23);
            BtnActualizarRubro.TabIndex = 2;
            BtnActualizarRubro.Text = "Actualizar";
            BtnActualizarRubro.UseVisualStyleBackColor = true;
            BtnActualizarRubro.Click += BtnActualizarRubro_Click;
            // 
            // txtNombreRubros
            // 
            txtNombreRubros.Location = new Point(93, 33);
            txtNombreRubros.Name = "txtNombreRubros";
            txtNombreRubros.Size = new Size(451, 23);
            txtNombreRubros.TabIndex = 1;
            // 
            // nombreRubros
            // 
            nombreRubros.AutoSize = true;
            nombreRubros.Location = new Point(27, 36);
            nombreRubros.Name = "nombreRubros";
            nombreRubros.Size = new Size(51, 15);
            nombreRubros.TabIndex = 0;
            nombreRubros.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(320, 346);
            dataGridView1.TabIndex = 6;
            dataGridView1.Visible = false;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Location = new Point(22, 47);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(51, 15);
            mensaje.TabIndex = 7;
            mensaje.Text = "mensaje";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(767, 13);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 30);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // gbUsuarios
            // 
            gbUsuarios.Controls.Add(txtTelefonoUsuarios);
            gbUsuarios.Controls.Add(txtEmailUsuarios);
            gbUsuarios.Controls.Add(txtDireccionUsuarios);
            gbUsuarios.Controls.Add(label6);
            gbUsuarios.Controls.Add(label5);
            gbUsuarios.Controls.Add(label4);
            gbUsuarios.Controls.Add(BtnEliminarUsuario);
            gbUsuarios.Controls.Add(BtnActualizarUsuario);
            gbUsuarios.Controls.Add(txtNombreUsuarios);
            gbUsuarios.Controls.Add(label3);
            gbUsuarios.Location = new Point(766, 143);
            gbUsuarios.Name = "gbUsuarios";
            gbUsuarios.Size = new Size(101, 73);
            gbUsuarios.TabIndex = 9;
            gbUsuarios.TabStop = false;
            gbUsuarios.Text = "Usuarios";
            gbUsuarios.Visible = false;
            // 
            // txtTelefonoUsuarios
            // 
            txtTelefonoUsuarios.Location = new Point(93, 134);
            txtTelefonoUsuarios.Name = "txtTelefonoUsuarios";
            txtTelefonoUsuarios.Size = new Size(451, 23);
            txtTelefonoUsuarios.TabIndex = 9;
            // 
            // txtEmailUsuarios
            // 
            txtEmailUsuarios.Location = new Point(93, 101);
            txtEmailUsuarios.Name = "txtEmailUsuarios";
            txtEmailUsuarios.Size = new Size(451, 23);
            txtEmailUsuarios.TabIndex = 8;
            // 
            // txtDireccionUsuarios
            // 
            txtDireccionUsuarios.Location = new Point(93, 69);
            txtDireccionUsuarios.Name = "txtDireccionUsuarios";
            txtDireccionUsuarios.Size = new Size(451, 23);
            txtDireccionUsuarios.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 137);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 6;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 104);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 72);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Direccion";
            // 
            // BtnEliminarUsuario
            // 
            BtnEliminarUsuario.Location = new Point(622, 68);
            BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            BtnEliminarUsuario.Size = new Size(75, 23);
            BtnEliminarUsuario.TabIndex = 3;
            BtnEliminarUsuario.Text = "Eliminar";
            BtnEliminarUsuario.UseVisualStyleBackColor = true;
            BtnEliminarUsuario.Click += BtnEliminarUsuario_Click;
            // 
            // BtnActualizarUsuario
            // 
            BtnActualizarUsuario.Location = new Point(622, 33);
            BtnActualizarUsuario.Name = "BtnActualizarUsuario";
            BtnActualizarUsuario.Size = new Size(75, 23);
            BtnActualizarUsuario.TabIndex = 2;
            BtnActualizarUsuario.Text = "Actualizar";
            BtnActualizarUsuario.UseVisualStyleBackColor = true;
            BtnActualizarUsuario.Click += BtnActualizarUsuario_Click;
            // 
            // txtNombreUsuarios
            // 
            txtNombreUsuarios.Location = new Point(93, 33);
            txtNombreUsuarios.Name = "txtNombreUsuarios";
            txtNombreUsuarios.Size = new Size(451, 23);
            txtNombreUsuarios.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 36);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // gbProveedores
            // 
            gbProveedores.Controls.Add(BtnEliminarProveedores);
            gbProveedores.Controls.Add(BtnActualizarProveedores);
            gbProveedores.Controls.Add(txtNombreProveedores);
            gbProveedores.Controls.Add(label7);
            gbProveedores.Location = new Point(766, 65);
            gbProveedores.Name = "gbProveedores";
            gbProveedores.Size = new Size(101, 76);
            gbProveedores.TabIndex = 10;
            gbProveedores.TabStop = false;
            gbProveedores.Text = "Proveedores";
            gbProveedores.Visible = false;
            // 
            // BtnEliminarProveedores
            // 
            BtnEliminarProveedores.Location = new Point(622, 50);
            BtnEliminarProveedores.Name = "BtnEliminarProveedores";
            BtnEliminarProveedores.Size = new Size(75, 23);
            BtnEliminarProveedores.TabIndex = 3;
            BtnEliminarProveedores.Text = "Eliminar";
            BtnEliminarProveedores.UseVisualStyleBackColor = true;
            BtnEliminarProveedores.Click += BtnEliminarProveedores_Click;
            // 
            // BtnActualizarProveedores
            // 
            BtnActualizarProveedores.Location = new Point(622, 21);
            BtnActualizarProveedores.Name = "BtnActualizarProveedores";
            BtnActualizarProveedores.Size = new Size(75, 23);
            BtnActualizarProveedores.TabIndex = 2;
            BtnActualizarProveedores.Text = "Actualizar";
            BtnActualizarProveedores.UseVisualStyleBackColor = true;
            BtnActualizarProveedores.Click += BtnActualizarProveedores_Click;
            // 
            // txtNombreProveedores
            // 
            txtNombreProveedores.Location = new Point(93, 33);
            txtNombreProveedores.Name = "txtNombreProveedores";
            txtNombreProveedores.Size = new Size(451, 23);
            txtNombreProveedores.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 36);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 0;
            label7.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(552, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 11;
            txtId.Visible = false;
            // 
            // gbProductos
            // 
            gbProductos.Controls.Add(txtPrecioProductos);
            gbProductos.Controls.Add(txtCostoProductos);
            gbProductos.Controls.Add(txtNombreProductos);
            gbProductos.Controls.Add(lblPrecioPr);
            gbProductos.Controls.Add(lblCostoPr);
            gbProductos.Controls.Add(lblProveedor);
            gbProductos.Controls.Add(lblRubroPr);
            gbProductos.Controls.Add(lblNombrePr);
            gbProductos.Controls.Add(cbxProveedorProductos);
            gbProductos.Controls.Add(cbxRubroProductos);
            gbProductos.Controls.Add(btnElimiarProductos);
            gbProductos.Controls.Add(btnActualizarPr);
            gbProductos.Location = new Point(767, 290);
            gbProductos.Name = "gbProductos";
            gbProductos.Size = new Size(100, 62);
            gbProductos.TabIndex = 12;
            gbProductos.TabStop = false;
            gbProductos.Text = "Productos";
            gbProductos.Visible = false;
            // 
            // txtPrecioProductos
            // 
            txtPrecioProductos.Location = new Point(93, 180);
            txtPrecioProductos.Name = "txtPrecioProductos";
            txtPrecioProductos.Size = new Size(133, 23);
            txtPrecioProductos.TabIndex = 11;
            // 
            // txtCostoProductos
            // 
            txtCostoProductos.Location = new Point(93, 145);
            txtCostoProductos.Name = "txtCostoProductos";
            txtCostoProductos.Size = new Size(133, 23);
            txtCostoProductos.TabIndex = 10;
            // 
            // txtNombreProductos
            // 
            txtNombreProductos.Location = new Point(93, 40);
            txtNombreProductos.Name = "txtNombreProductos";
            txtNombreProductos.Size = new Size(431, 23);
            txtNombreProductos.TabIndex = 9;
            // 
            // lblPrecioPr
            // 
            lblPrecioPr.AutoSize = true;
            lblPrecioPr.Location = new Point(21, 183);
            lblPrecioPr.Name = "lblPrecioPr";
            lblPrecioPr.Size = new Size(40, 15);
            lblPrecioPr.TabIndex = 8;
            lblPrecioPr.Text = "Precio";
            // 
            // lblCostoPr
            // 
            lblCostoPr.AutoSize = true;
            lblCostoPr.Location = new Point(21, 148);
            lblCostoPr.Name = "lblCostoPr";
            lblCostoPr.Size = new Size(57, 15);
            lblCostoPr.TabIndex = 7;
            lblCostoPr.Text = "C O S T O";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(21, 113);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 6;
            lblProveedor.Text = "Proveedor";
            // 
            // lblRubroPr
            // 
            lblRubroPr.AutoSize = true;
            lblRubroPr.Location = new Point(21, 78);
            lblRubroPr.Name = "lblRubroPr";
            lblRubroPr.Size = new Size(39, 15);
            lblRubroPr.TabIndex = 5;
            lblRubroPr.Text = "Rubro";
            // 
            // lblNombrePr
            // 
            lblNombrePr.AutoSize = true;
            lblNombrePr.Location = new Point(17, 43);
            lblNombrePr.Name = "lblNombrePr";
            lblNombrePr.Size = new Size(51, 15);
            lblNombrePr.TabIndex = 4;
            lblNombrePr.Text = "Nombre";
            // 
            // cbxProveedorProductos
            // 
            cbxProveedorProductos.FormattingEnabled = true;
            cbxProveedorProductos.Location = new Point(93, 110);
            cbxProveedorProductos.Name = "cbxProveedorProductos";
            cbxProveedorProductos.Size = new Size(431, 23);
            cbxProveedorProductos.TabIndex = 3;
            // 
            // cbxRubroProductos
            // 
            cbxRubroProductos.FormattingEnabled = true;
            cbxRubroProductos.Location = new Point(93, 75);
            cbxRubroProductos.Name = "cbxRubroProductos";
            cbxRubroProductos.Size = new Size(431, 23);
            cbxRubroProductos.TabIndex = 2;
            // 
            // btnElimiarProductos
            // 
            btnElimiarProductos.Location = new Point(587, 102);
            btnElimiarProductos.Name = "btnElimiarProductos";
            btnElimiarProductos.Size = new Size(109, 34);
            btnElimiarProductos.TabIndex = 1;
            btnElimiarProductos.Text = "Elimiar";
            btnElimiarProductos.UseVisualStyleBackColor = true;
            btnElimiarProductos.Click += btnElimiarPr_Click;
            // 
            // btnActualizarPr
            // 
            btnActualizarPr.Location = new Point(587, 42);
            btnActualizarPr.Name = "btnActualizarPr";
            btnActualizarPr.Size = new Size(109, 34);
            btnActualizarPr.TabIndex = 0;
            btnActualizarPr.Text = "Actualizar";
            btnActualizarPr.UseVisualStyleBackColor = true;
            btnActualizarPr.Click += btnActualizarPr_Click;
            // 
            // gbPedidos
            // 
            gbPedidos.Controls.Add(btnAbrirpedidos);
            gbPedidos.Controls.Add(label1);
            gbPedidos.Controls.Add(cmbUsuario);
            gbPedidos.Location = new Point(22, 65);
            gbPedidos.Name = "gbPedidos";
            gbPedidos.Size = new Size(320, 151);
            gbPedidos.TabIndex = 13;
            gbPedidos.TabStop = false;
            gbPedidos.Text = "pedidos";
            gbPedidos.Visible = false;
            // 
            // btnAbrirpedidos
            // 
            btnAbrirpedidos.Location = new Point(171, 74);
            btnAbrirpedidos.Name = "btnAbrirpedidos";
            btnAbrirpedidos.Size = new Size(121, 23);
            btnAbrirpedidos.TabIndex = 12;
            btnAbrirpedidos.Text = "ABRIR PEDIDO";
            btnAbrirpedidos.UseVisualStyleBackColor = true;
            btnAbrirpedidos.Click += btnAbrirpedidos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Clientes:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(85, 33);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(207, 23);
            cmbUsuario.TabIndex = 3;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(347, 95);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(12, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(306, 95);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 10;
            label10.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 49);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 8;
            label8.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(189, 46);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(169, 23);
            cmbProducto.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(74, 46);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(44, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 133);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 28);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbItempedido
            // 
            gbItempedido.Controls.Add(txtPrecio);
            gbItempedido.Controls.Add(lblPrecio);
            gbItempedido.Controls.Add(txtDto);
            gbItempedido.Controls.Add(label10);
            gbItempedido.Controls.Add(label12);
            gbItempedido.Controls.Add(label11);
            gbItempedido.Controls.Add(cmbProducto);
            gbItempedido.Controls.Add(txtCantidad);
            gbItempedido.Controls.Add(label2);
            gbItempedido.Controls.Add(label8);
            gbItempedido.Controls.Add(btnAgregar);
            gbItempedido.Location = new Point(348, 74);
            gbItempedido.Name = "gbItempedido";
            gbItempedido.Size = new Size(389, 175);
            gbItempedido.TabIndex = 14;
            gbItempedido.TabStop = false;
            gbItempedido.Text = "Item Pedido";
            gbItempedido.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(188, 87);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 16;
            // 
            // txtDto
            // 
            txtDto.Location = new Point(53, 82);
            txtDto.Name = "txtDto";
            txtDto.Size = new Size(65, 23);
            txtDto.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(137, 87);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 14;
            label12.Text = "Precio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 82);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 13;
            label11.Text = "DTO:";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cantidad, Total });
            dgvDetalles.Location = new Point(348, 258);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.Size = new Size(389, 343);
            dgvDetalles.TabIndex = 15;
            dgvDetalles.Visible = false;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 613);
            Controls.Add(dgvDetalles);
            Controls.Add(gbItempedido);
            Controls.Add(gbPedidos);
            Controls.Add(gbProductos);
            Controls.Add(txtId);
            Controls.Add(gbProveedores);
            Controls.Add(gbUsuarios);
            Controls.Add(btnSalir);
            Controls.Add(mensaje);
            Controls.Add(dataGridView1);
            Controls.Add(gbRubros);
            Controls.Add(btnPedidos);
            Controls.Add(btnProductos);
            Controls.Add(btnProveedores);
            Controls.Add(btnRubros);
            Controls.Add(btnUsuarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbRubros.ResumeLayout(false);
            gbRubros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbUsuarios.ResumeLayout(false);
            gbUsuarios.PerformLayout();
            gbProveedores.ResumeLayout(false);
            gbProveedores.PerformLayout();
            gbProductos.ResumeLayout(false);
            gbProductos.PerformLayout();
            gbPedidos.ResumeLayout(false);
            gbPedidos.PerformLayout();
            gbItempedido.ResumeLayout(false);
            gbItempedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsuarios;
        private Button btnRubros;
        private Button btnProveedores;
        private Button btnProductos;
        private Button btnPedidos;
        private GroupBox gbRubros;
        private Button BtnEliminarRubro;
        private Button BtnActualizarRubro;
        private TextBox txtNombreRubros;
        private Label nombreRubros;
        private DataGridView dataGridView1;
        private Label mensaje;
        private Button btnSalir;
        private GroupBox gbUsuarios;
        private Button BtnEliminarUsuario;
        private Button BtnActualizarUsuario;
        private TextBox txtNombreUsuarios;
        private Label label3;
        private TextBox txtTelefonoUsuarios;
        private TextBox txtEmailUsuarios;
        private TextBox txtDireccionUsuarios;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox gbProveedores;
        private Button BtnEliminarProveedores;
        private Button BtnActualizarProveedores;
        private TextBox txtNombreProveedores;
        private Label label7;
        private TextBox txtId;
        private GroupBox gbProductos;
        private Label lblPrecioPr;
        private Label lblCostoPr;
        private Label lblProveedor;
        private Label lblRubroPr;
        private Label lblNombrePr;
        private ComboBox cbxProveedorProductos;
        private ComboBox cbxRubroProductos;
        private Button btnElimiarProductos;
        private Button btnActualizarPr;
        private TextBox txtPrecioProductos;
        private TextBox txtCostoProductos;
        private TextBox txtNombreProductos;
        private GroupBox gbPedidos;
        private Button btnAgregar;
        private ComboBox cmbProducto;
        private ComboBox cmbUsuario;
        private TextBox txtCantidad;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label lblPrecio;
        private Label label10;
        private GroupBox gbItempedido;
        private Button btnAbrirpedidos;
        private TextBox txtPrecio;
        private TextBox txtDto;
        private Label label12;
        private Label label11;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
    }
}
