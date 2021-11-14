using SoporteTecnico.Modelos.DAO;
using SoporteTecnico.Modelos.Entidades;
using SoporteTecnico.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SoporteTecnico.Controladores
{
    public class UsuarioController
    {

        TiposView vista;

        string opera = "";
        UsuarioDAO UserDao = new UsuarioDAO();
        SoporteTipo sopor = new SoporteTipo();

        public UsuarioController(TiposView view)
        {

            vista = view;


            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_guardar.Click += new EventHandler(guardar);
            vista.btn_cancelar.Click += new EventHandler(Cancelar);
          
        }

   

       


       
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            opera = "Nuevo";


        }
        private void guardar(object serder, EventArgs e)
        {

            if (vista.comboBoxtipo.Text == "")
            {

                vista.errorProvider1.SetError(vista.comboBoxtipo, "Error debe Seleccionar");
                return;
            }
            if (vista.txt_Nombrecliente.Text == "")
            {

                vista.errorProvider1.SetError(vista.txt_Nombrecliente, "Error debe Ingresar su Nombre");
                return;
            }


            sopor.tipo = vista.comboBoxtipo.Text;
            sopor.NombreCliente = vista.txt_Nombrecliente.Text;


            if (vista.rdb_reparacionCel.Text == "Reparacion")
            {
                if (vista.rdb_reparacionCel.Checked == true)
                {
                vista.rdb_mantenimiento.Enabled = false;
                sopor.Trabajo = vista.rdb_reparacionCel.Text;
                MessageBox.Show("Selecciono Reparacion");

                }
            }

            if (vista.rdb_mantenimiento.Text == "Mantenimiento")
            {
                if (vista.rdb_mantenimiento.Checked == true)
                {
                    vista.rdb_reparacionCel.Enabled = false;
                sopor.Trabajo = vista.rdb_mantenimiento.Text;
                MessageBox.Show("Selecciono Mantenimiento");
                }
            }

            bool inserto = UserDao.InsertarTipoSoporte(sopor);


            if (opera == "Nuevo")
            {
                if (inserto)
                {
                    DeshabilitarControles();
                    Limpiar();

                    MessageBox.Show("Insertado Satisfactoriamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    


                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
           

           
            



        }

        private void Cancelar(object sender, EventArgs e)
        {
            vista.Close();
        }
        private void Limpiar()
        {
            vista.comboBoxtipo.Text = "";
        }

        private void HabilitarControles()
        {
            vista.groupBoxtipo.Enabled = true;
            vista.groupBoxCel.Enabled = true;


            
            vista.btn_guardar.Enabled = true;
            vista.btn_cancelar.Enabled = true;
            
            vista.btn_nuevo.Enabled = false;
            vista.rdb_mantenimiento.Enabled = true;
            vista.rdb_reparacionCel.Enabled = true;

        }
        private void DeshabilitarControles()
        {
            vista.groupBoxtipo.Enabled = false;




            vista.btn_guardar.Enabled = false;
            vista.btn_cancelar.Enabled = false;
          
            vista.btn_nuevo.Enabled = true;

        }




    }
}
