using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpresa
{
    public partial class actualizar : Form
    {
        DataSet ds = new DataSet();
        string consulta;
        public actualizar()
        {
            InitializeComponent();
            OcultarDatos.ocultar(this);
            btnRegistro.Visible = false;
            btnEditar.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM " + comboBox1.Text;

            Conexion.mostrar(ds, consulta, dataGridView1);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            OcultarDatos.ocultar(this);
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("selecciona una tabla");
                return;
            }
            btnRegistro.Visible = true;
            btnEditar.Visible = false;
            switch (comboBox1.Text)
            {
                case "Trabajador":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Apellido Paterno";
                    label3.Text = "Apellido Materno";
                    label4.Text = "RFC";
                    label5.Text = "Numero de Seguro";
                    label6.Text = "idValeDeUso";
                    label7.Text = "idPuesto";
                    textBox1.Focus();
                    break;

                case "Turno":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Fecha Inicio";
                    label2.Text = "Fecha Final";
                    label3.Text = "idRegistro";
                    textBox1.Focus();
                    break;

                case "Registro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Numero";
                    label2.Text = "Fecha";
                    textBox1.Focus();
                    break;

                case "ValeDeUso":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo De Uso";
                    label2.Text = "Descripcion";
                    label3.Text = "Fecha";
                    textBox1.Focus();
                    break;

                case "Herramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Nombre";
                    label3.Text = "Marca";
                    label4.Text = "Modelo";
                    label5.Text = "idValeDeUso";
                    textBox1.Focus();
                    break;

                case "Inventario":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Articulo";
                    label2.Text = "Codigo";
                    label3.Text = "Cantidad";
                    label4.Text = "Precio";
                    textBox1.Focus();
                    break;

                case "Puesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Descripcion";
                    textBox1.Focus();
                    break;

                case "Pase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    textBox1.Focus();
                    break;

                case "Garage":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Numero";
                    label2.Text = "Ubicacion";
                    textBox1.Focus();
                    break;

                case "Planeacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    textBox1.Focus();
                    break;

                case "Cuadrilla":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Numero Cuadrilla";
                    label2.Text = "Numero De Trabajadores";
                    textBox1.Focus();
                    break;

                case "Refrigerador":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Marca";
                    label3.Text = "Modelo";
                    textBox1.Focus();
                    break;

                case "Almacen":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Numero de Almacen";
                    label2.Text = "Codigo Almacen";
                    label3.Text = "idRefrigerador";
                    textBox1.Focus();
                    break;

                case "LicenciaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Vigencia";
                    textBox1.Focus();
                    break;

                case "Vehiculo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Modelo";
                    label2.Text = "Marca";
                    label3.Text = "Cilindros";
                    label4.Text = "idGarage";
                    label5.Text = "idPlancha";
                    textBox1.Focus();
                    break;

                case "Plancha":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Marca";
                    label3.Text = "Modelo";
                    textBox1.Focus();
                    break;

                case "Fabricacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    textBox1.Focus();
                    break;

                case "Proyecto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    label4.Text = "idFabricacion";
                    label5.Text = "idPlaneacion";
                    label6.Text = "idEmpresa";
                    textBox1.Focus();
                    break;

                case "Adhesivo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Marca";
                    label2.Text = "Modelo";
                    label3.Text = "Precio";
                    label4.Text = "Cantidad";
                    label5.Text = "idRefrigerador";
                    textBox1.Focus();
                    break;
                case "Cuenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Descripcion";
                    label3.Text = "Cantidad";
                    label4.Text = "idFactura";
                    textBox1.Focus();
                    break;
                case "Cliente":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Apellido Paterno";
                    label3.Text = "Apellido Materno";
                    label4.Text = "RFC";
                    label5.Text = "Numero de Seguro";
                    label6.Text = "idContrato";
                    label7.Text = "idVenta";
                    textBox1.Focus();
                    break;

                case "Producto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Nombre";
                    label3.Text = "Descripcion";
                    textBox1.Focus();
                    break;

                case "Factura":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Descripcion";
                    label3.Text = "Fecha";
                    textBox1.Focus();
                    break;

                case "Banda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Material";
                    label2.Text = "Tamaño";
                    label3.Text = "Modelo";
                    label4.Text = "Tipo de Resistencia";
                    textBox1.Focus();
                    break;
                case "Localidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Estado";
                    textBox1.Focus();
                    break;
                case "Venta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Aritculo";
                    label3.Text = "Canantidad";
                    label4.Text = "fecha";
                    label5.Text = "idFactura";
                    textBox1.Focus();
                    break;

                case "Servicio":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo servicio";
                    label2.Text = "Descripcion";
                    label3.Text = "idContrato";
                    textBox1.Focus();
                    break;
                case "Sucursal":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Ubicacion";
                    label2.Text = "Codigo sucursal";
                    label3.Text = "Telefono";
                    textBox1.Focus();
                    break;
                case "Empresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    label4.Text = "idSucursal";
                    textBox1.Focus();
                    break;
                case "Pedido":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Cantidad";
                    label4.Text = "Fecha";
                    textBox1.Focus();
                    break;
                case "Accesorio":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "modelo";
                    label4.Text = "marca";
                    label5.Text = "precio";
                    textBox1.Focus();
                    break;
                case "Capacitacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Verificacion";
                    label2.Text = "tipo de mantenimento";
                    label3.Text = "idServicio";
                    label4.Text = "idPreventivo";
                    label5.Text = "idPrograma";
                    textBox1.Focus();
                    break;
                case "Nivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "Numero nivel";
                    label2.Text = "codigo Nivel";
                    textBox1.Focus();
                    break;
                case "Instalacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    textBox1.Focus();
                    break;
                case "Aplicacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    textBox1.Focus();
                    break;
                case "Preferencia":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "descripcion";
                    label2.Text = "tirulo";
                    textBox1.Focus();
                    break;
                case "Suministro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "descripcion";
                    textBox1.Focus();
                    break;
                case "Proveedor":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "direccion";
                    label3.Text = "telefono";
                    textBox1.Focus();
                    break;
                case "Opciones":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    textBox1.Focus();
                    break;
                case "Especialidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "descripcion";
                    label4.Text = "idCapasitacion";
                    textBox1.Focus();
                    break;
                case "Termino":
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "descripcion";
                    textBox1.Focus();
                    break;
                case "Empalme":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    label3.Text = "tipo de empalme";
                    label4.Text = "idServicio";
                    textBox1.Focus();
                    break;
                case "Contrato":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "anexos";
                    label2.Text = "fecha";
                    textBox1.Focus();
                    break;
                case "Capacitado":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellido paterno";
                    label3.Text = "apellido materno";
                    textBox1.Focus();
                    break;

                case "Preventivo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "tipos de preventivo";
                    label2.Text = "numero";
                    textBox1.Focus();
                    break;
                case "Programa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "fecha";
                    label2.Text = "dwscripcion";
                    textBox1.Focus();
                    break;
                case "Repuesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "dscripcion";
                    label2.Text = "modelo";
                    label3.Text = "idPrograma";
                    label4.Text = "idOperacion";
                    textBox1.Focus();
                    break;
                case "Operacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "fecha inicio";
                    label4.Text = "fecha final";
                    textBox1.Focus();
                    break;
                case "PersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellido paterno";
                    label3.Text = "apellido materno";
                    textBox1.Focus();
                    break;
                case "TrabajadorTurno":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idTurno";
                    textBox1.Focus();
                    break;
                case "TrabajadorRegistro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idRegistro";
                    textBox1.Focus();
                    break;
                case "TrabajadorHerramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idHerramienta";
                    textBox1.Focus();
                    break;
                case "TrabajadorPase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idPase";
                    textBox1.Focus();
                    break;
                case "TrabajadorVehiculo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idVehiculo";
                    textBox1.Focus();
                    break;
                case "TrabajadorLicenicaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idLicenciaDeConudir";
                    textBox1.Focus();
                    break;
                case "InventarioHerramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idInventario";
                    label2.Text = "idHerrameinta";
                    textBox1.Focus();
                    break;
                case "InventarioAlmacen":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idInventario";
                    label2.Text = "idAlmacen";
                    textBox1.Focus();
                    break;
                case "CuadrillaPase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCuadrilla";
                    label2.Text = "idPase";
                    textBox1.Focus();
                    break;
                case "ProyectoCudrilla":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idProyecto";
                    label2.Text = "idCuadrilla";
                    textBox1.Focus();
                    break;
                case "AlmacenPlancha":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idAlmacen";
                    label2.Text = "idPlancha";
                    textBox1.Focus();
                    break;
                case "VehiculoLicenciaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVehiculo";
                    label2.Text = "idLiceniaDeConduir";
                    textBox1.Focus();
                    break;
                case "AdhesivoBanda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idAdhesivo";
                    label2.Text = "idBanda";
                    textBox1.Focus();
                    break;
                case "ClienteCuenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCliente";
                    label2.Text = "idCuenta";
                    textBox1.Focus();
                    break;
                case "BandaInstalacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idBanda";
                    label2.Text = "idInstalacion";
                    textBox1.Focus();
                    break;
                case "VentaProducto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idProducto";
                    textBox1.Focus();
                    break;
                case "VentaBanda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idBanda";
                    textBox1.Focus();
                    break;
                case "VentaEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idEmpresa";
                    textBox1.Focus();
                    break;
                case "SucursalLocalidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idLocalidad";
                    textBox1.Focus();
                    break;
                case "EmpresaProyecto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idEmpresa";
                    label2.Text = "idProyecto";
                    textBox1.Focus();
                    break;
                case "PedidoEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idPedido";
                    label2.Text = "idEmpresa";
                    textBox1.Focus();
                    break;
                case "AccesorioVenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idAccesorio";
                    label2.Text = "idVenta";
                    textBox1.Focus();
                    break;
                case "AccesorioOpcion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idAccesorio";
                    label2.Text = "idOpcion";
                    textBox1.Focus();
                    break;
                case "MantenimentoPersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idMantenimento";
                    label2.Text = "idPersonaAcreditada";
                    textBox1.Focus();
                    break;
                case "InstalacionPreferencia":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idInstalacion";
                    label2.Text = "idPreferencia";
                    textBox1.Focus();
                    break;
                case "InstalacionAplicacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idInstalacion";
                    label2.Text = "idAplicacion";
                    textBox1.Focus();
                    break;
                case "PreferenciaOpcion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idPreferencia";
                    label2.Text = "idOpcion";
                    textBox1.Focus();
                    break;
                case "SuministroEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSuministro";
                    label2.Text = "idEmpresa";
                    textBox1.Focus();
                    break;
                case "ProveedorSuministro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idProveedor";
                    label2.Text = "idSuministro";
                    textBox1.Focus();
                    break;
                case "ProveedorPedido":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idProveedor";
                    label2.Text = "idPedido";
                    textBox1.Focus();
                    break;
                case "EspecialidadNivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idEspecialidad";
                    label2.Text = "idNivel";
                    textBox1.Focus();
                    break;
                case "EmpalmeRepuesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idEmpalme";
                    label2.Text = "idRepuesto";
                    textBox1.Focus();
                    break;
                case "ContratoTermino":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idContrato";
                    label2.Text = "idTermino";
                    textBox1.Focus();
                    break;
                case "CapacitadoNivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCapacitado";
                    label2.Text = "idNivel";
                    textBox1.Focus();
                    break;
                case "CapacitadoEspecialidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCapacitado";
                    label2.Text = "idEspecialidad";
                    textBox1.Focus();
                    break;
                case "PreventivoPersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idPreventivo";
                    label2.Text = "idPersonaAcreditada";
                    textBox1.Focus();
                    break;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dateTimePicker1.Value;
            string fecha = fecha1.ToString("yyyy-MM-dd");
            switch (comboBox1.Text)
            {
                case "Trabajador":
                    consulta = "INSERT INTO Trabajador(nombre, apellidoPaterno, apellidoMaterno, rfc, numeroDeSeguro, idValeDeUso, idPuesto) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;

                case "Turno":
                    consulta = "INSERT INTO Turno(fechaInicio, fechaFinal, idRegisto) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;

                case "Registro":
                    consulta = "INSERT INTO Registro(numero, fecha) VALUES('" + textBox1.Text + "','" + fecha + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ValeDeUso":
                    consulta = "INSERT INTO ValeDeUso(codigoDeUso, descripcion, fecha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Herramienta":
                    consulta = "INSERT INTO Herramienta(codigo, nombre, marca, modelo, idValeDeUso) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Inventario":
                    consulta = "INSERT INTO Inventario(articulo, codigo, cantidad, precio) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Puesto":
                    consulta = "INSERT INTO Puesto(nombre, descripción) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Pase":
                    consulta = "INSERT INTO Pase(nombre, codigo, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Garage":
                    consulta = "INSERT INTO Garage (numero, ubicacion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Planeacion":
                    consulta = "INSERT INTO Planeacion(nombre, codigo, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Cuadrilla":
                    consulta = "INSERT INTO Cuadrilla(numeroCuadrilla, numeroDeTrabajadores) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Refrigerador":
                    consulta = "INSERT INTO Refrigerador(codigo, marca, modelo) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Almacen":
                    consulta = "INSERT INTO Almacen(numeroAlmacen, codigoAlmacen, idRefrigerador) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "LicenciaDeConducir":
                    consulta = "INSERT INTO LicenciaDeConducir(codigo, vigencia) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Vehiculo":
                    consulta = "INSERT INTO Vehiculo(modelo, marca, cilindros, idGarage, idPlancha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Plancha":
                    consulta = "INSERT INTO Plancha(nombre, marca, modelo) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Fabricacion":
                    consulta = "INSERT INTO Fabricacion(nombre, codigo, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Proyecto":
                    consulta = "INSERT INTO Proyecto(nombre, codigo, descripcion, idFabricacion, idPlaneacion, idEmpresa) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Adhesvo":
                    consulta = "INSERT INTO Adhesvo(marca, modelo, precio, cantidad, idRefrigerador) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Cuenta":
                    consulta = "INSERT INTO Cuenta(codigo, descripcion, cantidad, idFactura) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Cliente":
                    consulta = "INSERT INTO Cliente(nombre, apellidoPaterno, apellidoMaterno, rfc, numeroDeSeguro, idContrato, idVenta) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Producto":
                    consulta = "INSERT INTO Producto(codigo, nombre, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Factura":
                    consulta = "INSERT INTO Factura(codigo, descripcion, fecha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Banda":
                    consulta = "INSERT INTO Banda(material, tamaño, modelo, tipoDeResistencia) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Localidad":
                    consulta = "INSERT INTO Localidad(nombre, estado) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Venta":
                    consulta = "INSERT INTO Venta(codigo, articulo, cantidad, fecha, idFactura) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Servicio":
                    consulta = "INSERT INTO Servicio(codigoServicio, descripcion, idContrato) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Sucursal":
                    consulta = "INSERT INTO Sucursal(ubicacion, codigoSucursal, telefono) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Empresa":
                    consulta = "INSERT INTO Empresa(nombre, direccion, telefono, idSucursal) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Pedido":
                    consulta = "INSERT INTO Pedido(nombre, codigo, cantidad, fecha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Accesorio":
                    consulta = "INSERT INTO Accesorio(nombre, codigo, modelo, marca, precio) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Capacitacion":
                    consulta = "INSERT INTO Capacitacion(descripcion, titulo, idServicio) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Mantenimento":
                    consulta = "INSERT INTO Mantenimento(verificacion, tipoDeMantenimento, idServicio, idPreventivo, idPrograma) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Nivel":
                    consulta = "INSERT INTO Nivel(numeroNivel, codigoNivel) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Instalacion":
                    consulta = "INSERT INTO Instalacion(nombre, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Aplicacion":
                    consulta = "INSERT INTO Aplicacion(nombre, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Preferencia":
                    consulta = "INSERT INTO Preferencia(descripcion, titulo) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Suministro":
                    consulta = "INSERT INTO Suministro(nombre, codigo, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Proveedor":
                    consulta = "INSERT INTO Proveedor(nombre, direccion, telefono) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Opcion":
                    consulta = "INSERT INTO Opcion(nombre, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Especialidad":
                    consulta = "INSERT INTO Especialidad(nombre, codigo, descripcion, idCapasitacion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Termino":
                    consulta = "INSERT INTO Termino(descripcion) VALUES('" + textBox1.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Empalme":
                    consulta = "INSERT INTO Empalme(nombre, descripcion, tipoDeEmpalme, idServicio) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Contrato":
                    consulta = "INSERT INTO Empalme(noanexos, fecha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Capasitado":
                    consulta = "INSERT INTO Capasitado(anexos, fecha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Preventivo":
                    consulta = "INSERT INTO Preventivo(tiposDePreventivo, numero) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Programa":
                    consulta = "INSERT INTO Programa(fecha, descripcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Repuesto":
                    consulta = "INSERT INTO Repuesto(descripcion, modelo, idPrograma, idOperacion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "Operacion":
                    consulta = "INSERT INTO Operacion(nombre, codigo, fechaInicio, fechaFinal) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "PersonaAcreditada":
                    consulta = "INSERT INTO PersonaAcreditada(nombre, apellidoPaterno, apellidoMaterno) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorTurno":
                    consulta = "INSERT INTO TrabajadorTurno(idTrabajador, idTurno) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorRegistro":
                    consulta = "INSERT INTO TrabajadorRegistro(idTrabajador, idRegistro) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorHerramenta":
                    consulta = "INSERT INTO TrabajadorHerramenta(idTrabajador, idHerramenta) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorPase":
                    consulta = "INSERT INTO TrabajadorPase(idTrabajador, idPase) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorVehiculo":
                    consulta = "INSERT INTO TrabajadorVehiculo(idTrabajador, idVehiculo) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "TrabajadorLicenciaDeConducir":
                    consulta = "INSERT INTO TrabajadorLicenciaDeConducir(idTrabajador, idLicenciaDeConducir) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "InventarioHerramenta":
                    consulta = "INSERT INTO InventarioHerramenta(idInventario, idHerramenta) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "InventarioAlmacen":
                    consulta = "INSERT INTO InventarioAlmacen(idInventario, idAlmacen) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "CuadrillaPase":
                    consulta = "INSERT INTO CuadrillaPase(idCuadrilla, idPase) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ProyectoCuadrilla":
                    consulta = "INSERT INTO ProyectoCuadrilla(idProyecto, idCuadrilla) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "AlmacenPlancha":
                    consulta = "INSERT INTO AlmacenPlancha(idAlmacen, idPlancha) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "VehiculoLicenciaDeConducir":
                    consulta = "INSERT INTO VehiculoLicenciaDeConducir(idVehiculo, idLicenciaDeConducir) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "AdhesivoBanda":
                    consulta = "INSERT INTO AdhesivoBanda(idAdhesivo, idBanda) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ClinteCuenta":
                    consulta = "INSERT INTO ClinteCuenta(idCliente, idCuenta) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "BandaInsalacion":
                    consulta = "INSERT INTO BandaInsalacion(idBanda, idInstalacion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "VentaProducto":
                    consulta = "INSERT INTO VentaProducto(idVenta, idProducto) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "VentaBanda":
                    consulta = "INSERT INTO VentaBanda(idVenta, idBanda) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "VentaEmpresa":
                    consulta = "INSERT INTO VentaEmpresa(idVenta, idEmpresa) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "SucursalLocalidad":
                    consulta = "INSERT INTO SucursalLocalidad(idSucursal, idLocalidad) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "EmpresaProyecto":
                    consulta = "INSERT INTO EmpresaProyecto(idEmpresa, idProyecto) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "PedidoEmpresa":
                    consulta = "INSERT INTO PedidoEmpresa(idPedido, idEmpresa) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "AccesorioVenta":
                    consulta = "INSERT INTO AccesorioVenta(idAccesorio, idVenta) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "AccesorioOpcion":
                    consulta = "INSERT INTO AccesorioOpcion(idAccesorio, idOpcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "MantenimentoPersonaAcreditada":
                    consulta = "INSERT INTO MantenimentoPersonaAcreditada(idMantenimento, idPersonaAcreditada) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "InventarioPreferencia":
                    consulta = "INSERT INTO InventarioPreferencia(idInventario, idPreferencia) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "InventarioAplicacion":
                    consulta = "INSERT INTO InventarioAplicacion(idInventario, idAplicacion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "PreferenciaOpcion":
                    consulta = "INSERT INTO PreferenciaOpcion(idPreferencia, idOpcion) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "SuministroEmpresa":
                    consulta = "INSERT INTO SuministroEmpresa(idSuministro, idEmpresa) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ProveedorSuministro":
                    consulta = "INSERT INTO ProveedorSuministro(idProveedor, idSuministro) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ProveedorPedido":
                    consulta = "INSERT INTO ProveedorPedido(idProveedor, idPedido) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "EspecialidadNivel":
                    consulta = "INSERT INTO EspecialidadNivel(idEspecialidad, idNivel) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "EmpalmeRepuesto":
                    consulta = "INSERT INTO EmpalmeRepuesto(idEmpalme, idRepuesto) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "ContratoTermino":
                    consulta = "INSERT INTO ContratoTermino(idContrato, idTermino) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "CapasitadoNivel":
                    consulta = "INSERT INTO CapasitadoNivel(idCapasitado, idNivel) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "CapasitadoEspecialidad":
                    consulta = "INSERT INTO CapasitadoEspecialidad(idCapasitado, idEspecialidad) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;
                case "PreventivoPersonaAcreditada":
                    consulta = "INSERT INTO PreventivoPersonaAcreditada(idPreventivo, idPersonaAcreditada) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ";
                    Conexion.insertar(consulta);
                    break;

            }
            Actualizar();

        }
    

        private void Actualizar()
            {
            btnRegistro.Visible = false;
            btnEditar.Visible = false;
            OcultarDatos.ocultar(this);
            consulta = "SELECT * FROM " + comboBox1.Text;
            Conexion.mostrar(ds, consulta, dataGridView1);
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("selecciona tabla");
                return;
            }
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();
            consulta = "DELETE FROM "+comboBox1.Text+" WHERE "+nombre+"="+id;
            Conexion.eliminar(consulta);
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("selecciona tabla");
                return;
            }
            btnEditar.Visible = true;
            btnRegistro.Visible = false;
            OcultarDatos.ocultar(this);
            string a = dataGridView1.ColumnCount.ToString();
            DataGridViewRow row = dataGridView1.CurrentRow;
            string dato1 = "";
            string dato2 = "";
            string dato3 = "";
            string dato4 = "";
            string dato5 = "";
            string dato6 = "";
            string dato7 = "";
            string dato8 = "";
            if (a=="2")
            {
                dato1 = row.Cells[1].Value.ToString();

            }
            else if (a=="3")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[1].Value.ToString();
            }
            else if (a == "4")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
            }
            else if (a == "5")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
            }
            else if (a == "6")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
            }
            else if (a == "7")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
            }
            else if (a == "8")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
            }
            else if (a == "9")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
            }
            switch (comboBox1.Text)
            {
                case "Trabajador":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellido paterno";
                    label3.Text = "apellido materno";
                    label4.Text = "rfc";
                    label5.Text = "numero de seguro";
                    label6.Text = "estatus";
                    label7.Text = "idValeDeUso";
                    label8.Text = "idPuesto";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox7.Text = dato7;
                    textBox8.Text = dato8;
                    break;

                case "Turno":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Fecha Inicio";
                    label2.Text = "Fecha Final";
                    label3.Text = "estatus";
                    label4.Text = "idRegistro";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Registro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Numero";
                    label2.Text = "Fecha";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;

                case "ValeDeUso":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo De Uso";
                    label2.Text = "Descripcion";
                    label3.Text = "Fecha";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato3;
                  
                    break;

                case "Herramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Nombre";
                    label3.Text = "Marca";
                    label4.Text = "Modelo";
                    label5.Text = "estatus";
                    label6.Text = "idValeDeUso";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;

                case "Inventario":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Articulo";
                    label2.Text = "Codigo";
                    label3.Text = "Cantidad";
                    label4.Text = "Precio";
                    label5.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;

                case "Puesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Descripcion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;

                case "Pase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Garage":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Numero";
                    label2.Text = "Ubicacion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;

                case "Planeacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Cuadrilla":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Numero Cuadrilla";
                    label2.Text = "Numero De Trabajadores";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;

                case "Refrigerador":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Marca";
                    label3.Text = "Modelo";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Almacen":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Numero de Almacen";
                    label2.Text = "Codigo Almacen";
                    label3.Text = "estatus";
                    label4.Text = "idRefrigerador";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "LicenciaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Vigencia";
                    label3.Text = "Estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;

                case "Vehiculo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Modelo";
                    label2.Text = "Marca";
                    label3.Text = "Cilindros";
                    label4.Text = "estatus";
                    label5.Text = "idGarage";
                    label6.Text = "idPlancha";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;

                case "Plancha":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Marca";
                    label3.Text = "Modelo";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Fabricacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Proyecto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Descripcion";
                    label4.Text = "estatus";
                    label5.Text = "idFabricacion";
                    label6.Text = "idPlaneacion";
                    label7.Text = "idEmpresa";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox7.Text = dato7;
                   
                    break;

                case "Adhesivo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Marca";
                    label2.Text = "Modelo";
                    label3.Text = "Precio";
                    label4.Text = "Cantidad";
                    label5.Text = "estatus";
                    label6.Text = "idRefrigerador";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;
                case "Cuenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Descripcion";
                    label3.Text = "Cantidad";
                    label4.Text = "estatus";
                    label5.Text = "idFactura";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;
                case "Cliente":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Apellido Paterno";
                    label3.Text = "Apellido Materno";
                    label4.Text = "RFC";
                    label5.Text = "Numero de Seguro";
                    label6.Text = "estatus";
                    label7.Text = "idContrato";
                    label8.Text = "idVenta";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox7.Text = dato7;
                    textBox8.Text = dato8;
                    break;

                case "Producto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Nombre";
                    label3.Text = "Descripcion";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Factura":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Descripcion";
                    label3.Text = "Fecha";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Banda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Material";
                    label2.Text = "Tamaño";
                    label3.Text = "Modelo";
                    label4.Text = "Tipo de Resistencia";
                    label5.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;
                case "Localidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Estado";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;
                case "Venta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Codigo";
                    label2.Text = "Aritculo";
                    label3.Text = "Canantidad";
                    label4.Text = "fecha";
                    label5.Text = "estatus";
                    label6.Text = "idFactura";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;

                case "Servicio":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Codigo servicio";
                    label2.Text = "Descripcion";
                    label3.Text = "estatus";
                    label4.Text = "idContrato";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;
                case "Sucursal":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "Ubicacion";
                    label2.Text = "Codigo sucursal";
                    label3.Text = "Telefono";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;
                case "Empresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Direccion";
                    label3.Text = "Telefono";
                    label4.Text = "estatus";
                    label5.Text = "idSucursal";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;
                  
                case "Pedido":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "Cantidad";
                    label4.Text = "Fecha";
                    label5.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;
                case "Accesorio":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Codigo";
                    label3.Text = "modelo";
                    label4.Text = "marca";
                    label5.Text = "precio";
                    label6.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;
                case "Capacitacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "Verificacion";
                    label2.Text = "tipo de mantenimento";
                    label3.Text = "estatus";
                    label4.Text = "idServicio";
                    label5.Text = "idPreventivo";
                    label6.Text = "idPrograma";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    break;
                case "Nivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "Numero nivel";
                    label2.Text = "codigo Nivel";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Instalacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    label3.Text = "eststus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Aplicacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Preferencia":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "descripcion";
                    label2.Text = "titulo";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Suministro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "descripcion";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;

                    break;
                case "Proveedor":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "direccion";
                    label3.Text = "telefono";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;
                case "Opciones":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Especialidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "descripcion";
                    label4.Text = "estatus";
                    label5.Text = "idCapasitacion";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                     break;
                case "Termino":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "descripcion";
                    label2.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    break;
                case "Empalme":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "descripcion";
                    label3.Text = "tipo de empalme";
                    label4.Text = "estatus";
                    label5.Text = "idServicio";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                   
                    break;
                case "Contrato":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "anexos";
                    label2.Text = "fecha";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Capacitado":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellido paterno";
                    label3.Text = "apellido materno";
                    label4.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    break;

                case "Preventivo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "tipos de preventivo";
                    label2.Text = "numero";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Programa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "fecha";
                    label2.Text = "descripcion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    break;
                case "Repuesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "dscripcion";
                    label2.Text = "modelo";
                    label3.Text = "estatus";
                    label4.Text = "idPrograma";
                    label5.Text = "idOperacion";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    break;
                case "Operacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "codigo";
                    label3.Text = "fecha inicio";
                    label4.Text = "fecha final";
                    label5.Text = "estatus";
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;
                case "PersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellido paterno";
                    label3.Text = "apellido materno";
                    label4.Text = "estatus";
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;
                case "TrabajadorTurno":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idTurno";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "TrabajadorRegistro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idRegistro";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "TrabajadorHerramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idHerramienta";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "TrabajadorPase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idPase";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "TrabajadorVehiculo":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idVehiculo";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "TrabajadorLicenicaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idTrabajador";
                    label2.Text = "idLicenciaDeConudir";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "InventarioHerramienta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idInventario";
                    label2.Text = "idHerrameinta";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "InventarioAlmacen":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idInventario";
                    label2.Text = "idAlmacen";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "CuadrillaPase":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCuadrilla";
                    label2.Text = "idPase";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "ProyectoCudrilla":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idProyecto";
                    label2.Text = "idCuadrilla";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "AlmacenPlancha":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idAlmacen";
                    label2.Text = "idPlancha";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "VehiculoLicenciaDeConducir":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVehiculo";
                    label2.Text = "idLiceniaDeConduir";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "AdhesivoBanda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idAdhesivo";
                    label2.Text = "idBanda";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "ClienteCuenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCliente";
                    label2.Text = "idCuenta";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "BandaInstalacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idBanda";
                    label2.Text = "idInstalacion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "VentaProducto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idProducto";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "VentaBanda":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idBanda";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "VentaEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVenta";
                    label2.Text = "idEmpresa";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "SucursalLocalidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idLocalidad";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "EmpresaProyecto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idEmpresa";
                    label2.Text = "idProyecto";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "PedidoEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idPedido";
                    label2.Text = "idEmpresa";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "AccesorioVenta":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idAccesorio";
                    label2.Text = "idVenta";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "AccesorioOpcion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idAccesorio";
                    label2.Text = "idOpcion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "MantenimentoPersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idMantenimento";
                    label2.Text = "idPersonaAcreditada";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "InstalacionPreferencia":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idInstalacion";
                    label2.Text = "idPreferencia";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "InstalacionAplicacion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idInstalacion";
                    label2.Text = "idAplicacion";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "PreferenciaOpcion":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idPreferencia";
                    label2.Text = "idOpcion";
                    label3.Text = "estatus";
                    textBox1.Focus(); 
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "SuministroEmpresa":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSuministro";
                    label2.Text = "idEmpresa";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "ProveedorSuministro":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idProveedor";
                    label2.Text = "idSuministro";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "ProveedorPedido":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idProveedor";
                    label2.Text = "idPedido";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "EspecialidadNivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idEspecialidad";
                    label2.Text = "idNivel";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "EmpalmeRepuesto":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idEmpalme";
                    label2.Text = "idRepuesto";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "ContratoTermino":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idContrato";
                    label2.Text = "idTermino";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "CapacitadoNivel":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCapacitado";
                    label2.Text = "idNivel";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "CapacitadoEspecialidad":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCapacitado";
                    label2.Text = "idEspecialidad";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
                case "PreventivoPersonaAcreditada":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idPreventivo";
                    label2.Text = "idPersonaAcreditada";
                    label3.Text = "estatus";
                    textBox1.Focus();
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();
            switch (comboBox1.Text)
            {
                case "Trabajador":
                    consulta = "UPDATE Trabajador SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET apellidoPaterno ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET apellidoMaterno ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET rfc ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET numeroDeSeguro ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET idValeDeUso ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET idPuesto ='" + textBox7.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Trabajador SET estatus ='" + textBox8.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Turno":
                    consulta = "UPDATE Turno SET fechaInicio ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Turno SET fechaFinal ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Turno SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Turno SET idRegistro ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Registro":
                    consulta = "UPDATE Registro SET numero ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Registro SET fecha ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Registro SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ValeDeUso":
                    consulta = "UPDATE ValeDeUso SET codigoDeUso ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ValeDeUso SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ValeDeUso SET fecha ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ValeDeUso SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Herramenta":
                    consulta = "UPDATE Herramenta SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Herramenta SET nombre ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Herramenta SET marca ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Herramenta SET modelo ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Herramenta SET estatus ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Herramenta SET idVale ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Inventario":
                    consulta = "UPDATE Inventario SET articulo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Inventario SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Inventario SET cantidad ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Inventario SET precio ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Inventario SET estatus ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Puesto":
                    consulta = "UPDATE Puesto SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Puesto SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Puesto SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Pase":
                    consulta = "UPDATE Pase SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pase SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pase SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pase SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Garage":
                    consulta = "UPDATE Garage SET numero ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Garage SET ubicacion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Garage SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                     break;
                case "Planeacion":
                    consulta = "UPDATE Planeacion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Planeacion SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Planeacion SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Planeacion SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Cuadrilla":
                    consulta = "UPDATE Cuadrilla SET numeroCuadrilla ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cuadrilla SET numeroDeTrabajadores ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cuadrilla SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Refrigerador":
                    consulta = "UPDATE Refrigerador SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Refrigerador SET marca ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Refrigerador SET modelo ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Refrigerador SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Almacen":
                    consulta = "UPDATE Almacen SET numeroAlmacen ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Almacen SET codigoAlmacen ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Almacen SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Almacen SET idRefrigerador ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "LicenciaDeConducir":
                    consulta = "UPDATE LicenciaDeConducir SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE LicenciaDeConducir SET vigencia ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE LicenciaDeConducir SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Vehiculo":
                    consulta = "UPDATE Vehiculo SET modelo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Vehiculo SET marca ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Vehiculo SET cilindros ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Vehiculo SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Vehiculo SET idGarage ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Vehiculo SET idPlancha ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Plancha":
                    consulta = "UPDATE Plancha SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Plancha SET marca ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Plancha SET modelo ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Plancha SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Fabricacion":
                    consulta = "UPDATE Fabricacion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Fabricacion SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Fabricacion SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Fabricacion SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Proyecto":
                    consulta = "UPDATE Proyecto SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET idFabricacion ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET idPlaneacion ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proyecto SET idEmpresa ='" + textBox7.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Adhesivo":
                    consulta = "UPDATE Adhesivo SET marca ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET modelo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET precio ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET cantidad ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET estatus ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET idRefrigerador ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                     break;
                case "Cuenta":
                    consulta = "UPDATE Cuenta SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cuenta SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cuenta SET cantidad ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cuenta SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Adhesivo SET idFactura ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                     break;
                case "Cliente":
                    consulta = "UPDATE Cliente SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET apellidoPaterno ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET apellidoMaterno ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET rfc ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET numeroDeSeguro ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET estatus ='" + textBox6.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET idContrato ='" + textBox7.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Cliente SET idVenta ='" + textBox8.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Producto":
                    consulta = "UPDATE Producto SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Producto SET nombre ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Producto SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Producto SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Factura":
                    consulta = "UPDATE Factura SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Factura SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Factura SET fecha ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Factura SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Banda":
                    consulta = "UPDATE Banda SET material ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Banda SET tamaño ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Banda SET modelo ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Banda SET tipoDeResistencia ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Banda SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Localidad":
                    consulta = "UPDATE Localidad SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Localidad SET estado ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Localidad SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Venta":
                    consulta = "UPDATE Venta SET codigo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Venta SET articulo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Venta SET cantidad ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Venta SET fecha ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Venta SET estatus ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Venta SET idFactura ='" + textBox7.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Servicio":
                    consulta = "UPDATE Servicio SET codigoServicio ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Servicio SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Servicio SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Servicio SET idContrato ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Sucursal":
                    consulta = "UPDATE Sucursal SET ubicacion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Sucursal SET codigoSucursal ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Sucursal SET telefono ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Sucursal SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Empresa":
                    consulta = "UPDATE Empresa SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empresa SET direccion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empresa SET telefono ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empresa SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empresa SET idSucursal ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Pedido":
                    consulta = "UPDATE Pedido SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pedido SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pedido SET cantidad ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pedido SET fecha ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Pedido SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Accesorio":
                    consulta = "UPDATE Accesorio SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Accesorio SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Accesorio SET modelo ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Accesorio SET marca ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Accesorio SET precio ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Accesorio SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Capacitacion":
                    consulta = "UPDATE Capacitacion SET descripcion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capacitacion SET titulo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capacitacion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capacitacion SET idServicio ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Mantenimento":
                    consulta = "UPDATE Mantenimento SET verificacion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Mantenimento SET tipoDeMantenimento ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Mantenimento SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Mantenimento SET idServicio ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Mantenimento SET idPreventivo ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Mantenimento SET idPrograma ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Nivel":
                    consulta = "UPDATE Nivel SET NumeroNivel ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Nivel SET codigoNivel ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Nivel SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Instalacion":
                    consulta = "UPDATE Instalacion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Instalacion SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Instalacion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Aplicacion":
                    consulta = "UPDATE Aplicacion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Aplicacion SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Aplicacion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Preferencia":
                    consulta = "UPDATE Preferencia SET descripcion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Preferencia SET titulo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Preferencia SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Suministro":
                    consulta = "UPDATE Suministro SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Suministro SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Suministro SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Suministro SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Proveedor":
                    consulta = "UPDATE Proveedor SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proveedor SET direccion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proveedor SET telefono ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Proveedor SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Opcion":
                    consulta = "UPDATE Opcion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Opcion SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Opcion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Especialidad":
                    consulta = "UPDATE Especialidad SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Especialidad SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Especialidad SET descripcion ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Especialidad SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Especialidad SET idCapacitacion ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Termino":
                    consulta = "UPDATE Termino SET descripcion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Termino SET estatus ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                     break;
                case "Empalme":
                    consulta = "UPDATE Empalme SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empalme SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empalme SET tipoDeEmpalme ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empalme SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Empalme SET idServicio ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Contrato":
                    consulta = "UPDATE Contrato SET anexo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Contrato SET fecha ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Contrato SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Capasitado":
                    consulta = "UPDATE Capasitado SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capasitado SET apellidoPaterno ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capasitado SET apellidoPaterno ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Capasitado SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Preventivo":
                    consulta = "UPDATE Preventivo SET tiposDePreventivo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Preventivo SET numero ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Preventivo SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Programa":
                    consulta = "UPDATE Programa SET fecha ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Programa SET descripcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Programa SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Repuesto":
                    consulta = "UPDATE Repuesto SET descripcion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Repuesto SET modelo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Repuesto SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Repuesto SET idPrograma ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Repuesto SET idOperacion ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "Operacion":
                    consulta = "UPDATE Operacion SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Operacion SET codigo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Operacion SET fechaInicio ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Operacion SET fechaFinal ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE Operacion SET estatus ='" + textBox5.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "PersonaAcreditada":
                    consulta = "UPDATE PersonaAcreditada SET nombre ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PersonaAcreditada SET apellidoPaterno ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PersonaAcreditada SET apellidoMaterno ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PersonaAcreditada SET estatus ='" + textBox4.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "TrabajadorTurno":
                    consulta = "UPDATE TrabajadorTurno SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorTurno SET idTurno ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorTurno SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                     break;
                case "TrabajadorRegistro":
                    consulta = "UPDATE TrabajadorRegistro SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorRegistro SET idRegistro ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorRegistro SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "TrabajadorHerramenta":
                    consulta = "UPDATE TrabajadorHerramenta SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorHerramenta SET idHerramenta ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorHerramenta SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "TrabajadorPase":
                    consulta = "UPDATE TrabajadorPase SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorPase SET idPase ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorPase SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "TrabajadorVehiculo":
                    consulta = "UPDATE TrabajadorVehiculo SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorVehiculo SET idVehiculo ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorVehiculo SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "TrabajadorLicenciaDeConducir":
                    consulta = "UPDATE TrabajadorLicenciaDeConducir SET idTrabajador ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorLicenciaDeConducir SET idLicenciaDeConducir ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE TrabajadorLicenciaDeConducir SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "InventarioHeramenta":
                    consulta = "UPDATE InventarioHeramenta SET idInventario ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InventarioHeramenta SET idHerramenta ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InventarioHeramenta SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "InventarioAlmacen":
                    consulta = "UPDATE InventarioHeramenta SET idInventario ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InventarioHeramenta SET idAlmancen ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InventarioHeramenta SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "CuadrillaPase":
                    consulta = "UPDATE CuadrillaPase SET idCuadrilla ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CuadrillaPase SET idPase ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CuadrillaPase SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ProyectoCuadrilla":
                    consulta = "UPDATE ProyectoCuadrilla SET idProyecto ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProyectoCuadrilla SET idCuadrilla ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProyectoCuadrilla SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "AlmacenPlancha":
                    consulta = "UPDATE AlmacenPlancha SET idAlmacen ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AlmacenPlancha SET idPlancha ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AlmacenPlancha SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "VehiculoLicenciaDeConducir":
                    consulta = "UPDATE VehiculoLicenciaDeConducir SET idVehiculo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VehiculoLicenciaDeConducir SET idLicenicaDeConducir ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VehiculoLicenciaDeConducir SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "AdhesivoBanda":
                    consulta = "UPDATE AdhesivoBanda SET idAdhesivo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AdhesivoBanda SET idBanda ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AdhesivoBanda SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ClienteCuenta":
                    consulta = "UPDATE ClienteCuenta SET idCliente ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ClienteCuenta SET idCuenta ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ClienteCuenta SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "BandaInstalacion":
                    consulta = "UPDATE BandaInstalacion SET idBanda ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE BandaInstalacion SET idInstalacion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE BandaInstalacion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "VentaProducto":
                    consulta = "UPDATE VentaProducto SET idVenta ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaProducto SET idProducto ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaProducto SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "VentaBanda":
                    consulta = "UPDATE VentaBanda SET idVenta ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaBanda SET idBanda ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaBanda SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "VentaEmpresa":
                    consulta = "UPDATE VentaEmpresa SET idVenta ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaEmpresa SET idEmpresa ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE VentaEmpresa SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "SucursalLocalidad":
                    consulta = "UPDATE SucursalLocalidad SET idSucursal ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE SucursalLocalidad SET idLocalidad ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE SucursalLocalidad SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "EmpresaProyecto":
                    consulta = "UPDATE EmpresaProyecto SET idEmpresa ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EmpresaProyecto SET idProyecto ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EmpresaProyecto SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "PedidoEmpresa":
                    consulta = "UPDATE PedidoEmpresa SET idPedido ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PedidoEmpresa SET idEmpresa ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PedidoEmpresa SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "AccesorioVenta":
                    consulta = "UPDATE AccesorioVenta SET IdAccesorio ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AccesorioVenta SET idVenta ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AccesorioVenta SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "AccesorioOpcion":
                    consulta = "UPDATE AccesorioOpcion SET IdAccesorio ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AccesorioOpcion SET idOpcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE AccesorioOpcion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "MantenimentoPersonaAcreditada":
                    consulta = "UPDATE MantenimentoPersonaAcreditada SET idMantenimiento ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE MantenimentoPersonaAcreditada SET idPersonaAcreditada ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE MantenimentoPersonaAcreditada SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "InstalacionPreferencia":
                    consulta = "UPDATE InstalacionPreferencia SET idInstalacion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InstalacionPreferencia SET idPreferencia ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InstalacionPreferencia SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "InstalacionAplicacion":
                    consulta = "UPDATE InstalacionAplicacion SET idInstalacion ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InstalacionAplicacion SET idAplicacion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE InstalacionAplicacion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "PreferenciaOpcion":
                    consulta = "UPDATE PreferenciaOpcion SET idPreferencia ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PreferenciaOpcion SET idOpcion ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PreferenciaOpcion SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "SuministroEmpresa":
                    consulta = "UPDATE SuministroEmpresa SET idSuministro ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE SuministroEmpresa SET idEmpresa ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE SuministroEmpresa SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ProveedorSuministro":
                    consulta = "UPDATE ProveedorSuministro SET idProveedor ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProveedorSuministro SET idSuministro ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProveedorSuministro SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ProveedorPedido":
                    consulta = "UPDATE ProveedorPedido SET idProveedor ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProveedorPedido SET idPedido ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ProveedorPedido SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "EspecialidadNivel":
                    consulta = "UPDATE EspecialidadNivel SET idEspecialidad ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EspecialidadNivel SET idNivel ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EspecialidadNivel SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "EmpalmeRepuesto":
                    consulta = "UPDATE EmpalmeRepuesto SET idEmpalme ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EmpalmeRepuesto SET idRepuesto ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE EmpalmeRepuesto SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "ContratoTermino":
                    consulta = "UPDATE ContratoTermino SET idContrato ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ContratoTermino SET idTermino ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE ContratoTermino SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "CapacitadoNivel":
                    consulta = "UPDATE CapacitadoNivel SET idCapacitado ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CapacitadoNivel SET idNivel ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CapacitadoNivel SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "CapacitadoEspecialidad":
                    consulta = "UPDATE CapacitadoEspecialidad SET idCapacitado ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CapacitadoEspecialidad SET idEspecialidad ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE CapacitadoEspecialidad SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
                case "PreventivoPersonaAcreditada":
                    consulta = "UPDATE PreventivoPersonaAcreditada SET idPreventivo ='" + textBox1.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PreventivoPersonaAcreditada SET idPersonaAcreditada ='" + textBox2.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "UPDATE PreventivoPersonaAcreditada SET estatus ='" + textBox3.Text + "' WHERE " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;
            }
            MessageBox.Show("registro se modifico");
            Actualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("selecciona tabla");
                return;
            }
            btnEditar.Visible = false;
            btnRegistro.Visible = false;
            OcultarDatos.ocultar(this);
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                string nombre = dataGridView1.Columns[i].HeaderText.ToString();
                comboBox2.Items.Add(nombre);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            textBox9.Visible = true;
            label9.Text = comboBox2.Text;

        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            consulta = "SELECT * FROM " + comboBox1.Text + " WHERE " + comboBox2.Text + " LIKE('" + textBox9.Text + "%')";
            Conexion.mostrar(ds, consulta, dataGridView1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que deseas cambiar", "Manejadores", MessageBoxButtons.YesNo);
            if (result ==DialogResult.Yes)
            {
                btnRegistro.Visible = false;
                btnEditar.Visible = false;
                comboBox2.Visible = false;
                OcultarDatos.ocultar(this);
                Conexion.Manejadores(comboBox3, comboBox1, dataGridView1);                                      
            }
            else if(result==DialogResult.No)
            {
                return;  
            }
        }
    }
}

