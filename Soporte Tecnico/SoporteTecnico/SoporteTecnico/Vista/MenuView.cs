using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoporteTecnico.Vista
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        TiposView Tipos;
        EstadosView VistaEstado;
        TicketView Ticc;
        DetalleView Detall;
        private void UsuariotoolStripButton_Click(object sender, EventArgs e)
        {

            if (Tipos == null)
            {
                Tipos = new TiposView();
                Tipos.MdiParent = this;
                Tipos.FormClosed += Tipos_FormClosed;
                Tipos.Show();
            }
            else
            {
                Tipos.Activate();
            }
           

        }

        private void Tipos_FormClosed(object sender, FormClosedEventArgs e)
        {

            Tipos = null;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (VistaEstado == null)
            {
                VistaEstado = new EstadosView();
                VistaEstado.MdiParent = this;
                VistaEstado.FormClosed += VistaEstado_FormClosed;
                VistaEstado.Show();
            }
            else
            {
                Tipos.Activate();
            }



        }

        private void VistaEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaEstado = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Ticc == null)
            {
                Ticc = new TicketView();
                Ticc.MdiParent = this;
                Ticc.FormClosed += Ticc_FormClosed;
                Ticc.Show();
            }
            else
            {
                Ticc.Activate();
            }
        }

        private void Ticc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ticc = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Detall == null)
            {
                Detall = new DetalleView();
                Detall.MdiParent = this;
                Detall.FormClosed += Detall_FormClosed;
                Detall.Show();
            }
            else
            {
                Tipos.Activate();
            }



        }

        private void Detall_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detall = null;
        }
    }
}
