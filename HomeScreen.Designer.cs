namespace Tasky
{
    partial class frmHomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNOfTasks = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCreateNewTask = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.grpDeleteTask = new System.Windows.Forms.GroupBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTaskProgress = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpCreateNewTask.SuspendLayout();
            this.grpDeleteTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNOfTasks
            // 
            this.lblNOfTasks.AutoSize = true;
            this.lblNOfTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOfTasks.Location = new System.Drawing.Point(39, 43);
            this.lblNOfTasks.Name = "lblNOfTasks";
            this.lblNOfTasks.Size = new System.Drawing.Size(124, 20);
            this.lblNOfTasks.TabIndex = 1;
            this.lblNOfTasks.Text = "Todays tasks: ";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 594);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 800;
            // 
            // grpCreateNewTask
            // 
            this.grpCreateNewTask.Controls.Add(this.btnAddTask);
            this.grpCreateNewTask.Controls.Add(this.txtTask);
            this.grpCreateNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpCreateNewTask.Location = new System.Drawing.Point(788, 113);
            this.grpCreateNewTask.Name = "grpCreateNewTask";
            this.grpCreateNewTask.Size = new System.Drawing.Size(353, 180);
            this.grpCreateNewTask.TabIndex = 3;
            this.grpCreateNewTask.TabStop = false;
            this.grpCreateNewTask.Text = "Create new task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Black;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(81, 118);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(184, 45);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(20, 35);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(308, 67);
            this.txtTask.TabIndex = 0;
            // 
            // grpDeleteTask
            // 
            this.grpDeleteTask.Controls.Add(this.btnDeleteTask);
            this.grpDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpDeleteTask.Location = new System.Drawing.Point(835, 325);
            this.grpDeleteTask.Name = "grpDeleteTask";
            this.grpDeleteTask.Size = new System.Drawing.Size(258, 97);
            this.grpDeleteTask.TabIndex = 4;
            this.grpDeleteTask.TabStop = false;
            this.grpDeleteTask.Text = "Delete selected task";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Black;
            this.btnDeleteTask.FlatAppearance.BorderSize = 0;
            this.btnDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(34, 36);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(184, 45);
            this.btnDeleteTask.TabIndex = 1;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(800, 555);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 33);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblTaskProgress
            // 
            this.lblTaskProgress.AutoSize = true;
            this.lblTaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskProgress.Location = new System.Drawing.Point(796, 521);
            this.lblTaskProgress.Name = "lblTaskProgress";
            this.lblTaskProgress.Size = new System.Drawing.Size(133, 20);
            this.lblTaskProgress.TabIndex = 6;
            this.lblTaskProgress.Text = "Task Progress: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "You have completed all the tasks";
            this.notifyIcon1.BalloonTipTitle = "Congrats";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmHomeScreen
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1170, 746);
            this.Controls.Add(this.lblTaskProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grpDeleteTask);
            this.Controls.Add(this.grpCreateNewTask);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblNOfTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.frmHomeScreen_Load);
            this.grpCreateNewTask.ResumeLayout(false);
            this.grpCreateNewTask.PerformLayout();
            this.grpDeleteTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOfTasks;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox grpCreateNewTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.GroupBox grpDeleteTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTaskProgress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}