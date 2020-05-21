using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroItem : Form
    {
        ItemDAL itemDAL;
        public frmCadastroItem()
        {
            InitializeComponent();
            itemDAL = new ItemDAL();
        }

        private List<string> RecuperarValoresParaOComboBox()
        {
            var genero = itemDAL.RecuperarNomesGeneros();
            return genero;
        }

        private void cmbGenero1_MouseClick(object sender, MouseEventArgs e)
        {
            var generosFilme = RecuperarValoresParaOComboBox();
            cmbGenero1.DataSource = generosFilme;
        }
    }
}
