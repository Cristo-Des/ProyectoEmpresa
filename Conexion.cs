using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.OracleClient;
using System.Configuration;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEmpresa
{
   public class Conexion

    {
        private static string servidor;
        private static MySqlConnection mysqlconexion;
        private static OracleConnection oracleconexion;
        private static string conexion = "server = localhost\\sqlexpress02;database = Proyecto; trusted_connection = true;";
      private static SqlConnection dato = new SqlConnection(conexion);
        public static void mostrar(DataSet ds, string consulta, DataGridView dataGridView)
        {
            if (servidor=="SQL")
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, dato);
                ds = new DataSet();
                da.Fill(ds, "empresa");
                dataGridView.DataSource = ds.Tables["empresa"];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
              else if (servidor == "MySql")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, mysqlconexion);
                ds = new DataSet();
                da.Fill(ds, "empresa");
                dataGridView.DataSource = ds.Tables["empresa"];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (servidor == "Oracle")
            {
                
                OracleDataAdapter da = new OracleDataAdapter(consulta, oracleconexion);
                oracleconexion.Open();
                ds = new DataSet();
                da.Fill(ds, "empresa");
                dataGridView.DataSource = ds.Tables["empresa"];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn columnas in dataGridView.Columns)
                {
                    columnas.HeaderText = columnas.HeaderText.ToLower();
                }
                oracleconexion.Close();
            }

        }
        public static void insertar(string consulta)
        {
            if (servidor=="SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, dato);
                    dato.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se registro");
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                dato.Close();

            }
            else if (servidor =="MySql")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se registro");
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor=="Oracle")
            {
                try
                {
                    
                   OracleCommand comando = new OracleCommand(consulta, oracleconexion);
                    oracleconexion.Open();
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.InsertCommand = comando;
                    if (dta.InsertCommand.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se registro");
                    }
                }
                catch (OracleException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                oracleconexion.Close();
            }
        }
        public static void eliminar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, dato);
                    dato.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se registro");
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                dato.Close();

            }
            else if (servidor == "MySql")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se registro");
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "Oracle")
            {
                try
                {
                    
                    OracleCommand comando = new OracleCommand(consulta, oracleconexion);
                    oracleconexion.Open();
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.DeleteCommand = comando;
                    if (dta.DeleteCommand.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("se elimino");
                    }
                }
                catch (OracleException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                oracleconexion.Close();
            }
        }
        public static void modificar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {
                    SqlCommand comando = new SqlCommand(consulta, dato);
                    dato.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                dato.Close();

            }
            else if (servidor == "MySql")
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                       
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                mysqlconexion.Close();
            }
            else if (servidor == "Oracle")
            {
                try
                {
                   
                    OracleCommand comando = new OracleCommand(consulta, oracleconexion);
                    oracleconexion.Open();
                    OracleDataAdapter dta = new OracleDataAdapter();
                    dta.InsertCommand = comando;
                    if (dta.InsertCommand.ExecuteNonQuery() != 0)
                    {
                        
                    }
                }
                catch (OracleException ex)
                {

                    MessageBox.Show("no se registro " + ex.Message);
                }
                oracleconexion.Close();
            }
            
        }
        public static void Manejadores(ComboBox ComboBox3, ComboBox ComboBox1, DataGridView dataGridView1)
        {
            switch (ComboBox3.Text)
            {
                case "SQL":
                    conexion =  "server = localhost\\sqlexpress02;database = Proyecto; trusted_connection = true;";
                    dato = new SqlConnection(conexion);
                    MessageBox.Show("Se realizon la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor="SQL";
                    break;
                case "MySql":
                    conexion = "server = localhost;database = proyecto; uid = root;pwd = cris110100;";
                    mysqlconexion = new MySqlConnection(conexion);
                    MessageBox.Show("Se realizon la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor = "MySql";
                    break;
                case "Oracle":
                    conexion = "Data Source = orcl; User Id = system; Password = Cris110100;";
                   // conexion = "Data Source = orcl; Password Cris110100; user id = system;";
                    oracleconexion = new OracleConnection(conexion);
                    MessageBox.Show("Se realizon la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor = "Oracle";
                    break;
            }
        }

    }
}
