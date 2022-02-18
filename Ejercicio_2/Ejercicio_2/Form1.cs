namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Definir los arreglos y los contadores que se necesitarán para guardar los nombres y las edades.
        string[] ArregloNombres = new string[5];
        int[] ArregloEdades = new int[5];
        int Contador1 = -1;
        int Contador2 = -1;

        private void GuardarNombreButton_Click(object sender, EventArgs e)
        {
            //Guardar en el arreglo los nombres ingresados.
            Contador1 = Contador1 + 1;
            ArregloNombres[Contador1] = NombreTextBox.Text;
        }

        private void GuardarEdadButton_Click(object sender, EventArgs e)
        {
            //Guardar en el arreglo las edades ingresadas.
            Contador2 = Contador2 + 1;
            ArregloEdades[Contador2] = Convert.ToInt32(EdadTextBox.Text);
        }

        private void MostrarLitadoButton_Click(object sender, EventArgs e)
        {
            //Ciclo para mostrar los nombres y las edades en el combobox.
            for (int i = 0; i < ArregloNombres.Length; i++)
            {
                ListadoComboBox.Items.Add(ArregloNombres[i] + " " + ArregloEdades[i] + " años ");

            }
        }
    }
}