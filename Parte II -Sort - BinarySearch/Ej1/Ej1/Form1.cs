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

            List<Persona> personas = new List<Persona>();
            

            Persona p1 = new Persona(38576433, "Pedro");
            Persona p2 = new Persona(25734331, "Lucas");
            Persona p3 = new Persona(15676433, "Martin");

            personas.Add(p1);          
            personas.Add(p2);
            personas.Add(p3);

            lsbPrueba.Items.Add("DESORDENADO");
            foreach (Persona p in personas)
        
            {
                    lsbPrueba.Items.Add(p.ToString());
            }

           personas.Sort();

            lsbPrueba.Items.Add("ORDENADO");
            foreach (Persona p in personas)
            {
                lsbPrueba.Items.Add(p.ToString());
            }





        }
    }
}
