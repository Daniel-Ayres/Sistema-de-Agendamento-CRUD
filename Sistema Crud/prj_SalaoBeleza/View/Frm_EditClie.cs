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
using MySqlX.XDevAPI;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prj_SalaoBeleza.View
{
    public partial class Frm_EditClie : Form
    {
        ClienteModel clientesmodel = new ClienteModel();
        public Frm_EditClie()
        {
            InitializeComponent();
        }



        private void Frm_EditClie_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_Clie.DataSource = clientesmodel.Chamar_Listar();

            }
            catch (Exception)
            {

                throw;
            }




        }


        private void dgv_Clie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Clie.Rows[e.RowIndex].Selected = true;
                dgv_Clie.CurrentCell = dgv_Clie.Rows[e.RowIndex].Cells[0];

                txtb_NomeEx.Enabled = true;
                txtb_CidEx.Enabled = true;
                txtb_EmailEx.Enabled = true;
                txtb_EstadoEx.Enabled = true;
                txtb_Telex.Enabled = true;
                txtb_PaisEx.Enabled = true;
                txtb_Ruaex.Enabled = true;

                btn_AtuClie.Enabled = true;
                btn_ExcluirClie.Enabled = true;
            }

            txtb_NomeEx.Text = dgv_Clie.CurrentRow.Cells[1].Value.ToString();
            txtb_CidEx.Text = dgv_Clie.CurrentRow.Cells[5].Value.ToString();
            txtb_EmailEx.Text = dgv_Clie.CurrentRow.Cells[2].Value.ToString();
            txtb_EstadoEx.Text = dgv_Clie.CurrentRow.Cells[6].Value.ToString();
            txtb_Telex.Text = dgv_Clie.CurrentRow.Cells[3].Value.ToString();
            txtb_PaisEx.Text = dgv_Clie.CurrentRow.Cells[7].Value.ToString();
            txtb_Ruaex.Text = dgv_Clie.CurrentRow.Cells[4].Value.ToString();
            txtb_Id.Text = dgv_Clie.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_ExcluirClie_Click(object sender, EventArgs e)
        {
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                int id = int.Parse(txtb_Id.Text);

                DialogResult result = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM clientes WHERE id=@id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                               
                                MessageBox.Show("Cliente excluído com sucesso!", "Exclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtb_NomeEx.Clear();
                                txtb_CidEx.Clear();
                                txtb_EmailEx.Clear();
                                txtb_EstadoEx.Clear();
                                txtb_Ruaex.Clear();
                                txtb_Telex.Clear();
                                txtb_PaisEx.Clear();
                                txtb_Id.Clear();
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

        private void btn_AtuClie_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Você tem certeza de que deseja atualizar as informações do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateSql = "UPDATE clientes SET nome = @nome, email = @email, telefone = @telefone , logradouro = @logradouro , cidade = @cidade, estado = @estado , pais = @pais WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtb_NomeEx.Text);
                        command.Parameters.AddWithValue("@email",txtb_EmailEx.Text);
                        command.Parameters.AddWithValue("@telefone", txtb_Telex.Text);
                        command.Parameters.AddWithValue("@logradouro",txtb_Ruaex.Text);
                        command.Parameters.AddWithValue("@cidade", txtb_CidEx.Text);
                        command.Parameters.AddWithValue("@estado", txtb_EstadoEx.Text);
                        command.Parameters.AddWithValue("@pais", txtb_PaisEx.Text);
                        command.Parameters.AddWithValue("@id", txtb_Id.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações do cliente atualizadas com sucesso.");
                            txtb_NomeEx.Clear();
                            txtb_CidEx.Clear();
                            txtb_EmailEx.Clear();
                            txtb_EstadoEx.Clear();
                            txtb_Ruaex.Clear();
                            txtb_Telex.Clear();
                            txtb_PaisEx.Clear();
                            txtb_Id.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar as informações do cliente.");
                        }
                    }
                }
            }

        }

    }
  }

