using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAP13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Calculadora Seguro";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tipoSeguro = 0;
            if (radBasico.Checked) tipoSeguro = 1;
            if (radTerceros.Checked) tipoSeguro = 2;
            if (radTodoRiesgo.Checked) tipoSeguro = 3;

            Presupuesto p = new Presupuesto(
                txtNombre.Text, 
                tipoSeguro, 
                chkAireAcondicionado.Checked, 
                chkSistemaAudio.Checked, 
                double.Parse(txtValor.Text)
            );

            txtSalida.Text = p.CalcularSeguro();
        }
    }
}
