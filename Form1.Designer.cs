namespace Tasky
{
    partial class Form1
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnTaskList = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.lblTimer);
            this.pnlSideBar.Controls.Add(this.lblTimerText);
            this.pnlSideBar.Controls.Add(this.btnTools);
            this.pnlSideBar.Controls.Add(this.btnTaskList);
            this.pnlSideBar.Controls.Add(this.btnHome);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(136, 665);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.Maroon;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.ForeColor = System.Drawing.Color.White;
            this.btnTools.Location = new System.Drawing.Point(2, 240);
            this.btnTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(124, 34);
            this.btnTools.TabIndex = 2;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnTaskList
            // 
            this.btnTaskList.BackColor = System.Drawing.Color.Maroon;
            this.btnTaskList.FlatAppearance.BorderSize = 0;
            this.btnTaskList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskList.ForeColor = System.Drawing.Color.White;
            this.btnTaskList.Location = new System.Drawing.Point(2, 179);
            this.btnTaskList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaskList.Name = "btnTaskList";
            this.btnTaskList.Size = new System.Drawing.Size(124, 34);
            this.btnTaskList.TabIndex = 1;
            this.btnTaskList.Text = "Task list";
            this.btnTaskList.UseVisualStyleBackColor = false;
            this.btnTaskList.Click += new System.EventHandler(this.btnTaskList_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Maroon;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(2, 118);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTodaysDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(136, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 82);
            this.panel1.TabIndex = 1;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.Location = new System.Drawing.Point(749, 26);
            this.lblTodaysDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(66, 24);
            this.lblTodaysDate.TabIndex = 0;
            this.lblTodaysDate.Text = "label1";
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.BackColor = System.Drawing.Color.Silver;
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(136, 82);
            this.pnlMainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(865, 583);
            this.pnlMainPanel.TabIndex = 2;
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.Location = new System.Drawing.Point(32, 482);
            this.lblTimerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(66, 24);
            this.lblTimerText.TabIndex = 1;
            this.lblTimerText.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(32, 436);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 24);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 665);
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnTaskList;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerText;
    }
}

