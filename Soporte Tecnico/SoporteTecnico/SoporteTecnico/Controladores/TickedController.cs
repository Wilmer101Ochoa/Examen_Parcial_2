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
    public class TickedController
    {
        TicketView vista;
        TickedDAO TickDao = new TickedDAO();
        Ticked tic = new Ticked();
        string operacion = "";

        public TickedController(TicketView view)
        {
            vista = view;
         
            vista.btn_generar.Click += new EventHandler(Generar);
            vista.btn_cancelar.Click += new EventHandler(Cancelar);
            
        }

        private void Cancelar(object sender, EventArgs e)
        {
            vista.Close();
        }



        private void Generar(object sender, EventArgs e)
        {
            



            vista.txt_generado.Text = GeneradorTicket();

            tic.TickedGenerado = vista.txt_generado.Text;

            bool inserto = TickDao.InsertarTickedGenerado(tic);
            vista.txt_nomClienteTicked.Text = TickDao.ConsultNombre();
            vista.txt_tipo_soporteTicked.Text = TickDao.ConsultSoporte();

            if (inserto)
            {
                MessageBox.Show("Insertado con Exito");

            }
            else
            {
                MessageBox.Show("No se Pudo Insertar");
            }

            

        }
       

        public string GeneradorTicket()
        {
            string nTicket;
            int n1, n2, n3;
            Random generator = new Random();
            n1 = generator.Next(1, 100);
            n2 = generator.Next(1, 100);
            n3 = generator.Next(1, 100);

            nTicket = n1.ToString() + n2.ToString() + n3.ToString();

            return nTicket;

        }







    }


}

