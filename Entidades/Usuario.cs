using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Usuario
    {
        private string usu_cliente_dni;
        private string usu_perfil_id;
        private string usu_password;
        private string usu_alias;
        private string usu_nombre;
        private string usu_estado;

        //constructor
        public Usuario()
        {

        }
        
        // setters
        public void Set_cliente_dni(string cli_dni)
        {
            usu_cliente_dni = cli_dni; 
        }
        public void Set_perfil_id(string perfil_id)
        {
            usu_perfil_id = perfil_id;
        }
        public void Set_password(string pass)
        {
            usu_password = pass;
        }
        public void Set_alias(string alias)
        {
            usu_alias = alias;
        }
        public void Set_nombre(string nombre)
        {
            usu_nombre = nombre;
        }
        public void Set_estado(string estado)
        {
            usu_estado = estado;
        }
        // getters
        public string Get_cliente_dni()
        {
            return usu_cliente_dni;
        }
        public string Get_perfil_id()
        {
            return usu_perfil_id;
        }
        public string Get_password()
        {
            return usu_password;
        }
        public string Get_alias()
        {
            return usu_alias;
        }
        public string Get_nombre()
        {
            return usu_nombre;
        }
        public string Get_estado()
        {
            return usu_estado;
        }

    } 
}
