using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Programa.Connection;
using Programa.Modelos.Compras;
using Microsoft.Reporting.WinForms;

namespace Programa.Controller{
    
        abstract class Controller
        {
            protected String sql;
            protected MySqlConnection conection;
            protected MySqlCommandBuilder cmb;
            protected DataSet ds;
            protected MySqlDataAdapter da;
            protected MySqlCommand comando;
            //propiedades*********************************************************************************************************
            public String Sql
            {
                get { return sql; }
                set { sql = value; }
            }
            public DataSet DataSetResult
            {
                get { return ds; }
                set { ds = value; }
            }
            //contrcutor*********************************************************************************************************
            public Controller()
            {
                ds = new DataSet();
                Conexion cnn = new Conexion();
                conection = cnn.Connection1;
            }
          
            public abstract bool Guardar();
            public abstract bool Modificar();
            public abstract bool Eliminar();
       
            public virtual bool ExecuteQuery(String sqlQuery, int mensaje)//0- Guardar,1 - Modificar, -1 - Eliminar
            {//inserta,elimina  modifica
                String mensajeSalida = "Datos Guardados";
                if (mensaje > 0) { mensajeSalida = "Datos Modificados"; }
                else if (mensaje < 0) { mensajeSalida = "Datos Eliminados"; }
                bool resp = false;
                try
                {
                    conection.Open();
                    comando = new MySqlCommand(sqlQuery, conection);
                    int num = comando.ExecuteNonQuery();
                    if (num > 0)
                    {
                        resp = true;
                        MessageBox.Show(mensajeSalida, "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "PROBLEMAS CON LA TRANSACCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "PROBLEMAS CON LA TRANSACCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("" + "Error Revisar por favor", "Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conection.Close();
                return resp;
            }

		

		public DataTable ConsultarTabla()//realiza una consulta SQL y la muestra en DataSource
            {
                try
                {
                    ds.Tables.Clear();
                    da = new MySqlDataAdapter(sql, conection);
                    cmb = new MySqlCommandBuilder(da);
                    da.Fill(ds, "Consulta");
                    return DataSetResult.Tables["Consulta"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "ERROR EN LA INSTRUCCION A LA BASE DE DATOS \n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

			/*public String ConsultaReporte(String consulta,String ReporteRLC)
			{
			
			}*/

		

            public String GenerarInsertarSql(String tabla, List<Parametro> parametros )
            {
                String query = "";
                if (parametros.Count > 0)
                {
                    query = string.Format("INSERT INTO {0} ", tabla);
                    query += " (";
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        query += string.Format("{0}", parametros[i].Campo);
                        if (i < parametros.Count - 1) { query += ","; }
                    }
                    query += " )";
                    query += " value (";
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        query += string.Format("{0}", parametros[i].Valor);
                        if (i < parametros.Count - 1) { query += ","; }
                    }
                    query += " )";
                }
                else
                {
                    MessageBox.Show("No hay parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return query;
            }
            public String GenerarActualizarSql(String tabla, List<Parametro> parametros, Parametro id)
            {
                String query = "";
                if (parametros.Count > 0)
                {
                    query = string.Format("UPDATE {0} set ", tabla);
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        query += string.Format("{0} {1} {2}", parametros[i].Campo, parametros[i].Comparador, parametros[i].Valor);
                        if (i < parametros.Count - 1) { query += " , "; }
                    }
                    query += string.Format(" WHERE {0} {1} {2}", id.Campo, id.Comparador, id.Valor);
                }
                else
                {
                    MessageBox.Show("No hay parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return query;
            }
            public String GenerarEliminarSql(String tabla, Parametro id)
            {
                String query = "";
                query = string.Format("DELETE FROM {0} WHERE ", tabla);
                query += string.Format("{0} {1} {2}", id.Campo, id.Comparador, id.Valor);
                return query;
            }


        }
    }

