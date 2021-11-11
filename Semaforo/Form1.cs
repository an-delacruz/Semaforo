using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class frmSemaforo : Form
    {
        double segundos = 0;
        public frmSemaforo()
        {
            InitializeComponent();
        }

        private void tmrVerde_Tick(object sender, EventArgs e)
        {
            if (segundos == 10)
            {
                segundos = 0;
                tmrVerde.Stop();
                tmrVerdeParpadeando.Start();
                pnlVerticalVerde1.BackColor = Color.Gray;
                pnlVerticalVerde2.BackColor = Color.Gray;
            }
            else
            {
                segundos++;
                txtContador.Text = segundos.ToString();

            }
        }

        private void frmSemaforo_Load(object sender, EventArgs e)
        {
            tmrVerde.Start();
            pnlVerticalVerde1.BackColor = Color.Green;
            pnlVerticalVerde2.BackColor = Color.Green;
        }

        private void tmrVerdeParpadeando_Tick(object sender, EventArgs e)
        {
            if (segundos == 3)
            {
                segundos = 0;
                tmrVerdeParpadeando.Stop();
                tmrAmarillo.Start();
                pnlVerticalVerde1.BackColor = Color.Gray;
                pnlVerticalVerde2.BackColor = Color.Gray;
            }
            else
            {
                if (!(Math.Abs(segundos % 1) <= (Double.Epsilon * 100)))
                {
                    pnlVerticalVerde1.BackColor = Color.Green;
                    pnlVerticalVerde2.BackColor = Color.Green;
                }
                else
                {
                    pnlVerticalVerde1.BackColor = Color.Gray;
                    pnlVerticalVerde2.BackColor = Color.Gray;
                }
                segundos++;
                txtContador.Text = segundos.ToString();
            }
        }

        private void tmrAmarillo_Tick(object sender, EventArgs e)
        {
            pnlVerticalAmarillo1.BackColor = Color.Yellow;
            pnlVerticalAmarillo2.BackColor = Color.Yellow;
            if (segundos == 3)
            {
                segundos = 0;
                tmrAmarillo.Stop();
                tmrRojo.Start();
                pnlVerticalAmarillo1.BackColor = Color.Gray;
                pnlVerticalAmarillo2.BackColor = Color.Gray;
            }
            else
            {
                segundos++;
                txtContador.Text = segundos.ToString();

            }
        }

        private void tmrRojo_Tick(object sender, EventArgs e)
        {
            pnlVerticalRojo1.BackColor = Color.Red;
            pnlVerticalRojo2.BackColor = Color.Red;
            if (segundos == 3)
            {
                segundos = 0;
                tmrRojo.Stop();
                tmrVerde.Start();
                pnlVerticalRojo1.BackColor = Color.Gray;
                pnlVerticalRojo2.BackColor = Color.Gray;
            }
            else
            {
                segundos++;
                txtContador.Text = segundos.ToString();

            }
        }
    }
}
