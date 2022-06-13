using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Dao
{
    class Conexion
    {
        string RutaAyti = @"Data Source=localhost\sqlexpress;Initial Catalog=ecomerce_ayti;Integrated Security=True";

        public Conexion()
        {
            // TODO: Agregar aquí la lógica del constructor
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(RutaAyti);
            try
            {
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
        
        private SqlDataAdapter ObtenerAdaptador(string consulta, SqlConnection cn)
        {
            SqlDataAdapter adap;
            try
            {
                adap = new SqlDataAdapter(consulta,cn);
                return adap;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(string nombreTabla, string sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(sql, Conexion);
            adp.Fill(ds, nombreTabla);
            Conexion.Close();
            return ds.Tables[nombreTabla];
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string nombreSP)
        {
            //Tira error cuando le das a el boton eliminar.
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        
        public Boolean Existe(string consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())  // con READ quiere decir que ?
            {
                estado = true;
            }
            return estado;
        }

        public int ObtenerMaximo(string consulta)
        {
            int max = 0;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                max = Convert.ToInt32(datos[0].ToString());
            }
            return max;
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "Select * From Productos");
        }



    }

}

