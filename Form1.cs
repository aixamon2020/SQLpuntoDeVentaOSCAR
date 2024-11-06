
using MySql.Data.MySqlClient;  
using Mysqlx.Crud;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static ControlDeVentasDB.Form1;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

//Agregar referencia D:\C#Docs\ControlDeVentasDB

namespace ControlDeVentasDB
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Rubro> rubros = new List<Rubro>();
        private List<Proveedor> proveedores = new List<Proveedor>();
        private List<Producto> productos = new List<Producto>();
        private List<Pedidos> pedidos = new List<Pedidos>();

        int indiceFila = -1;
        private ConexionDB conexionDB;
        public string moduloActual = "";
        public Form1()
        {
            conexionDB = new ConexionDB("localhost", "root", "", "crud");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void CargarDatos(string sql) //leer DB
        {
            try
            {
                txtId.Text = "";
                dataGridView1.Enabled = true;

                if (moduloActual == "usuarios") { usuarios.Clear(); }
                if (moduloActual == "rubros") { rubros.Clear(); }
                if (moduloActual == "proveedores") { proveedores.Clear(); }
                if (moduloActual == "productos") { productos.Clear(); }
                if (moduloActual == "pedidos") { pedidos.Clear(); }

                if (conexionDB != null)
                {
                    using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                    {
                        conexion.Open();
                        MySqlCommand comando = new MySqlCommand(sql, conexion);
                        MySqlDataReader leerDatos = comando.ExecuteReader();

                        while (leerDatos.Read())
                        {
                            if (moduloActual == "usuarios")
                            {
                                usuarios.Add(new Usuario { Id = leerDatos.GetInt32("Id_usuario"), Nombre = leerDatos.GetString("Nombre"), Direccion = leerDatos.GetString("Dirección"), Email = leerDatos.GetString("Email"), Telefono = leerDatos.GetString("Telefono") });
                            }
                            if (moduloActual == "rubros")
                            {
                                rubros.Add(new Rubro { Id = leerDatos.GetInt32("id_rubros"), Nombre = leerDatos.GetString("nombre") });
                            }
                            if (moduloActual == "proveedores")
                            {
                                proveedores.Add(new Proveedor { Id = leerDatos.GetInt32("id_proveedores"), Nombre = leerDatos.GetString("nombre") });
                            }
                            if (moduloActual == "productos")
                            {
                                productos.Add(new Producto { Id = leerDatos.GetInt32("id_productos"), Nombre = leerDatos.GetString("nombre"), Rubro = leerDatos.GetInt32("id_rubro"), Proveedor = leerDatos.GetInt32("id_proveedor"), Precio = leerDatos.GetInt32("precio"), Costo = leerDatos.GetInt32("costo"), NombreRubro = leerDatos.GetString("rubro"), NombreProveedor = leerDatos.GetString("proveedor") });
                            }
                            if (moduloActual == "pedidos")
                            {
                                pedidos.Add(new Pedidos { id_pedido = leerDatos.GetInt32("id_pedidos"), cliente = leerDatos.GetString("nombre"), id_cliente = leerDatos.GetInt32("id_usuario"), total = leerDatos.GetDouble("total"), fecha = leerDatos.GetDateTime("fecha") });
                            }
                        }
                    }
                }
                else { MessageBox.Show("La conexion no esta configurada correctamente"); }

                ActualizarDataGrid();
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar los datos." + ex.Message); }
        }
        //Mostrar datos referentes a Usuarios y ocultar el resto
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ocultar_grupos();
            moduloActual = "usuarios";
            gbUsuarios.Visible = true;
            gbUsuarios.Location = new Point(12, 75);
            gbUsuarios.Size = new Size(738, 223);
            CargarDatos("SELECT * FROM " + moduloActual);
        }
        //Mostrar datos referentes a rubros 
        private void btnRubros_Click(object sender, EventArgs e)
        {
            ocultar_grupos();
            moduloActual = "rubros";
            gbRubros.Visible = true;
            gbRubros.Location = new Point(12, 75);
            gbRubros.Size = new Size(738, 223);
            CargarDatos("SELECT * FROM " + moduloActual);
        }
        //Mostrar datos referentes a proveedores y ocultar el resto
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ocultar_grupos();
            moduloActual = "proveedores";
            gbProveedores.Visible = true;
            gbProveedores.Location = new Point(12, 75);
            gbProveedores.Size = new Size(738, 223);
            CargarDatos("SELECT * FROM " + moduloActual);
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ocultar_grupos();
            moduloActual = "productos";
            gbProductos.Visible = true;
            gbProductos.Location = new Point(12, 75);
            gbProductos.Size = new Size(738, 223);
            CargarDatos("SELECT p.*, r.nombre as rubro, pr.nombre as proveedor FROM  productos p INNER JOIN rubros r ON p.id_rubro = r.id_rubros INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedores");
            llenarComboProveedor();
            llenarComboRubro();
        }
        private void msje(string str)
        {
            mensaje.Text = str;
            mensaje.Visible = true;
            mensaje.Refresh();
            espera(3);
            mensaje.Text = "";
            mensaje.Visible = false;
        }
        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;


            if (moduloActual == "usuarios")
            {
                dataGridView1.DataSource = usuarios;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 185;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 220;
                dataGridView1.Refresh();
                dataGridView1.Size = new Size(837, 301);
                dgvDetalles.Visible = false;
            }
            if (moduloActual == "rubros")
            {
                dataGridView1.DataSource = rubros;
                dataGridView1.Columns[1].Width = 185;
                dataGridView1.Size = new Size(837, 301);
                dgvDetalles.Visible = false;
            }
            if (moduloActual == "proveedores")
            {
                dataGridView1.DataSource = proveedores;
                dataGridView1.Columns[1].Width = 185;
                dataGridView1.Size = new Size(837, 301);
                dgvDetalles.Visible = false;
            }
            if (moduloActual == "productos")
            {
                dataGridView1.DataSource = productos;
                dataGridView1.Columns[1].Width = 185;
                dataGridView1.Columns[6].Width = 220;
                dataGridView1.Columns[7].Width = 220;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Size = new Size(837, 301);
                dgvDetalles.Visible = false;
            }
            if (moduloActual == "pedidos")
            {
                dataGridView1.DataSource = pedidos;
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[3].Width = 75;
                dataGridView1.Columns[4].Width = 75;

                dataGridView1.Size = new Size(318, 291);
                dgvDetalles.Visible = false;
            }



        }
        private void LimpiarDatos()
        {
            txtId.Text = "";
            indiceFila = -1;

            //usuarios
            txtNombreUsuarios.Text = "";
            txtDireccionUsuarios.Text = "";
            txtEmailUsuarios.Text = "";
            txtTelefonoUsuarios.Text = "";

            // Rubros
            txtNombreRubros.Text = "";

            // Proveedores
            txtNombreProveedores.Text = "";

            // Productos
            txtNombreProductos.Text = "";
            txtCostoProductos.Text = "";
            txtPrecioProductos.Text = "";
            cbxProveedorProductos.Text = "Seleccione";
            cbxRubroProductos.Text = "Seleccione";
        }
        private void llenarComboRubro()
        {
            if (conexionDB != null)
            {
                //leer datos de DB
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string sql = "SELECT * FROM rubros";
                    rubros.Clear();
                    rubros.Add(new Rubro { Id = 0, Nombre = "Seleccione" });
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataReader leerDatos = comando.ExecuteReader();
                    while (leerDatos.Read())//lee y recorre cada fila  leia de la DB
                    {
                        rubros.Add(new Rubro { Id = leerDatos.GetInt32("id_rubros"), Nombre = leerDatos.GetString("nombre") });
                    }
                }
            }
            else
            {
                MessageBox.Show("La conexion no esta configurada correctamente. ");
            }
            //establecer el origen de datos del Combobox
            cbxRubroProductos.DataSource = rubros;

            // especificar que propiedada  se mostrara en el ComboBox
            cbxRubroProductos.DisplayMember = "Nombre";

            //especificar que Propiedad se usara  como valor
            cbxRubroProductos.ValueMember = "Id";
        }
        private void llenarComboProveedor()
        {
            if (conexionDB != null)
            {
                //leer datos de DB
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string sql = "SELECT * FROM  proveedores";
                    proveedores.Clear();
                    proveedores.Add(new Proveedor { Id = 0, Nombre = "Seleccione" });
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataReader leerDatos = comando.ExecuteReader();
                    while (leerDatos.Read()) //lee y  recorre cada fila leida de la DB 
                    {
                        proveedores.Add(new Proveedor { Id = leerDatos.GetInt32("id_proveedores"), Nombre = leerDatos.GetString("nombre") });
                    }

                }
            }
            else
            {
                MessageBox.Show("la conexion no esta configurada correctamente. ");
            }
            //establecer el origen de datos del Combobox
            cbxProveedorProductos.DataSource = proveedores;

            // especificar que propiedada  se mostrara en el ComboBox
            cbxProveedorProductos.DisplayMember = "Nombre";

            //especificar que Propiedad se usara  como valor
            cbxProveedorProductos.ValueMember = "Id";
        }
        public void espera(int nn)
        {
            Thread.Sleep(nn * 1000);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si se hace clic en una celda válida del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //asignamos numero de fila seleccionada para luego atualizar
                indiceFila = dataGridView1.CurrentRow.Index;
                //Obtener la fila seleccionada y mostrarla en el textBox
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indiceFila];

                //obteber los valores de las celdas y asignarlos a los textBox
                if (moduloActual == "usuarios")
                {
                    txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                    txtNombreUsuarios.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    txtDireccionUsuarios.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                    txtEmailUsuarios.Text = filaSeleccionada.Cells["Email"].Value.ToString();
                    txtTelefonoUsuarios.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                }
                if (moduloActual == "rubros")
                {
                    txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                    txtNombreUsuarios.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                }
                if (moduloActual == "proveedores")
                {
                    txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                    txtNombreUsuarios.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                }
                if (moduloActual == "productos")
                {
                    txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                    txtNombreProductos.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    txtPrecioProductos.Text = Convert.ToDouble(filaSeleccionada.Cells["Precio"].Value).ToString();
                    txtCostoProductos.Text = Convert.ToDouble(filaSeleccionada.Cells["Costo"].Value).ToString();
                    cbxProveedorProductos.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["Proveedor"].Value);
                    cbxRubroProductos.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["Rubro"].Value);
                }
                dataGridView1.Enabled = false;
            }
        }
        //Metodo para ocultar group box
        private void ocultar_grupos()
        {
            txtId.Text = ""; indiceFila = -1;
            gbRubros.Visible = false;
            gbUsuarios.Visible = false;
            gbProveedores.Visible = false;
            gbProductos.Visible = false;
            gbPedidos.Visible = false;
        }

        public void ejecutarTransaccion(string sql)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Transaction = transaccion;
                    comando.ExecuteNonQuery();
                    transaccion.Commit(); //confirma los cambios
                }
                catch (Exception ex)
                {
                    transaccion.Rollback(); //Si ocurre un error deshace los cambios
                    MessageBox.Show("Error en la transaccion. Los datos no han sido guardados.\nError: " + ex.Message);
                }
            }
        }
        //REGION DE CLASES
        #region Clases

        //Clase Usuario
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }

        }
        //Clase Rubro
        public class Rubro
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        //Clase Proveedor
        public class Proveedor
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Rubro { get; set; }
            public int Proveedor { get; set; }
            public double Precio { get; set; }
            public double Costo { get; set; }
            public string NombreRubro { get; set; }
            public string NombreProveedor { get; set; }
        }
        public class Pedidos
        {
            public int id_pedido { get; set; }
            public int id_cliente { get; set; }
            public double total { get; set; }
            public DateTime? fecha { get; set; }
            public string cliente { get; set; }
        }

        //Conexion a base de datos.
        public class ConexionDB
        {
            private string cadenaConexion;
            public ConexionDB(string servidor, string usuario, string password, string baseDatos)
            {
                //cadenaConexion = $"server={servidor};user={usuario};password={password};database={baseDatos};";
                // cadenaConexion = String.Format("server={0};user={1};password={2};database={3};", servidor, usuario, password, baseDatos);
                cadenaConexion = "server=" + servidor + ";user=" + usuario + ";password=" + password + ";database=" + baseDatos + ";";
            }

            public MySqlConnection ObtenerConexion()
            {
                return new MySqlConnection(cadenaConexion);
            }
        }
        #endregion
        //REGIONES actualizar/borrar
        #region Rubro
        private void BtnActualizarRubro_Click(object sender, EventArgs e)
        {
            if ((indiceFila < 0 && txtNombreRubros.Text == "") || (indiceFila > 0 && txtNombreRubros.Text == "" && txtId.Text == ""))
            {
                msje("No hay datos para actualizar");
                return;
            }

            // Crear un nuevo objeto con los datos de los TextBox
            int idReg = 0;

            if (indiceFila < 0) { idReg = rubros.Count() + 1; }

            if (indiceFila >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indiceFila];
                idReg = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            }

            Rubro nuevoRubro = new Rubro()
            {
                Id = idReg,
                Nombre = txtNombreRubros.Text,
            };

            if (indiceFila < 0)
            {
                // Si no hay fila seleccionada, agregar el nuevo rubro a la lista
                rubros.Add(nuevoRubro);
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    // código para guardar en la base de datos
                    // Insertar datos del nuevo usuario en la DB
                    string consulta = "INSERT INTO rubros (nombre) VALUES ('" + nuevoRubro.Nombre.Replace("'", "''") + "')";
                    ejecutarTransaccion(consulta);
                }
            }
            else
            {
                // Actualizar los datos del usuario en la lista
                rubros[indiceFila] = nuevoRubro;
                // Actualizar los datos del usuario en la DB
                string consulta = "UPDATE rubros SET nombre = '" + nuevoRubro.Nombre.Replace("'", "''") + "' WHERE id=" + nuevoRubro.Id;
                ejecutarTransaccion(consulta);
            }

            LimpiarDatos();

            ActualizarDataGrid();
            msje("Datos Actualizados en: " + moduloActual);
            espera(1);

            // Habilitar nuevamente el DataGridView
            dataGridView1.Enabled = true;

            CargarDatos("SELECT * FROM " + moduloActual);
        }
        private void BtnEliminarRubro_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un item para eliminar");
                return;
            }

            int idfila = Convert.ToInt32(txtId.Text);
            if (idfila > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el item " + idfila + "?", "Confirmación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el valor de la columna que identifica al elemento (supongamos que es la columna 0)
                    int num = idfila;

                    // Buscar y eliminar el elemento en la fuente de datos (ejemplo con una lista)
                    Rubro elemento = rubros.FirstOrDefault(x => x.Id == num);
                    if (elemento != null)
                    {
                        rubros.Remove(elemento);
                        ejecutarTransaccion("DELETE FROM " + moduloActual + " WHERE id=" + elemento.Id);

                        LimpiarDatos();
                        ActualizarDataGrid();
                        msje("¡Elemento eliminado!");
                        espera(1);
                        CargarDatos("SELECT * FROM " + moduloActual);
                        dataGridView1.Enabled = true;

                    }
                }
            }
        }
        #endregion
        #region Usuario

        private void BtnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if ((indiceFila < 0 && txtNombreUsuarios.Text == "") || (indiceFila > 0 && txtNombreUsuarios.Text == "" && txtId.Text == ""))
            {
                msje("No hay datos para actualizar");
                return;
            }

            // Crear un nuevo objeto con los datos de los TextBox
            int idReg = 0;

            if (indiceFila < 0) { idReg = usuarios.Count() + 1; }

            if (indiceFila >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indiceFila];
                idReg = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            }

            Usuario nuevoUsuario = new Usuario()
            {
                Id = idReg,
                Nombre = txtNombreUsuarios.Text,
                Direccion = txtDireccionUsuarios.Text,
                Email = txtEmailUsuarios.Text,
                Telefono = txtTelefonoUsuarios.Text,
            };

            if (indiceFila < 0)
            {
                // Si no hay fila seleccionada, agregar el nuevo rubro a la lista
                usuarios.Add(nuevoUsuario);
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    // código para guardar en la base de datos
                    // Insertar datos del nuevo usuario en la DB
                    string consulta = "INSERT INTO usuarios (Nombre, Dirección, Email, Telefono) VALUES ('" + nuevoUsuario.Nombre.Replace("'", "''") + "','" + nuevoUsuario.Direccion.Replace("'", "''") + "','" + nuevoUsuario.Email.Replace("'", "''") + "','" + nuevoUsuario.Telefono.Replace("'", "''") + "')";
                    ejecutarTransaccion(consulta);

                }
            }
            else
            {
                // Actualizar los datos del usuario en la lista
                usuarios[indiceFila] = nuevoUsuario;
                // Actualizar los datos del usuario en la DB
                string consulta = "UPDATE usuarios SET Nombre = '" + nuevoUsuario.Nombre.Replace("'", "''") + "', Dirección='" + nuevoUsuario.Direccion.Replace("'", "''") + "', Email='" + nuevoUsuario.Email.Replace("'", "''") + "', Telefono='" + nuevoUsuario.Telefono.Replace("'", "''") + "', WHERE id_usuario='" + nuevoUsuario.Id;
                ejecutarTransaccion(consulta);
            }

            LimpiarDatos();

            ActualizarDataGrid();
            msje("Datos Actualizados en: " + moduloActual);
            espera(1);

            // Habilitar nuevamente el DataGridView
            dataGridView1.Enabled = true;

            CargarDatos("SELECT * FROM " + moduloActual);


        }


        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un item para eliminar");
                return;
            }

            int idfila = Convert.ToInt32(txtId.Text);
            if (idfila > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el item " + idfila + "?", "Confirmación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el valor de la columna que identifica al elemento (supongamos que es la columna 0)
                    int num = idfila;

                    // Buscar y eliminar el elemento en la fuente de datos (ejemplo con una lista)
                    Usuario elemento = usuarios.FirstOrDefault(x => x.Id == num);
                    if (elemento != null)
                    {
                        usuarios.Remove(elemento);
                        ejecutarTransaccion("DELETE FROM " + moduloActual + " WHERE id=" + elemento.Id);

                        LimpiarDatos();
                        ActualizarDataGrid();
                        msje("¡Elemento eliminado!");
                        espera(1);
                        CargarDatos("SELECT * FROM " + moduloActual);
                        dataGridView1.Enabled = true;

                    }
                }
            }
        }
        #endregion
        #region Proveedor
        //Actualizar Proveedores
        private void BtnActualizarProveedores_Click(object sender, EventArgs e)
        {
            if ((indiceFila < 0 && txtNombreProveedores.Text == "") || (indiceFila > 0 && txtNombreProveedores.Text == "" && txtId.Text == ""))
            {
                msje("No hay datos para actualizar");
                return;
            }

            // Crear un nuevo objeto con los datos de los TextBox
            int idReg = 0;

            if (indiceFila < 0) { idReg = proveedores.Count() + 1; }

            if (indiceFila >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indiceFila];
                idReg = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            }

            Proveedor nuevo = new Proveedor
            {
                Id = idReg,
                Nombre = txtNombreProveedores.Text,
            };

            if (indiceFila < 0)
            {
                // Si no hay fila seleccionada, agregar el nuevo rubro a la lista
                proveedores.Add(nuevo);
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    // código para guardar en la base de datos
                    // Insertar datos del nuevo usuario en la DB
                    string consulta = "INSERT INTO proveedores (nombre) VALUES ('" + nuevo.Nombre.Replace("'", "''") + "')";
                    ejecutarTransaccion(consulta);
                }
            }
            else
            {
                // Actualizar los datos del usuario en la lista
                proveedores[indiceFila] = nuevo;
                // Actualizar los datos del usuario en la DB
                string consulta = "UPDATE proveedores SET nombre = '" + nuevo.Nombre.Replace("'", "''") + "' WHERE id=" + nuevo.Id;
                ejecutarTransaccion(consulta);
            }

            LimpiarDatos();

            ActualizarDataGrid();
            msje("Datos Actualizados en: " + moduloActual);
            espera(1);

            // Habilitar nuevamente el DataGridView
            dataGridView1.Enabled = true;

            CargarDatos("SELECT * FROM " + moduloActual);

        }

        private void BtnEliminarProveedores_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un item para eliminar");
                return;
            }

            int idfila = Convert.ToInt32(txtId.Text);
            if (idfila > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el item " + idfila + "?", "Confirmación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el valor de la columna que identifica al elemento (supongamos que es la columna 0)
                    int num = idfila;

                    // Buscar y eliminar el elemento en la fuente de datos (ejemplo con una lista)
                    Proveedor elemento = proveedores.FirstOrDefault(x => x.Id == num);
                    if (elemento != null)
                    {
                        proveedores.Remove(elemento);
                        ejecutarTransaccion("DELETE FROM " + moduloActual + " WHERE id=" + elemento.Id);

                        LimpiarDatos();
                        ActualizarDataGrid();
                        msje("¡Elemento eliminado!");
                        espera(1);
                        CargarDatos("SELECT * FROM " + moduloActual);
                        dataGridView1.Enabled = true;

                    }
                }
            }
        }
        #endregion
        #region productos
        private void btnActualizarPr_Click(object sender, EventArgs e)
        {
            if ((indiceFila < 0 && txtNombreProductos.Text == "") || (indiceFila > 0 && txtNombreProductos.Text == "" && txtId.Text == ""))
            {
                msje("No hay datos para actualizar");
                return;
            }
            if (Convert.ToInt16(cbxRubroProductos.SelectedValue) <= 0 || (Convert.ToInt16(cbxProveedorProductos.SelectedValue) <= 0))
            {
                msje("Complete los datos por favor");
                return;
            }

            // Crear un nuevo objeto con los datos de los TextBox
            int idReg = 0;

            if (indiceFila < 0) { idReg = productos.Count() + 1; }

            if (indiceFila >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[indiceFila];
                idReg = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            }

            Producto nuevoProducto = new Producto()
            {
                Id = idReg,
                Nombre = txtNombreProductos.Text,
                Rubro = Convert.ToInt32(cbxRubroProductos.SelectedValue),
                Proveedor = Convert.ToInt32(cbxProveedorProductos.SelectedValue),
                Precio = Convert.ToDouble(txtPrecioProductos.Text),
                Costo = Convert.ToDouble(txtCostoProductos.Text),

            };

            if (indiceFila < 0)
            {
                // Si no hay fila seleccionada, agregar el nuevo rubro a la lista
                productos.Add(nuevoProducto);
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    // código para guardar en la base de datos
                    // Insertar datos del nuevo usuario en la DB
                    string consulta = "INSERT INTO productos (nombre, id_rubro, id_proveedor, costo, precio) VALUES ('" + nuevoProducto.Nombre.Replace("'", "''") + "','" + nuevoProducto.Rubro + "','" + nuevoProducto.Proveedor + "','" + nuevoProducto.Costo + "','" + nuevoProducto.Precio + "')";
                    ejecutarTransaccion(consulta);
                    msje("Datos de Nuevo Producto Actualizado!");
                }
            }
            else
            {
                //actualizar los datos del producto en la lista
                productos[indiceFila] = nuevoProducto;
                //actualizar los datos del producto en la DB
                string consulta = "UPDATE productos SET nombre = '" + nuevoProducto.Nombre.Replace("'", "''") + "',id_rubro= '" + nuevoProducto.Rubro + "' ,id_proveedor= '" + nuevoProducto.Proveedor + "' ,costo= '" + nuevoProducto.Costo + "' ,precio= '" + nuevoProducto.Precio + "' WHERE Id=" + nuevoProducto.Id;
                ejecutarTransaccion(consulta);
            }

            LimpiarDatos();

            ActualizarDataGrid();
            msje("Datos de Producto Actualizados!");
            espera(1);

            // Habilitar nuevamente el DataGridView
            dataGridView1.Enabled = true;

            CargarDatos(@"SELECT p.*, r.nombre as rubro, pr.nombre as proveedor FROM productos p INNER JOIN rubros r ON p.id_rubro = r.id_rubros INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedores");


        }

        private void btnElimiarPr_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe seleccionar un item para eliminar.");
                return;
            }
            int idfila = Convert.ToInt32(txtId.Text);
            if (idfila > 0)
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el Item " + idfila + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    //obtener el valor de la columna que identifica  al elemento (supongamos que  es la columna  0 es decir  la Id en este caso
                    int num = idfila;

                    //buscar y eliminar  el elemento  de la fuente de datos (ejemplo con una lista)
                    Producto elemento = productos.FirstOrDefault(x => x.Id == num);
                    if (elemento != null)
                    {
                        productos.Remove(elemento);

                        ejecutarTransaccion("DELETE FROM productos WHERE id= " + elemento.Id);

                        LimpiarDatos();

                        ActualizarDataGrid();
                        msje("Producto eliminado!");
                        espera(1);

                        CargarDatos("SELECT p.*, r.nombre as rubro, pr.nombre as proveedor FROM  productos p INNER JOIN rubros r ON p.id_rubro = r.id_rubros INNER JOIN proveedores pr ON p.idproveedores pr ON p.id_proveedor = pr.id_proveedores");
                        dataGridView1.Enabled = true;
                    }
                }
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ocultar_grupos();
            moduloActual = "pedidos";
            gbPedidos.Visible = true;
            gbPedidos.Location = new Point(12, 75);
            gbPedidos.Size = new Size(320, 151);
            llenarComboCliente();
            CargarDatos("SELECT p.id_pedidos, p.id_usuario, u.Nombre, p.Total, p.Fecha from pedidos p JOIN usuarios u ON p.id_usuario =u.id_usuario");
        }

        private void btnAbrirpedidos_Click(object sender, EventArgs e)
        {
            if (btnAbrirpedidos.Text.Contains("ABRIR PEDIDO"))
            {
                if (cmbUsuario.SelectedIndex == 0 && dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("seleccione un pedido de la lista, o bien, un cliente para generar un nuevo pedido");

                }
                else
                {
                    btnAbrirpedidos.Text = "CERRAR PEDIDO";
                    btnAbrirpedidos.ForeColor = Color.Red;
                    gbItempedido.Visible = true;
                    dgvDetalles.Visible = true;
                    llenarcomboproducto();
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int id_Pedido = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_pedido"].Value);
                        CargarItemsPedido(id_Pedido);
                    }
                }
            }
            else if (btnAbrirpedidos.Text == "CERRAR PEDIDO")

            {
                if (dgvDetalles.Rows.Count == 0)
                {
                    MessageBox.Show("El pedido no puede estar vacio");
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int idPedido = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Pedido"].Value);
                        ActualizarPedido(idPedido);
                    }
                    else if (cmbUsuario.SelectedIndex > 0)
                    {
                        InsertarPedido();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un cliente pa un realizar un nuevo pedido");

                    }
                    MessageBox.Show("Pedido realizado exitosamente");
                    btnAbrirpedidos.Text = "ABRIR PEDIDO";
                    btnAbrirpedidos.ForeColor = Color.Green;
                    //habilitar el nuevamente el dataGridView
                    dataGridView1.Enabled = true;
                    gbItempedido.Visible = false;
                    dgvDetalles.Visible = false;
                }

            }

        }
        private void llenarComboCliente()
        {
            if (conexionDB != null)
            {
                //leer datos de DB
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string sql = "SELECT * FROM Usuarios";
                    usuarios.Clear();
                    usuarios.Add(new Usuario { Id = 0, Nombre = "Seleccione" });
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataReader leerDatos = comando.ExecuteReader();
                    while (leerDatos.Read())//lee y recorre cada fila  leia de la DB
                    {
                        usuarios.Add(new Usuario { Id = leerDatos.GetInt32("id_usuario"), Nombre = leerDatos.GetString("nombre") });
                    }
                }
            }
            else
            {
                MessageBox.Show("La conexion no esta configurada correctamente. ");
            }
            //establecer el origen de datos del Combobox
            cmbUsuario.DataSource = usuarios;

            // especificar que propiedada  se mostrara en el ComboBox
            cmbUsuario.DisplayMember = "Nombre";

            //especificar que Propiedad se usara  como valor
            cmbUsuario.ValueMember = "Id";
        }
        private void llenarcomboproducto()
        {
            if (conexionDB != null)
            {
                //leer datos de DB
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string sql = "SELECT * FROM Productos";
                    productos.Clear();
                    productos.Add(new Producto { Id = 0, Nombre = "Seleccione" });
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataReader leerDatos = comando.ExecuteReader();
                    while (leerDatos.Read())//lee y recorre cada fila  leia de la DB
                    {
                        productos.Add(new Producto
                        {
                            Id = leerDatos.GetInt32("id_productos"),
                            Nombre = leerDatos.GetString("nombre"),
                            Precio = leerDatos.GetDouble("precio"),
                            Costo = leerDatos.GetDouble("costo")
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("La conexion no esta configurada correctamente. ");
            }
            //establecer el origen de datos del Combobox
            cmbProducto.DataSource = productos;

            // especificar que propiedada  se mostrara en el ComboBox
            cmbProducto.DisplayMember = "Nombre";

            //especificar que Propiedad se usara  como valor
            cmbProducto.ValueMember = "Id";
        }
        private double calcularTotalPedido()
        {
            double total = 0;
            foreach (DataGridViewRow dr in dgvDetalles.Rows)
            {
                total += Convert.ToDouble(dr.Cells["total"].Value);
            }
            return total;
        }
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }
        private void InsertarPedido()
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();
                //insertamos pedido
                string SqlInsertarPedidos = " INSERT INTO pedidos (id_usuario,total) VALUES (@id_usuario,@total)";
                MySqlCommand comandopedidos = new MySqlCommand(SqlInsertarPedidos, conexion);
                comandopedidos.Parameters.AddWithValue("@id_usuario", cmbUsuario.SelectedValue);
                comandopedidos.Parameters.AddWithValue("@total", calcularTotalPedido());

                comandopedidos.ExecuteNonQuery();

                //obtener el id_pedido generado
                long idPedidoGenerado = comandopedidos.LastInsertedId;

                foreach (DataGridViewRow fila in dgvDetalles.Rows)
                {
                    if (fila.Cells["Nombre"].Value != null)
                    {
                        // Obtenemos el nombre del producto desde dgvDetalles
                        string nombreProducto = fila.Cells["Nombre"].Value.ToString();

                        // Buscamos el id del producto en listaProductos
                        int idProducto = productos
                                         .Where(p => p.Nombre == nombreProducto)
                                         .Select(p => p.Id)
                                         .FirstOrDefault();
                        string sqlInsertarItem = "INSERT INTO detalles_pedidos  (id_pedido, id_producto, cantidad, precio) VALUES (@id_pedido, @id_producto, @cantidad, @precio)";
                        using (MySqlCommand comandoItem = new MySqlCommand(sqlInsertarItem, conexion))
                        {

                            comandoItem.Parameters.AddWithValue("@id_pedido", idPedidoGenerado);
                            comandoItem.Parameters.AddWithValue("@id_producto", idProducto);
                            comandoItem.Parameters.AddWithValue("@cantidad", fila.Cells["cantidad"].Value);
                            comandoItem.Parameters.AddWithValue("@precio", fila.Cells["total"].Value);


                            comandoItem.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el producto");
                    }
                }
            }
            MessageBox.Show("Pedido insertado exitosamente");
            dgvDetalles.Visible = false;
        }
        private void ActualizarPedido (int idPedido)
        {
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();
                //borrar items existentes del pedido
                string SqlUpdatePedidos = "UPDATE pedidos SET total=@total, fecha=@fecha WHERE id_pedidos = @id_pedido";

                MySqlCommand comandopedidos = new MySqlCommand(SqlUpdatePedidos, conexion);
                comandopedidos.Parameters.AddWithValue("@total", calcularTotalPedido());
                comandopedidos.Parameters.AddWithValue("@fecha", DateTime.Now);
                comandopedidos.Parameters.AddWithValue("@id_pedido", idPedido);

                comandopedidos.ExecuteNonQuery();

                //borrar items existentes del pedio
                string sqlDeleteItems = "DELETE FROM detalles_pedidos WHERE id_pedido=@id_pedido";
                MySqlCommand comandoDeItems = new MySqlCommand(sqlDeleteItems, conexion);
                comandoDeItems.Parameters.AddWithValue("@id_pedido", idPedido);
                comandoDeItems.ExecuteNonQuery();
                

                //insertemos nuevos items

                foreach (DataGridViewRow fila in dgvDetalles.Rows)
                {
                    if (fila.Cells["Nombre"].Value != null)
                    {
                        // Obtenemos el nombre del producto desde dgvDetalles
                        string nombreProducto = fila.Cells["Nombre"].Value.ToString();

                        // Buscamos el id del producto en listaProductos
                        int idProducto = productos
                                         .Where(p => p.Nombre == nombreProducto)
                                         .Select(p => p.Id)
                                         .FirstOrDefault();
                        string sqlInsertarItem = "INSERT INTO detalles_pedidos  (id_pedido, id_producto, cantidad, precio) VALUES (@id_pedido, @id_producto, @cantidad, @precio)";
                        using (MySqlCommand comandoItem = new MySqlCommand(sqlInsertarItem, conexion))
                        {

                            comandoItem.Parameters.AddWithValue("@id_pedido", idPedido);
                            comandoItem.Parameters.AddWithValue("@id_producto", idProducto);
                            comandoItem.Parameters.AddWithValue("@cantidad", fila.Cells["cantidad"].Value);
                            comandoItem.Parameters.AddWithValue("@precio", fila.Cells["total"].Value);


                            comandoItem.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el producto");
                    }
                }
            }
            MessageBox.Show("Pedido insertado exitosamente");
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1 && productos.Count > cmbProducto.SelectedIndex)
            {
                int indice = cmbProducto.SelectedIndex;
                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad >= 0)
                {
                    double precio = Convert.ToInt32(txtCantidad.Text) * productos[indice].Precio;
                    txtPrecio.Text = precio.ToString();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbProducto.SelectedIndex>0)
            {
                Producto productoSel = (Producto)cmbProducto.SelectedItem;
                int cantidad;
                if(!int.TryParse(txtCantidad.Text,out cantidad)|| cantidad<=0)
                {
                    MessageBox.Show("Ingrese una cantidad valida");
                    return;
                }
                double total;
                if(!double.TryParse(txtPrecio.Text,out total)|| total<=0)
                {
                    MessageBox.Show("El total ingresado no en valido");
                    return;
                }
                dgvDetalles.Rows.Add(productoSel.Id, productoSel.Nombre, cantidad, total);

                cmbProducto.SelectedIndex = 0;
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }
        private void CargarItemsPedido(int id_Pedido)
        {
            dgvDetalles.Rows.Clear();
            string query = "SELECT id_pedido_item, p.nombre,pi.cantidad, pi.precio FROM detalles_pedidos pi JOIN productos p ON pi.id_producto=p.id_productos WHERE id_pedido=@idPedido";
            using (MySqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPedido", id_Pedido);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idItem = reader.GetInt32(0);
                        string nombreproducto = reader.GetString(1);
                        int cantidad = reader.GetInt32(2);
                        decimal precio = reader.GetDecimal(3);

                        dgvDetalles.Rows.Add(idItem, nombreproducto, cantidad, precio);
                    }
                }
            }
        }
    }
}
