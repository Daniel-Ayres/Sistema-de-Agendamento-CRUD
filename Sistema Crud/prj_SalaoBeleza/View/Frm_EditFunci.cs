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
    public partial class Frm_EditFunci : Form
    {

        FuncionarioModel funcionariosmodel = new FuncionarioModel();
        public Frm_EditFunci()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_EditFunci_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_Funci.DataSource = funcionariosmodel.Chamar_Listar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgv_Funci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Funci.Rows[e.RowIndex].Selected = true;
                dgv_Funci.CurrentCell = dgv_Funci.Rows[e.RowIndex].Cells[0];

                txtb_NomeFunEx.Enabled = true;
                txtb_CargoFunEx.Enabled = true;
                txtb_TelEx.Enabled = true;
                txtb_UsuEx.Enabled = true;
                txtb_SenhaEx.Enabled = true;
             

                btn_AtuFun.Enabled = true;
                btn_ExcluirFun.Enabled = true;
            }

            txtb_IdEx.Text = dgv_Funci.CurrentRow.Cells[0].Value.ToString();
            txtb_NomeFunEx.Text = dgv_Funci.CurrentRow.Cells[1].Value.ToString();
            txtb_CargoFunEx.Text = dgv_Funci.CurrentRow.Cells[2].Value.ToString();
            txtb_TelEx.Text = dgv_Funci.CurrentRow.Cells[3].Value.ToString();
            txtb_UsuEx.Text = dgv_Funci.CurrentRow.Cells[4].Value.ToString();
            txtb_SenhaEx.Text = dgv_Funci.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void btn_ExcluirFun_Click(object sender, EventArgs e)
        {

            // Dados de conexão com o banco de dados
            string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

            int id = int.Parse(txtb_IdEx.Text);

            DialogResult result = MessageBox.Show("Deseja realmente excluir este funcionario?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM funcionarios WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Funcionario excluído com sucesso!", "Exclusão de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtb_NomeFunEx.Clear();
                            txtb_CargoFunEx.Clear();
                            txtb_TelEx.Clear();
                            txtb_UsuEx.Clear();
                            txtb_SenhaEx.Clear();
                            txtb_IdEx.Clear();
                          
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir do Funcionario.", "Exclusão de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Exclusão de funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_AtuFun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza de que deseja atualizar as informações do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateSql = "UPDATE funcionarios SET nome = @nome, cargo = @cargo, telefone = @telefone ,  usuario = @usuario, senha = @senha WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtb_NomeFunEx.Text);
                        command.Parameters.AddWithValue("@cargo", txtb_CargoFunEx.Text);
                        command.Parameters.AddWithValue("@telefone", txtb_TelEx.Text);
                        command.Parameters.AddWithValue("@usuario", txtb_UsuEx.Text);
                        command.Parameters.AddWithValue("@senha", txtb_SenhaEx.Text);
                        command.Parameters.AddWithValue("@id", txtb_IdEx.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações do cliente atualizadas com sucesso.");
                            txtb_NomeFunEx.Clear();
                            txtb_CargoFunEx.Clear();
                            txtb_TelEx.Clear();
                            txtb_UsuEx.Clear();
                            txtb_SenhaEx.Clear();
                            txtb_IdEx.Clear();

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

