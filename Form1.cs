using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaBeca
{
    public partial class frmNotas : Form
    {

        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        public void ingresar()
        {
            double nota = 0;
            string condicion, porcentajeBeca;

            nota = Convert.ToDouble(txtIngresoNota.Text);

                if (nota < 7)
                    {
                condicion = "Reprobado";
                    }
                else
                {
                condicion = "Aprobado";
                }
            switch (nota)
            {
                case 10:
                    porcentajeBeca = "50%";
                    break;
                case 9:
                    porcentajeBeca = "30%";
                    break;
                case 8:
                    porcentajeBeca = "10%";
                    break;
                default:
                    porcentajeBeca = "0%";
                    break;

            }
            txtCondicion.Text = condicion.ToString();
            txtBeca.Text = porcentajeBeca.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtIngresoNota.Clear();
            txtCondicion.Clear();
            txtIngresoNota.Clear();
        }
    }
}
