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
    public class EstadoController
    {

        EstadosView Vista;
        EstadoDAO EstadoSopor = new EstadoDAO();
        Estado soporte = new Estado();
        string operacion = "";

        public EstadoController(EstadosView view)// constructor
        {
            Vista = view;
            Vista.btn_nuevo_estado.Click += new EventHandler(Nuevo);
            Vista.btn_guardar_estado.Click += new EventHandler(Guardar);
            Vista.btn_cancelar_estado.Click += new EventHandler(Cancelar);
        }


        private void Nuevo(object sender , EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (Vista.txt_nombreCliente.Text == "")
            {
                Vista.errorProvider1.SetError(Vista.txt_nombreCliente, "Error debe Ingresar El nombre ");
                Vista.txt_nombreCliente.Focus();
                return;
            }
            if (Vista.comboBoxestadoSolicitud.Text == "")
            {
                Vista.errorProvider1.SetError(Vista.comboBoxestadoSolicitud, "Error debe Seleccionar ");
                Vista.comboBoxestadoSolicitud.Focus();
                return;
            }
            soporte.NombreCliente = Vista.txt_nombreCliente.Text;
            soporte.NombreEstado = Vista.comboBoxestadoSolicitud.Text;
            soporte.Fecha = Vista.dateTimePicker1.Value;

            if (operacion == "Nuevo")
            {
                bool inserto = EstadoSopor.InsertarNuevoEstado(soporte);
                if (inserto)
                {
                    MessageBox.Show("Cliente Creado Exitosamente");

                }
                else
                {
                    MessageBox.Show("Cliente no se puede Insertar");
                }

            }


        }
        private void Cancelar(object sender, EventArgs e)
        {
            Vista.Close();
        }

        private void HabilitarControles()
        {
            Vista.dateTimePicker1.Enabled = true;
            Vista.comboBoxestadoSolicitud.Enabled = true;
            Vista.txt_nombreCliente.Enabled = true;

            Vista.btn_guardar_estado.Enabled = true;
            Vista.btn_cancelar_estado.Enabled = true;

            
            Vista.btn_nuevo_estado.Enabled = false;
            






        }




    }
}
