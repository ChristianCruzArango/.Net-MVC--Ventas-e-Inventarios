using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programa.Connection
{
    
    class Conexion
    {
        #region Variables de conexion
        private String user;
        private String password;
        private String server;
        private String dataBase;
        MySqlConnectionStringBuilder cadenaConection;
        MySqlConnection connection;
        #endregion

        public MySqlConnection Connection1
        {
            get { return connection; }
            set { connection = value; }
        }
        MySqlCommand cmd;


        #region Se incluye los datos de la base de datos
        public Conexion()
        { 
            user = "root";
            password = "";
            server = "localhost";
            dataBase = "programa";
            conectar();
        }
        #endregion

        #region Conexion a la base de datos 
        public void conectar()
        {
            try
            {
                cadenaConection = new MySqlConnectionStringBuilder();
                cadenaConection.Server = server;
                cadenaConection.UserID = user;
                cadenaConection.Password = password;
                cadenaConection.Database = dataBase;
                cadenaConection.IntegratedSecurity = true;
                cadenaConection.SqlServerMode = true;
                connection = new MySqlConnection(cadenaConection.ToString());
                cmd = connection.CreateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "PROBLEMAS EN LA CON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }

}

