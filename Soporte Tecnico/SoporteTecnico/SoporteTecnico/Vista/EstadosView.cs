﻿using SoporteTecnico.Controladores;
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
    public partial class EstadosView : Form
    {
        public EstadosView()
        {
            InitializeComponent();
            EstadoController Controlador = new EstadoController(this);

        }
    }
}
