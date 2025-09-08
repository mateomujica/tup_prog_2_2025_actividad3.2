using Ej2.Models;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            lsbPrueba.Items.Clear();

            lsbPrueba.Items.Add(new Cuadrado(3).ToString());
            lsbPrueba.Items.Add(new Cuadrado(5).ToString());
            lsbPrueba.Items.Add(new Rectangulo(5, 5).ToString());
                
        }
    }
}
