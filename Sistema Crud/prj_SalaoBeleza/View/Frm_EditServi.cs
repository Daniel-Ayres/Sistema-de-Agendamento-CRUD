using prj_SalaoBeleza.Model;
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
using MySql.Data.MySqlClient;

namespace prj_SalaoBeleza.View
{
    public partial class Frm_EditServi : Form
    {
        ServicoModel servicoModel = new ServicoModel();
        public Frm_EditServi()
        {
            InitializeComponent();
        }

        private void Frm_EditServi_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_Servi.DataSource = servicoModel.Chamar_Listar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgv_Servi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Servi.Rows[e.RowIndex].Selected = true;
                dgv_Servi.CurrentCell = dgv_Servi.Rows[e.RowIndex].Cells[0];

                txtb_NomeServiEx.Enabled = true;
                dtp_HrsMed.Enabled = true;
                txtb_DescEx.Enabled = true;
            

                btn_AtuSer.Enabled = true;
                btn_ExcluirSer.Enabled = true;
            }

            txtb_IdEx.Text = dgv_Servi.CurrentRow.Cells[0].Value.ToString();
            txtb_NomeServiEx.Text = dgv_Servi.CurrentRow.Cells[1].Value.ToString();
            txtb_DescEx.Text = dgv_Servi.CurrentRow.Cells[2].Value.ToString();
            dtp_HrsMed.Text = dgv_Servi.CurrentRow.Cells[3].Value.ToString();







        }

        private void btn_ExcluirSer_Click(object sender, EventArgs e)
        {
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                int id = int.Parse(txtb_IdEx.Text);

                DialogResult result = MessageBox.Show("Deseja realmente excluir este serviço?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM servicos WHERE id=@id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {

                                MessageBox.Show("Serviço excluído com sucesso!", "Exclusão de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtb_NomeServiEx.Clear();
                                txtb_DescEx.Clear();
                                txtb_IdEx.Clear();

                            }

                            else
                            {
                                MessageBox.Show("Não foi possível excluir o serviço.", "Exclusão de serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                         }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro: " + ex.Message, "Exclusão de serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void btn_AtuSer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza de que deseja atualizar as informações do serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateSql = "UPDATE servicos SET nome = @nome, descricao = @descricao  WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtb_NomeServiEx.Text);
                        command.Parameters.AddWithValue("@descricao", txtb_DescEx.Text);
                        command.Parameters.AddWithValue("@id", txtb_IdEx.Text);
                        

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações do serviço atualizadas com sucesso.");
                            txtb_NomeServiEx.Clear();
                            txtb_DescEx.Clear();
                            txtb_IdEx.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar as informações do serviço.");
                        }
                    }
                }
            }

        }

    }
}

