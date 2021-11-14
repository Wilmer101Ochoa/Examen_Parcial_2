using SoporteTecnico.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoporteTecnico.Vista
{
    public partial class TicketView : Form
    {
        public TicketView()
        {
            InitializeComponent();
            TickedController controlador = new TickedController(this);



        }

        


    }
}
