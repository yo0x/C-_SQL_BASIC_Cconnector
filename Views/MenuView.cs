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
    public partial class MenuView : Form
    {
        bool SrvOn = false;
        BindingSource bSo = new BindingSource();

        public MenuView()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Button4ConnectToSrv_Click(object sender, EventArgs e)
        {
            if (!SrvOn)
            {
                button4ConnectToSrv.Text = "Disconnect from Server";
                Controller.SqlCon.sqlConToSrv();
                label2SrvStatus.Text = "Connected to 212.117.143.82";
                SrvOn = true;
            }
            else
            {
                button4ConnectToSrv.Text = "Connect to Server";
                Controller.SqlCon.CloseConn();
                label2SrvStatus.Text = "Disconnected from 212.117.143.82";
                SrvOn = false;
            }


        }

        private void Button1ShowAllEmpQ_Click(object sender, EventArgs e)
        {

            if (SrvOn)
            {
                bSo.DataSource = Controller.SqlCon.ShowAllEmployees();
                dataGridView1DataPro4u.DataSource = bSo;
            }
            else
            {
                MessageBox.Show("Connection Error",
    "Please connect to Host",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
            }

        }

        private void Button3UpdateSalaryBy5_Click(object sender, EventArgs e)
        {

            if (SrvOn)
            {
                bSo.DataSource = Controller.SqlCon.IncSalary5();
                bSo.DataSource = Controller.SqlCon.ShowAllEmployees();
                dataGridView1DataPro4u.DataSource = bSo;
            }
            else
            {
                MessageBox.Show("Connection Error",
    "Please connect to Host",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
            }

        }

        private void Button2SearchEmpById_Click(object sender, EventArgs e)
        {
            if (SrvOn)
            {
                updateData();
                dataGridView1DataPro4u.DataSource = Controller.SqlCon.SearchEmpById(Convert.ToInt32(textBox1SearchEmpById.Text));
            }
            else
            {
                MessageBox.Show("Connection Error",
    "Please connect to Host",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
            }

        }

        private void DataGridView1DataPro4u_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomQuery myCq = new CustomQuery(dataGridView1DataPro4u.Rows[e.RowIndex].Cells[0].Value.ToString());
            myCq.ShowDialog();
        }
        private void updateData()
        {
            dataGridView1DataPro4u.DataSource = null;
            dataGridView1DataPro4u.Update();
            dataGridView1DataPro4u.Refresh();
        }

        private void Button1Query3b_Click(object sender, EventArgs e)
        {
            if (SrvOn)
            {
                updateData();
                dataGridView1DataPro4u.DataSource = Controller.SqlCon.Query3b();
            }
            else
            {
                MessageBox.Show("Connection Error",
    "Please connect to Host",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
            }


        }

        private void Button2Query4b_Click(object sender, EventArgs e)
        {
            if (SrvOn)
            {
                updateData();
                dataGridView1DataPro4u.DataSource = Controller.SqlCon.Query4b();
            }
            else
            {
                MessageBox.Show("Connection Error",
    "Please connect to Host",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
            }


        }

        private void Button1ClearDataGrid_Click(object sender, EventArgs e)
        {
            dataGridView1DataPro4u.DataSource = null;
        }
    }
}

