using MySql.Data.MySqlClient;
using prj_SalaoBeleza.Model;
using prj_SalaoBeleza.Entidades;
using prj_SalaoBeleza.View;

namespace prj_SalaoBeleza
{
    public partial class Frm_Login : Form
    {
        UsuarioModel ConectMode = new UsuarioModel();
        Usuario usuario = new Usuario();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            usuario.LoginUsuario1 = txtb_Nome.Text;
            usuario.UsSenha1 = txtb_Senha.Text;

            bool conector = ConectMode.confirma_login(usuario);

            if (conector == true)
            {
                MessageBox.Show("ACESSO AO SISTEMA FOI LIBERADO!!! ");

                btn_Agend TelaPrincipal = new btn_Agend();
                TelaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou Senha INCORRETOS , TENTE NOVAMENTE !!! ");
            }
        
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CadUse_Click(object sender, EventArgs e)
        {
            Frm_CadFunci frm_CadFunci= new Frm_CadFunci();
            frm_CadFunci.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_EditFunci frm_EditFunci = new Frm_EditFunci();
            frm_EditFunci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
