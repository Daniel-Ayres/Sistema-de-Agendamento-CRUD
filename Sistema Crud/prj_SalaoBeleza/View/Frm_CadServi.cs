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

namespace prj_SalaoBeleza.View
{
    public partial class Frm_CadServi : Form
    {
        public Frm_CadServi()
        {
            InitializeComponent();
        }

        private void btn_CadServi_Click(object sender, EventArgs e)
        {
            try
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                // Dados do cliente a serem inseridos

                Serviço DadosServi = new Serviço();


                DadosServi.Nome = txtb_NomeServ.Text;
                DadosServi.Descricao = txtb_Desc.Text;
                DadosServi.Hrs_media_gasta = Convert.ToDateTime(dtp_HrsMed.Text);




                // Comando SQL para inserir os dados
                string query = "INSERT INTO servicos (nome, descricao, hrs_media_gasta ) VALUES (@nome, @descricao, @hrs_media_gasta )";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", DadosServi.Nome);
                        command.Parameters.AddWithValue("@descricao", DadosServi.Descricao);
                        command.Parameters.AddWithValue("@hrs_media_gasta", DadosServi.Hrs_media_gasta);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados do serviço inseridos com sucesso!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir dados do serviço no banco de dados: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_HrsMed.Format = DateTimePickerFormat.Time;
            dtp_HrsMed.ShowUpDown = true;
        }
    }
}
