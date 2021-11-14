using SoporteTecnico.Modelos.DAO;
using SoporteTecnico.Modelos.Entidades;
using SoporteTecnico.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoporteTecnico.Controladores
{
   public class LoginController
    {
        LoginView vista;


        public LoginController(LoginView view)
        {
            vista = view;
            vista.btn_inicio.Click += new EventHandler(ValidarUsuario);
        }





        private void ValidarUsuario(object serder, EventArgs e)
        {

            if (vista.txt_email.Text=="")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese Email");
                vista.txt_email.Focus();
                return;

            }
            if (vista.txt_contraseña.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese Contraseña");
                vista.txt_email.Focus();
                return;

            }



            bool esvalido = false;
            UsuarioDAO useDao = new UsuarioDAO();


            Usuario user = new Usuario();

            user.Email = vista.txt_email.Text;

            user.Clave = EncriptarClave(vista.txt_contraseña.Text);



            esvalido = useDao.ValidarUsuario(user);
            
            if (esvalido)
            {
                MessageBox.Show("Usuario Correcto", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuView menu = new MenuView();/// instancia para llamar el otro formulario de menu
                vista.Hide(); // desaparecer el formulario de login
                menu.Show(); // llamando al formulario de menu


            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();





        }




    }
}
