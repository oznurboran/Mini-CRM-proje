using CRMProjeyeni.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMProjeyeni.UI
{
    public partial class TalepForm: Form
    {
        public TalepForm()
        {
            InitializeComponent();
            talepService = new TalepService();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private TalepService talepService;

        private void TalepForm_Load(object sender, EventArgs e)
        {
            taleplisteleDgv.AutoGenerateColumns = false;
            taleplisteleDgv.DataSource = talepService.TalepListele();
        }

        private void taleplisteleDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
