namespace CatAsServices
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buscarRa�asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarRacaForm raca = new BuscarRacaForm();
            raca.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorito favorito = new FormFavorito();

            favorito.ShowDialog();
        }
    }
}