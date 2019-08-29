using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.PL
{
    public partial class CarListForm : Form
    {
        BL.Car_Management carman = new BL.Car_Management();
        public CarListForm()
        {
            InitializeComponent();
            this.dgvshowcars.DataSource = carman.GET_ALL_CARS();
        }

        private void dgvshowcars_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
