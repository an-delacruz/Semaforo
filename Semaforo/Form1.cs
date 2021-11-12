using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;


namespace Semaforo
{
    public partial class frmSemaforo : Form
    {
        double segundos = 1; //Conteo de segundos
        bool sentido = true; //Bandera para indicar que sentido es el actual, true = vertical, false = horizontal 
        bool Preventivas = true; //Bandera para indicar si es necesario prender/apagar las preventivas 
        PrivateFontCollection privateFont = new PrivateFontCollection(); //Objeto para la creación de un font externo y se aplicado al label del contador.
        bool verdeActivo; //Bandera para indicar si el color verde esta activo
        bool verdeParpActivo = false; //Bandera para indicar si el verde parpadeando esta activo
        bool amarilloActivo = false; //Bandera para indicar si el amarillo esta activo
        bool rojoActivo = false; //Bandera para indicar si el rojo esta activo
        bool preventivasActivo = false; //Bandera para indicar si las preventivas estan activas

        public frmSemaforo()
        {
            InitializeComponent();
        }

        private void tmrVerde_Tick(object sender, EventArgs e)
        {

            if (sentido)
            {
                picVerticalArriba.Image = Properties.Resources.verde_arriba_vertical;
                picVerticalAbajo.Image = Properties.Resources.verde_abajo_vertical;
            }
            else
            {
                picHorizontalDerecha.Image = Properties.Resources.verde_horizontal_derecho;
                picHorizontalIzquierda.Image = Properties.Resources.verde_horizantal_izquierdo;
            }
            txtContador.ForeColor = Color.LimeGreen;
            if (segundos == 10.5)
            {
                segundos = 0.5;
                tmrVerde.Stop();
                verdeActivo = false;
                verdeParpActivo = true;
                tmrVerdeParpadeando.Start();
                if (sentido)
                {
                    picVerticalArriba.Image = Properties.Resources.apagado_vertical;
                    picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                }
                else
                {
                    picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                    picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                }
                txtContador.ForeColor = Color.White;
            }
            else
            {
                segundos = segundos + 0.5;

                if (esEntero(segundos)) { txtContador.Text = segundos.ToString(); }
            }
        }

        private void frmSemaforo_Load(object sender, EventArgs e)
        {
            privateFont.AddFontFile("C:\\Users\\anton\\source\\repos\\Semaforo\\Semaforo\\Resources\\Seven Segment.ttf");
            //privateFont.AddFontFile(@"\\Resources\\Seven Segment.ttf");
            txtContador.Font = new Font(privateFont.Families[0], txtContador.Font.Size);
            txtContador.Text = "0";

        }

        private void tmrVerdeParpadeando_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 0.5;

            if (segundos == 3.5)
            {
                segundos = 0.5;
                tmrVerdeParpadeando.Stop();
                verdeParpActivo = false;
                amarilloActivo = true;
                tmrAmarillo.Start();
                if (sentido)
                {
                    picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                    picVerticalArriba.Image = Properties.Resources.apagado_vertical;
                }
                else
                {
                    picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                    picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                }
                txtContador.ForeColor = Color.White;
            }
            else
            {
                if(!esEntero(segundos))
                {
                    txtContador.ForeColor = Color.White;
                    if (sentido)
                    {
                        picVerticalArriba.Image = Properties.Resources.apagado_vertical;
                        picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                    }
                    else
                    {
                        picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                        picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                    }
                }
                else
                {
                    txtContador.Text = segundos.ToString();
                    txtContador.ForeColor = Color.LimeGreen;
                    if (sentido)
                    {
                        picVerticalArriba.Image = Properties.Resources.verde_arriba_vertical;
                        picVerticalAbajo.Image = Properties.Resources.verde_abajo_vertical;
                    }
                    else
                    {
                        picHorizontalDerecha.Image = Properties.Resources.verde_horizontal_derecho;
                        picHorizontalIzquierda.Image = Properties.Resources.verde_horizantal_izquierdo;
                    }

                }
                if (esEntero(segundos)) { txtContador.Text = segundos.ToString(); }
            }
        }

