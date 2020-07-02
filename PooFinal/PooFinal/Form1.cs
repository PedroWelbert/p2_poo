using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooFinal
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ferramenta ferr = new Ferramenta();
            ferr.CodEquipamento = 111;
            ferr.Descricao = "Descrição da Ferramenta";

            Funcionario func = new Funcionario();
            func.Nome = "Gandalf";
            func.CodFunc = 1;
            func.Ferramenta = ferr;

            func.imprimirDados();

        }

        private void btnYoutuberVideo_Click(object sender, EventArgs e)
        {
            Video vid1 = new Video();
            vid1.Titulo = "Primeiro Vídeo";
            vid1.Duracao = 15.50;

            Video vid2 = new Video();
            vid2.Titulo = "Segundo Vídeo";
            vid2.Duracao = 30.50;

            Youtuber yout = new Youtuber();
            yout.Nome = "Felipe Neto";
            yout.Canal = "Aquele lá...";
            yout.Videos.Add(vid1); // erro?
            yout.Videos.Add(vid2);

            yout.imprimirDados();
        }
    }
}
