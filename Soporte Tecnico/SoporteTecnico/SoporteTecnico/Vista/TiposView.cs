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
    public partial class TiposView : Form
    {
        public TiposView()
        {
            InitializeComponent();
            UsuarioController controller = new UsuarioController(this);





        }
    }
}
