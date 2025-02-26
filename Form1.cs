using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_ROSALVINO
{
    public partial class Frm_Rosalvino : Form
    {
        public Frm_Rosalvino()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Padrao_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Dom_Bosco;
        }

        private void Rad_Tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Obra_Social_Dom_Bosco;
        }

        private void Rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.mqdefault;
        }

        private void Grp_Temas_Enter(object sender, EventArgs e)
        {

        }

        private void Bnt_Ativar_Click(object sender, EventArgs e)
        {
            Bnt_Ativar.Enabled = false;
            Bnt_Desativar.Enabled = true;//ativando o desativar
            Lbl_Nome.Enabled = true;


        }
    }
}
