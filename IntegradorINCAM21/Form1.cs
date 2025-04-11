namespace IntegradorINCAM21
{
    public partial class Form1 : Form
    {
        private string datos = "";
        GuardarDatos gd = new GuardarDatos();
        public Form1()
        {
            InitializeComponent();
            gd.crearBD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            gd.guardarDatos(tLargo.Text, tAncho.Text, tGrosor.Text, tDiametro.Text, cTipoTornillo.SelectedItem.ToString(), cOpciones.SelectedItem.ToString());
        }

        private void cOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tLargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tAncho_TextChanged(object sender, EventArgs e)
        {

        }

        private void tGrosor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDiametro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cTipoTornillo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tVerDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void bVerDatos_Click(object sender, EventArgs e)
        {
            this.datos = gd.mostrarDatos();
            tVerDatos.Text = this.datos.ToString();
            MessageBox.Show($"La ubicacion de la base de datos se encuntra en {gd.dbPath}","Ubicacion BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
