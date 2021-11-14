using SoporteTecnico.Modelos.DAO;
using SoporteTecnico.Modelos.Entidades;
using SoporteTecnico.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.Controladores
{
    class DetalleController
    {
        DetalleView vista;
        DetalleDAO Detalle = new DetalleDAO();
        Detalle Detall = new Detalle();


        public DetalleController(DetalleView view)
        {
            vista = view;

            vista.btn_visualizar.Click += new EventHandler(visualizar);

        }

        private void visualizar(object sender, EventArgs e)
        {
            vista.dataGridViewVisual.DataSource = Detalle.GetUsuarios();





        }





    }
}
