using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
// Importamos los siguientes using
namespace Hilos
{
    public partial class Form1 : Form
    {
        // Declaramos un Hilo 
        private Thread semaforo;
        private bool isRunning;

        public Form1()
        {
            InitializeComponent();
            CambiarEstadoSemaforo("red.png"); //red.png,green.png,yellow.png
            cargarFondo();
        }
        private void cargarFondo()
        {
            // Creamos una variable temporal para cargar la imagen inicial
            string imagePath = @"C:\Users\ALEX\Documents\SEMAFORO\calle2.jpg";

            // Verifica si el archivo existe
            if (System.IO.File.Exists(imagePath))
            {
                try
                {
                    // Si ya hay una imagen cargada en el PictureBox, dispón de ella
                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                        pictureBox2.Image = null;
                    }

                    // Carga la nueva imagen
                    pictureBox2.Image = Image.FromFile(imagePath);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("No se pudo cargar la imagen. El archivo podría estar corrupto o el sistema no tiene suficiente memoria.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo un error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La imagen no se encontró en la ruta especificada.");
            }
        }

        private void CambiarEstadoSemaforo(string estado)
        {
            // Directorio donde se encuentran las imágenes del semáforo
            string directorioImagenes = @"C:\Users\ALEX\Documents\SEMAFORO\";

            // Verificar si la imagen correspondiente al estado existe
            string imagePath = Path.Combine(directorioImagenes, estado);
            if (File.Exists(imagePath))
            {
                // Cargar la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("La imagen del estado del semáforo no se encontró en la ruta especificada.");
            }
        }

        private void START_Click(object sender, EventArgs e)
        {
            if (semaforo == null || !semaforo.IsAlive) // Si no hay ningún hilo corriendo o si no hay ninguno activo
            {
                isRunning = true; // Activmaos la bandera
                semaforo = new Thread(new ThreadStart(Semaforo)); //Creamos una nueva instancia del hilo
                semaforo.Start();  // Iniciamos el hilo
            }else if (!isRunning) // Si el Hilo se detuvo
            {
                isRunning = true; // Volvemos a activar la bandera
            }
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            isRunning = false; // Apagamos la bandera
            MessageBox.Show("Apagaste el semaforo ....");
            semaforo?.Join(); // Bloqueamos el hilo 
        }
        private void Semaforo()
        {
            while(isRunning){ // Esta variable ayuda a controlar el while
                if (!isRunning) // Si no esta corriendo el semaforo
                {
                    Thread.Sleep(Timeout.Infinite); // Renaundar el hilo hasta que se indique lo contrario
                    continue; // Saltar al inicio del bucle para verificar de nuevo el estado
                    MessageBox.Show("Apagaste el semaforo ....");
                }
                // Encender luz roja
                CambiarEstadoSemaforo("red.png"); // Cambiar a luz roja
                Thread.Sleep(3000); // Mantener encendida por 3 segundos

                // Apagar luz roja, encender luz verde
                CambiarEstadoSemaforo("red.png"); // Cambiar a luz roja
                CambiarEstadoSemaforo("green.png"); // Cambiar a luz verde
                Thread.Sleep(8000); // Mantener encendida por 1 segundo

                // Apagar luz verde, encender luz amarilla
                CambiarEstadoSemaforo("green.png"); // Cambiar a luz verde
                CambiarEstadoSemaforo("yellow.png"); // Cambiar a luz amarilla
                Thread.Sleep(3000); // Mantener encendida por 3 segundos

                // Apagar luz verde
                CambiarEstadoSemaforo("red.png"); // Cambiar a luz roja
            }
        }
    }
}
