using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_SalaoBeleza.View;

namespace prj_SalaoBeleza
{
    public partial class btn_Agend : Form
    {
        public btn_Agend()
        {
            InitializeComponent();
        }

        private void btn_Agenda_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadClie_Click(object sender, EventArgs e)
        {
            Frm_CadClie tela_CadClie = new Frm_CadClie();
            tela_CadClie.ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_ExClie_Click_1(object sender, EventArgs e)
        {
            Frm_EditClie tela_editClie = new Frm_EditClie();
            tela_editClie.ShowDialog();
        }

        private void btn_ServiEx_Click(object sender, EventArgs e)
        {
            Frm_EditServi frm_EditServi = new Frm_EditServi();
            frm_EditServi.ShowDialog();
        }

        private void btn_Agen_Click(object sender, EventArgs e)
        {
            Frm_CadAgend tela_Agend = new Frm_CadAgend();
            tela_Agend.ShowDialog();
        }

        private void btn_AgendEx_Click(object sender, EventArgs e)
        {
            Frm_EditAgend frm_EditAgend = new Frm_EditAgend();  
            frm_EditAgend.ShowDialog(); 
        }

        private void btn_Servi_Click(object sender, EventArgs e)
        {
            Frm_CadServi frm_CadServi = new Frm_CadServi();
            frm_CadServi.ShowDialog();
        }
    }
}
