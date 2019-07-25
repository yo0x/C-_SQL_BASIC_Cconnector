using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targil4Bonus
{
    public partial class CustomQuery : Form
    {
        string srchString;
        public CustomQuery(string SearchPara)
        {
            srchString = SearchPara;
            InitializeComponent();
        }

        private void CustomQuery_Load(object sender, EventArgs e)
        {
            dataGridView1CustomMissionsProj.DataSource = Controller.SqlCon.MissionsProByEmp(srchString);
        }
    }
}