        private void tmrAmarillo_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 0.5;
            txtContador.ForeColor = Color.Yellow;
            if (sentido)
            {
                picVerticalAbajo.Image = Properties.Resources.amarillo_vertical;
                picVerticalArriba.Image = Properties.Resources.amarillo_vertical;
            }
            else
            {
                picHorizontalDerecha.Image = Properties.Resources.amarillo_horizontal;
                picHorizontalIzquierda.Image = Properties.Resources.amarillo_horizontal;
            }
            if (segundos == 3.5)
            {
                segundos = 0.5;
                tmrAmarillo.Stop();
                amarilloActivo = false;
                rojoActivo = true;
                tmrRojo.Start();
                if (sentido)
                {
                    picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                    picVerticalArriba.Image = Properties.Resources.apagado_vertical;

                }
                else
                {
                    picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                    picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                }
                txtContador.ForeColor = Color.White;
            }
            else
            {
                if (esEntero(segundos)) { txtContador.Text = segundos.ToString(); }
            }
        }

        private void tmrRojo_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 0.5;
            if (sentido)
            {
                picVerticalAbajo.Image = Properties.Resources.rojo_vertical_abajo;
                picVerticalArriba.Image = Properties.Resources.Rojo_vertical_arriba;
            }
            else
            {
                picHorizontalDerecha.Image = Properties.Resources.rojo_horizontal_derecho;
                picHorizontalIzquierda.Image = Properties.Resources.rojo_horizontal_izquierdo;
            }
            txtContador.ForeColor = Color.Red;
            if (segundos == 2.5)
            {
                segundos = 0.5;
                tmrRojo.Stop();
                rojoActivo = false;
                verdeActivo = true;
                tmrVerde.Start();
                sentido = !sentido;
                txtContador.ForeColor = Color.White;
                if (sentido)
                {
                    picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                    picVerticalArriba.Image = Properties.Resources.apagado_vertical;

                }
                else
                {
                    picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                    picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                }
            }
            else
            {
                if (esEntero(segundos)) { txtContador.Text = segundos.ToString(); }
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (verdeParpActivo)
            {
                tmrVerdeParpadeando.Start();
            }
            else if (amarilloActivo)
            {
                tmrAmarillo.Start();
            }
            else if (rojoActivo)
            {
                tmrRojo.Start();
            }
            else if (preventivasActivo)
            {
                tmrPreventivas.Start();
            }
            else
            {
                verdeActivo = true;
                tmrVerde.Start();
                preventivasActivo = false;
                txtContador.ForeColor = Color.LimeGreen;
                if (sentido)
                {
                    picVerticalArriba.Image = Properties.Resources.verde_arriba_vertical;
                    picVerticalAbajo.Image = Properties.Resources.verde_abajo_vertical;
                    picHorizontalDerecha.Image = Properties.Resources.rojo_horizontal_derecho;
                    picHorizontalIzquierda.Image = Properties.Resources.rojo_horizontal_izquierdo;
                }
                else
                {
                    picHorizontalDerecha.Image = Properties.Resources.verde_horizontal_derecho;
                    picHorizontalIzquierda.Image = Properties.Resources.verde_horizantal_izquierdo;
                    picVerticalArriba.Image = Properties.Resources.Rojo_vertical_arriba;
                    picVerticalAbajo.Image = Properties.Resources.rojo_vertical_abajo;
                }
            }
            if (esEntero(segundos)) { txtContador.Text = segundos.ToString(); }
        }

        private void btnPreventivas_Click(object sender, EventArgs e)
        {
            Detener();
            tmrPreventivas.Start();
            preventivasActivo = true;
        }
        void Detener()
        {
            sentido = true;
            tmrVerde.Stop();
            tmrRojo.Stop();
            tmrAmarillo.Stop();
            tmrVerdeParpadeando.Stop();
            tmrPreventivas.Stop();
            verdeActivo = false;
            verdeParpActivo = false;
            amarilloActivo = false;
            rojoActivo = false;
            preventivasActivo = false;
            Preventivas = true;
            picVerticalArriba.Image = Properties.Resources.apagado_vertical;
            picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
            picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
            picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
            segundos = 1;
            txtContador.Text = "0";
            txtContador.ForeColor = Color.White;
        }
        private void tmrPreventivas_Tick(object sender, EventArgs e)
        {

            if (Preventivas)
            {
                picVerticalArriba.Image = Properties.Resources.amarillo_vertical;
                picVerticalAbajo.Image = Properties.Resources.amarillo_vertical;
                picHorizontalDerecha.Image = Properties.Resources.amarillo_horizontal;
                picHorizontalIzquierda.Image = Properties.Resources.amarillo_horizontal;
                Preventivas = false;
                txtContador.ForeColor = Color.Yellow; 
            }
            else
            {
                picVerticalArriba.Image = Properties.Resources.apagado_vertical;
                picVerticalAbajo.Image = Properties.Resources.apagado_vertical;
                picHorizontalDerecha.Image = Properties.Resources.apagado_horizontal;
                picHorizontalIzquierda.Image = Properties.Resources.apagado_horizontal;
                Preventivas = true;
                txtContador.ForeColor = Color.White;
            }
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            Detener();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pausar();
        }
        void Pausar()
        {
            tmrVerde.Stop();
            tmrRojo.Stop();
            tmrAmarillo.Stop();
            tmrVerdeParpadeando.Stop();
            tmrPreventivas.Stop();
        }
        public bool esEntero(double valor)
        {
            if (valor == (int)valor) return true;
            else return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
