using Ej3.Models;

namespace Ej3
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

            IFigura rectangulo = new Rectangulo(10, 10);
            IFigura rectangulo2 = new Rectangulo(5, 5);
            IFigura circulo = new Circulo(10);
            IFigura circulo2 = new Circulo(5);
            Rectangulo cuadrado = new Cuadrado(15);
            Rectangulo cuadrado2 = new Cuadrado(10);


            figuras.Add(rectangulo);
            figuras.Add(rectangulo2);
            figuras.Add(circulo);
            figuras.Add(circulo2);
            figuras.Add(cuadrado);
            figuras.Add(cuadrado2);

            lsbPrueba.Items.Add("Desordenado");
            foreach (IFigura f in figuras)
            {               
                lsbPrueba.Items.Add(f);
            }

            figuras.Sort();

            lsbPrueba.Items.Add("Ordenado: ");
            foreach (IFigura f in figuras)
            {               
                lsbPrueba.Items.Add(f);
            }
        }
    }
}
