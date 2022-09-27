using System.Linq;

namespace RepasoParcial
{
    public partial class Form1 : Form
    {
        Persona personas = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btPersona_Click(object sender, EventArgs e)
        {

            personas = new Persona(txtNombre.Text, Convert.ToInt32(txtDNI.Text),
                
                Convert.ToDateTime(txtFechaNacimiento.Text));


            if (personas.dniPersonaP < 0)
                errorProvider1.SetError(txtDNI, "No puede ser menor a cero ni decimal");
            else
                errorProvider1.SetError(txtDNI, "");


            lblDatosPersona.Text = new Persona(txtNombre.Text, Convert.ToInt32(txtDNI.Text),

                Convert.ToDateTime(txtFechaNacimiento.Text)).ToString();

        }

        private void btEdad_Click(object sender, EventArgs e)
        {
            lblMostrarEdad.Text = "La edad de la persona es: " + personas.EdadRetornar().ToString() + " años";
        }

    }
}