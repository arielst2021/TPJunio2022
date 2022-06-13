using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;

namespace Negocio
{
    public class NegocioUsuario
    {
        DaoUsuario usuario = new DaoUsuario();

        //recibo usu y pass y consulto si existe en el DaoUsuario -->



        public Boolean AltaUsuario(float pu)
        {
            return true;
        }
        public bool AgregarUsuario(string alias, string pass)
        {
            int cant_flias = 0;
            Usuario usu = new Usuario();
            usu.Set_alias(alias);
            usu.Set_password(pass);
            //Cue.set_email_cuenta(email);
            //Cue.set_contrasenia(contrasenia);
            //Cue.set_Dni(dni);
            //Cue.set_Alias(alias);


            DaoUsuario dao = new DaoUsuario();
            if (dao.ExisteUsuario(usu) == false)
            {
                cant_flias = dao.AgregarUsuario(usu);
            }
            if (cant_flias == 1)
            {
                return true;
            }
            else
                return false;

        }

        public bool TipoDeUsuario(string alias, string pass) // REVISAR FUNCIONAMIENTO!
        {
            DaoUsuario dao = new DaoUsuario();
            Usuario usu = new Usuario();
            usu.Set_alias(alias);
            usu.Set_password(pass);
            if (dao.ExisteUsuario(usu) == true)
            {
                //preguntar 
                if (usu.Get_perfil_id().Equals("0"))
                {
                    //
                    return false;
                }
                else
                {
                    return true;
                }

            }
            /*else if (usu.Get_password() != pass) // para que preguntar si es incorrecta la pass???
            {

                return false;
            }
            else
            {
                return usu;
            }*/
            return true;
        }


        public bool Validarnivel(string cuenta, string contrasenia)
        {

            //la funcion validar nivel revisa que la cuenta tenga como usuario "admin" ademas de 
            //una contraseña y alias correcto.
            int flag = 0;
            bool cuenta_valida = TipoDeUsuario(cuenta, contrasenia);
            if (cuenta_valida == true) { flag++; }
            if (flag == 0 && cuenta == "admin") { return true; } else return false; // cambie flag == 1 x cero
        }
    }
}
