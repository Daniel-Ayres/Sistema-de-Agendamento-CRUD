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
    public partial class Frm_EditAgend : Form
    {
        ClienteModel clienteModel = new ClienteModel();

        FuncionarioModel funcionarioModel = new FuncionarioModel();

        ServicoModel servicoModel = new ServicoModel();

        AgendaModel agendaModel = new AgendaModel();

        string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";
        public Frm_EditAgend()
        {
            InitializeComponent();
        }

        public void Carrega_Dados()
        {
            try
            {
                dgv_Agend.DataSource = agendaModel.Chamar_Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro carregar os dados" + ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Frm_EditAgend_Load(object sender, EventArgs e)
        {

            try
            {
                dgv_Agend.DataSource = agendaModel.Chamar_Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro carregar os dados" + ex.Message);
            }


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
                            cmb_FunciEx.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
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
                            cmd_ServiEx.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
                        }
                    }
                }
            }

            //Preenchendo o ComboBox com os nomes dos clientes
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id, nome FROM clientes", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_ClienEx.Items.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("nome")));
                        }
                    }
                }
            }

        }

        private void dgv_Agend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o índice da linha é válido
            if (e.RowIndex >= 0)
            {
                // Seleciona a linha clicada e define sua primeira célula como a célula atual
                dgv_Agend.Rows[e.RowIndex].Selected = true;
                dgv_Agend.CurrentCell = dgv_Agend.Rows[e.RowIndex].Cells[0];

                // Habilita vários ComboBoxes e um DateTimePicker
                cmb_ClienEx.Enabled = true;
                cmb_FunciEx.Enabled = true;
                cmd_ServiEx.Enabled = true;
                dtp_DataAgendEx.Enabled = true;

                // Habilita dois botões
                btn_AtuAgend.Enabled = true;
                btn_ExcluirAgen.Enabled = true;


            }

            // Preenche vários textboxes e ComboBoxes com os dados da linha selecionada
            txtb_IdEx.Text = dgv_Agend.CurrentRow.Cells[0].Value.ToString();
            cmb_ClienEx.Text = dgv_Agend.CurrentRow.Cells[3].Value.ToString();
            cmb_FunciEx.Text = dgv_Agend.CurrentRow.Cells[1].Value.ToString();
            cmd_ServiEx.Text = dgv_Agend.CurrentRow.Cells[2].Value.ToString();
            dtp_DataAgendEx.Text = dgv_Agend.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_ExcluirAgen_Click(object sender, EventArgs e)
        {
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                int id = int.Parse(txtb_IdEx.Text);

                // Exibe uma mensagem de confirmação para o usuário antes de realizar a exclusão
                DialogResult result = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                //Se o botão precionado for sim entra no codigo e verica o ID , deleta a partir do id selecionado. 
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM agendamento WHERE id=@id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();
                           
                               
                            if (rowsAffected > 0)
                            {
                                //Mensage de sucesso para mostra a exclusão do agendamento
                                MessageBox.Show("Agendamento excluído com sucesso!", "Exclusão de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_ClienEx.Text = "";
                                cmb_FunciEx.Text = "";
                                cmd_ServiEx.Text = "";
                                txtb_IdEx.Clear();

                            }
                            else
                            {
                                MessageBox.Show("Não foi possível excluir o cliente.", "Exclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro: " + ex.Message, "Exclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void btn_AtuAgend_Click(object sender, EventArgs e)
        {

            // Recupera o funcionário selecionado pelo usuário a partir da combobox "cmb_FunciEx" e assim por diante nos demais
            KeyValuePair<int, string> funcionarioSelecionado = (KeyValuePair<int, string>)cmb_FunciEx.SelectedItem;
            int idFuncionario = funcionarioSelecionado.Key;

            KeyValuePair<int, string> servicoSelecionado = (KeyValuePair<int, string>)cmd_ServiEx.SelectedItem;
            int idServico = servicoSelecionado.Key;

            KeyValuePair<int, string> clienteSelecionado = (KeyValuePair<int, string>)cmb_ClienEx.SelectedItem;
            int idcliente = clienteSelecionado.Key;

            // Criação de um objeto Agenda para armazenar os dados do agendamento
            Agenda DadosAgen = new Agenda();

            DadosAgen.Dthrs_agendamento = Convert.ToDateTime(dtp_DataAgendEx.Text);


            // Exibe uma mensagem de confirmação para o usuário antes de realizar a atualização
            DialogResult result = MessageBox.Show("Você tem certeza de que deseja atualizar as informações do agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateSql = "UPDATE agendamento SET id_funcionario = @id_funcionario, id_servico = @id_servico, id_cliente = @id_cliente , dthrs_agendamento = @dthrs_agendamento  WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                        command.Parameters.AddWithValue("@id_servico", idServico);
                        command.Parameters.AddWithValue("@id_cliente", idcliente);
                        command.Parameters.AddWithValue("@dthrs_agendamento",DadosAgen.Dthrs_agendamento);
                        command.Parameters.AddWithValue("@id",txtb_IdEx.Text);
             
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações do agendamento atualizadas com sucesso.");
                            cmb_ClienEx.Text = "";
                            cmb_FunciEx.Text = "";
                            cmd_ServiEx.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar as informações do agendamento.");
                        }
                    }
                }
            }
        }
    }
}
