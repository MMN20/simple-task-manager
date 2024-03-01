using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tasky
{
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        int numberOfTasks = 0;

        private void updateTasksLabel()
        {
            lblNOfTasks.Text = "Todays Tasks: " + numberOfTasks.ToString();
        }

        private void updateTaskProgress()
        {
            if(numberOfTasks == 0)
            {
                progressBar1.Value = 0;
                lblTaskProgress.Text = "Task Progress: ";
                return;
            }

            float value = ((float)listView1.CheckedItems.Count / listView1.Items.Count) * 100;
            progressBar1.Value = (int)value;
            lblTaskProgress.Text = "Task Progress: " + progressBar1.Value + "%";

            if(progressBar1.Value == progressBar1.Maximum)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.ShowBalloonTip(2000);
            }


            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            while(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                numberOfTasks--;
            }
            updateTasksLabel();
            updateTaskProgress();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTask.Text))
            {
                errorProvider1.SetError(txtTask, "Cannot be empty");
                return;
            }

            ListViewItem item = new ListViewItem(txtTask.Text,"grp1");

            listView1.Items.Add(item);


            



            txtTask.Clear();
            txtTask.Focus();

            numberOfTasks++;
            updateTasksLabel();
            updateTaskProgress();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmHomeScreen_Load(object sender, EventArgs e)
        {
            lblNOfTasks.Text = "Todays Tasks: 0";
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            Font f = listView1.Font;
           
            if (e.Item.Checked)
            {
                // Just changing the font style 
                e.Item.Font = new Font(e.Item.Font.Name, e.Item.Font.Size, FontStyle.Strikeout);
            }
            else
            {
                e.Item.Font = f;
            }

            updateTaskProgress();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
