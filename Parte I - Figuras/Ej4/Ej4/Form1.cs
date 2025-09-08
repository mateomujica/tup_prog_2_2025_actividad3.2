using Ej4.Models;

namespace Ej4
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

            List<IFigura> figuras = new List<IFigura>();

            Figura rectangulo = new Rectangulo(8, 6);
            Figura circulo = new Circulo(10);
            Figura cuadrado = new Cuadrado(5);

            figuras.Add(rectangulo);
            figuras.Add(circulo);
            figuras.Add(cuadrado);

            lsbPrueba.Items.Add("DESORDENADO");

            foreach (IFigura f in figuras)
            {
                lsbPrueba.Items.Add(f);
            }

            figuras.Sort();

            lsbPrueba.Items.Add("ORDENADO P/AREA");

            foreach (IFigura f in figuras)
            {
                lsbPrueba.Items.Add(f);
            }

        }
    }
}
