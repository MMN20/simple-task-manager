using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frmHome = new frmHomeScreen();
            frmTaskList = new frmTaskListScreen();
            Tools = new frmToolsScreen(lblTimer,lblTimerText);
        }

        private void loadFormOnPanel(object form)
        {
            Form frm = (Form)form;
            frm.TopLevel = false;
            pnlMainPanel.Controls.Clear();
            pnlMainPanel.Controls.Add(frm);
            frm.Show();
        }

        frmHomeScreen frmHome = null;
        frmTaskListScreen  frmTaskList = null;
        frmToolsScreen Tools = null;


        private void btnHome_Click(object sender, EventArgs e)
        {
            loadFormOnPanel(frmHome);
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {          
            loadFormOnPanel(frmTaskList);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {            
            loadFormOnPanel(Tools);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTaskList.PerformClick();
            lblTodaysDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
