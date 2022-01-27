using System;
using System.Drawing; //Para dibujar la posicion de las imagenes.
using System.Windows.Forms;

namespace PingPong
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        int velocidad = 15;
        int cont = 0; // Medir el puntaje.
        int puntaje = 0;

        bool arriba;
        bool izquierda;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pelota.Left > palo.Left) //Perder
            {
                timer1.Enabled = false;
                MessageBox.Show("Lograste " + puntaje.ToString() + " atajadas.");
                puntaje = 0;
                velocidad = 15;
                cont = 0;
            }

            //Rebote de la pelota contra el palo.
            if(pelota.Left + pelota.Width >= palo.Left && // Veriica que este dentro del rango de izq a derecha del palo.
               pelota.Left + pelota.Width <= palo.Left + palo.Width && // Verifica que no pase de la posicion del palo.
               pelota.Top + pelota.Height >= palo.Top && // Verifica que no se pase de la parte de arriba del palo.
               pelota.Top + pelota.Height <= pelota.Top + pelota.Height) // Verifica que no se pase de la parte de abajo del palo.
            {
                izquierda = false;
                puntaje += 1;
                this.Text = "Puntaje: " + puntaje.ToString() + ".";
                cont += 1;
                if(cont >= 5)
                {
                    velocidad += 5;
                    cont = 0;
                }
            }

            #region Movimiento de la pelota
            if (izquierda)
            {
                pelota.Left += velocidad; // Va para la derecha.
            }
            else
            {
                pelota.Left -= velocidad; // Va para la izquierda.
            }

            if (arriba)
            {
                pelota.Top += velocidad; // Va para abajo.
            }else
            {
                pelota.Top -= velocidad; // Va para arriba.
            }

            if(pelota.Top >= this.Height - 60) //Si pega en la pared de abajo.
            {
                arriba = false;
            }

            if(pelota.Top <= 0) //Si pega en la pared de arriba.
            {
                arriba = true;
            }

            if(pelota.Left <= 0) //Si pega en la pared de la izquierda.
            {
                izquierda = true;
            }           

            #endregion
        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show(); //Muestre el Owner, el propietario de la ventana.
        }

        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            palo.Top = e.Y;
        }

        private void Juego_Load(object sender, EventArgs e)
        {

            this.Text = "Puntaje: 0.";
            Random aleatorio = new Random();
            pelota.Location = new Point(0, aleatorio.Next(this.Height));
            arriba = true;
            izquierda = true;
            timer1.Enabled = true;
            puntaje = 0;

        }
    }
}
