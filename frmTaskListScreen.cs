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
    public partial class frmTaskListScreen : Form
    {
        public frmTaskListScreen()
        {
            InitializeComponent();
        }

        int numberOftasks = 0;


        private void updateProgressBar()
        {
            if(numberOftasks == 0)
            {
                progressBar1.Value = 0;
                return;
            }

            
            float value = ((float) listView1.CheckedItems.Count /  listView1.Items.Count) * 100;
            progressBar1.Value = (int)value;
        }

        private void frmTaskListScreen_Load(object sender, EventArgs e)
        {

        }

        private void frmTaskListScreen_Load_1(object sender, EventArgs e)
        {
            cbPriority.Items.Add("Urgent");
            cbPriority.Items.Add("Important");
            cbPriority.Items.Add("Normal");


            

            cbClassification.Items.Add("Work");
            cbClassification.Items.Add("Personal");
            cbClassification.Items.Add("Family");
            cbClassification.Items.Add("Health");
            cbClassification.Items.Add("Financial");

            listView1.Columns.Add("Title",600);
            listView1.Columns.Add("Priority",150);
            listView1.Columns.Add("Classification",150);


        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtTask.Text) || string.IsNullOrEmpty(cbClassification.Text) || string.IsNullOrEmpty(cbPriority.Text)))
            {

                ListViewItem item = new ListViewItem(txtTask.Text);
                item.SubItems.Add(cbPriority.Text);
                item.SubItems.Add(cbClassification.Text);
                item.Group = listView1.Groups[cbClassification.Text];

                item.ImageIndex = cbPriority.SelectedIndex;
                
                listView1.Items.Add(item);
                numberOftasks++;
                
                txtTask.Text = "";
                cbPriority.Text = "";
                cbClassification.Text = "";
                txtTask.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                numberOftasks--;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Strikeout);
            }
            else
            {
                e.Item.Font = listView1.Font;
            }
            updateProgressBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
