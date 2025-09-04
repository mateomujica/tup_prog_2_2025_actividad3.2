using Ej1.Models;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            lsbPrueba.Items.Clear();

            IFigura rectangulo = new Rectangulo(10, 10);
            IFigura ciruclo = new Circulo(5);
            Rectangulo cuadrado = new Cuadrado (10);

            lsbPrueba.Items.Add(ciruclo.ToString());
            lsbPrueba.Items.Add(rectangulo.ToString());
            lsbPrueba.Items.Add (cuadrado.ToString());
        }
    }
}
