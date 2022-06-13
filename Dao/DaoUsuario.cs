using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    public class DaoUsuario
    {
        Conexion Datos = new Conexion();
        //y aca recibo de negocio los datos y genero la consulta con un SP o SQLcommand

        //  FUNCIONAL PARA CREAR USUARIOS 
        public Usuario GetUsuario(Usuario usu)
        {
         DataTable tabla = Datos.ObtenerTabla("Usuarios", "Select * from Usuarios where Dni=" + usu.Get_cliente_dni());
         // no acepta null si pregunto con un if 
         usu.Set_alias(tabla.Rows[0][1].ToString());
         usu.Set_perfil_id(tabla.Rows[0][0].ToString());
         usu.Set_password (tabla.Rows[0][2].ToString());               
         return usu;
        }
                
        public bool ExisteUsuario(Usuario usu)
        {
           string consulta = "Select * from usuarios where usu_alias='"+ usu.Get_alias() +"'"; 
            return Datos.Existe(consulta);
        }

        public DataTable GetTablaUsuarios() // listo
        {
            // List<Usuario> lista = new List<Usuario>();
            DataTable tabla = Datos.ObtenerTabla("usuarios", "Select * from usuarios");
            return tabla;
        }
        
        public int EliminarCliente(Usuario usu) // listo
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuarioEliminar(ref comando, usu);
            return Datos.EjecutarProcedimientoAlmacenado(comando, "spEliminarUsuario");
        }

        public int AgregarUsuario(Usuario usu)
        {

            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuarioAgregar(ref comando, usu);
            return Datos.EjecutarProcedimientoAlmacenado(comando, "spAgregarUsuario");
        }

        private void ArmarParametrosUsuarioEliminar(ref SqlCommand Comando, Usuario usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@usu_cliente_dni", SqlDbType.Int);
            SqlParametros.Value = usu.Get_cliente_dni();
        }
            

        private void ArmarParametrosUsuarioAgregar(ref SqlCommand Comando, Usuario usu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@usu_cliente_dni", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_cliente_dni();
            SqlParametros = Comando.Parameters.Add("@usu_perfil_id", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_perfil_id();
            SqlParametros = Comando.Parameters.Add("@usu_password", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_password();
            SqlParametros = Comando.Parameters.Add("@usu_alias ", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_alias();
            SqlParametros = Comando.Parameters.Add("@usu_estado", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_estado();
            SqlParametros = Comando.Parameters.Add("@usu_nombre", SqlDbType.VarChar);
            SqlParametros.Value = usu.Get_nombre();


        }
            
    }
}
