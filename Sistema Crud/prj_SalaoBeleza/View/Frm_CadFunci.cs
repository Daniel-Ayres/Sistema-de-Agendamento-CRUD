using MySql.Data.MySqlClient;
using prj_SalaoBeleza.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prj_SalaoBeleza.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace prj_SalaoBeleza.View
{
    public partial class Frm_CadFunci : Form
    {
        public Frm_CadFunci()
        {
            InitializeComponent();
        }

        private void btn_CadFun_Click(object sender, EventArgs e)
        {

            try
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                // Dados do cliente a serem inseridos
               
                Funcionario DadosFun = new Funcionario();

                DadosFun.Nome = txtb_NomFun.Text;
                DadosFun.Cargo = txtb_NomCarg.Text;
                DadosFun.Telefone = txtb_TelFun.Text;
                DadosFun.Usuario = txtb_UsuFun.Text;
                DadosFun.Senha = txtb_SenFun.Text;
              


                // Comando SQL para inserir os dados
                string query = "INSERT INTO funcionarios (nome, cargo, telefone, usuario, senha ) VALUES (@nome, @cargo, @telefone , @usuario , @senha)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", DadosFun.Nome);
                        command.Parameters.AddWithValue("@cargo", DadosFun.Cargo);
                        command.Parameters.AddWithValue("@telefone", DadosFun.Telefone);
                        command.Parameters.AddWithValue("@usuario", DadosFun.Usuario);
                        command.Parameters.AddWithValue("@senha", DadosFun.Senha);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados do funcionario inseridos com sucesso!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir dados do funcionario no banco de dados: " + ex.Message);
            }
        }
    }
 }

