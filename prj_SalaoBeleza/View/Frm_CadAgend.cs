using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_SalaoBeleza.Model;
using prj_SalaoBeleza.Entidades;
using MySql.Data.MySqlClient;

namespace prj_SalaoBeleza.View
{
    public partial class Frm_CadAgend : Form
    {
        ClienteModel clienteModel = new ClienteModel();

        FuncionarioModel funcionarioModel = new FuncionarioModel();

        ServicoModel servicoModel = new ServicoModel();

        string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

        public Frm_CadAgend()
        {
            InitializeComponent();
        }

        private void Frm_CadAgend_Load(object sender, EventArgs e)
        {
            //Preenchendo o ComboBox com os nomes dos funcionários
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id, nome FROM funcionarios", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_Funci.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
                        }
                    }
                }
            }

            //Preenchendo o ComboBox com os nomes dos serviços
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id, nome FROM servicos", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmd_Servi.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
                        }
                    }
                }
            }

            //Preenchendo o ComboBox com os nomes dos serviços
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id, nome FROM clientes", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_Clien.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
                        }
                    }
                }
            }

        }



        private void btn_CadAge_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> funcionarioSelecionado = (KeyValuePair<int, string>)cmb_Funci.SelectedItem;
            int idFuncionario = funcionarioSelecionado.Key;

            KeyValuePair<int, string> servicoSelecionado = (KeyValuePair<int, string>)cmd_Servi.SelectedItem;
            int idServico = servicoSelecionado.Key;

            KeyValuePair<int, string> clienteSelecionado = (KeyValuePair<int, string>)cmb_Clien.SelectedItem;
            int idcliente = clienteSelecionado.Key;

            Agenda DadosAgen = new Agenda();

            DadosAgen.Dthrs_agendamento = Convert.ToDateTime(dtp_DataAgend.Text);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("INSERT INTO agendamento (id_funcionario, id_servico , id_cliente ,dthrs_agendamento) VALUES (@id_funcionario, @id_servico, @id_cliente,@dthrs_agendamento)", connection))
                {
                    command.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                    command.Parameters.AddWithValue("@id_servico", idServico);
                    command.Parameters.AddWithValue("@id_cliente", idcliente);
                    command.Parameters.AddWithValue("@dthrs_agendamento",DadosAgen.Dthrs_agendamento);

                    

                    int result;
                    result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Dados do agendamento inseridos  com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir dados do agendamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }

}

