namespace Targil4Bonus
{
    partial class MenuView
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
            this.dataGridView1DataPro4u = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2SrvStatus = new System.Windows.Forms.Label();
            this.button1ShowAllEmpQ = new System.Windows.Forms.Button();
            this.button2SearchEmpById = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1SearchEmpById = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3UpdateSalaryBy5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4ConnectToSrv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DataPro4u)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1DataPro4u
            // 
            this.dataGridView1DataPro4u.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1DataPro4u.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1DataPro4u.Name = "dataGridView1DataPro4u";
            this.dataGridView1DataPro4u.Size = new System.Drawing.Size(776, 248);
            this.dataGridView1DataPro4u.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1SearchEmpById);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3UpdateSalaryBy5);
            this.groupBox1.Controls.Add(this.button2SearchEmpById);
            this.groupBox1.Controls.Add(this.button1ShowAllEmpQ);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queries";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection Status:";
            // 
            // label2SrvStatus
            // 
            this.label2SrvStatus.AutoSize = true;
            this.label2SrvStatus.Location = new System.Drawing.Point(115, 13);
            this.label2SrvStatus.Name = "label2SrvStatus";
            this.label2SrvStatus.Size = new System.Drawing.Size(31, 13);
            this.label2SrvStatus.TabIndex = 2;
            this.label2SrvStatus.Text = "none";
            // 
            // button1ShowAllEmpQ
            // 
            this.button1ShowAllEmpQ.Location = new System.Drawing.Point(22, 44);
            this.button1ShowAllEmpQ.Name = "button1ShowAllEmpQ";
            this.button1ShowAllEmpQ.Size = new System.Drawing.Size(112, 34);
            this.button1ShowAllEmpQ.TabIndex = 0;
            this.button1ShowAllEmpQ.Text = "Show Employees";
            this.button1ShowAllEmpQ.UseVisualStyleBackColor = true;
            this.button1ShowAllEmpQ.Click += new System.EventHandler(this.Button1ShowAllEmpQ_Click);
            // 
            // button2SearchEmpById
            // 
            this.button2SearchEmpById.Location = new System.Drawing.Point(610, 44);
            this.button2SearchEmpById.Name = "button2SearchEmpById";
            this.button2SearchEmpById.Size = new System.Drawing.Size(112, 34);
            this.button2SearchEmpById.TabIndex = 0;
            this.button2SearchEmpById.Text = "Search";
            this.button2SearchEmpById.UseVisualStyleBackColor = true;
            this.button2SearchEmpById.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Employee:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1SearchEmpById
            // 
            this.textBox1SearchEmpById.Location = new System.Drawing.Point(483, 52);
            this.textBox1SearchEmpById.Name = "textBox1SearchEmpById";
            this.textBox1SearchEmpById.Size = new System.Drawing.Size(108, 20);
            this.textBox1SearchEmpById.TabIndex = 2;
            this.textBox1SearchEmpById.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Show all Emplooyes query";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search emplooye by ID:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Update Emp Salary by 5%";
            // 
            // button3UpdateSalaryBy5
            // 
            this.button3UpdateSalaryBy5.Location = new System.Drawing.Point(25, 136);
            this.button3UpdateSalaryBy5.Name = "button3UpdateSalaryBy5";
            this.button3UpdateSalaryBy5.Size = new System.Drawing.Size(112, 34);
            this.button3UpdateSalaryBy5.TabIndex = 0;
            this.button3UpdateSalaryBy5.Text = "Update";
            this.button3UpdateSalaryBy5.UseVisualStyleBackColor = true;
            this.button3UpdateSalaryBy5.Click += new System.EventHandler(this.Button3UpdateSalaryBy5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(685, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________";
            // 
            // button4ConnectToSrv
            // 
            this.button4ConnectToSrv.Location = new System.Drawing.Point(349, 13);
            this.button4ConnectToSrv.Name = "button4ConnectToSrv";
            this.button4ConnectToSrv.Size = new System.Drawing.Size(160, 37);
            this.button4ConnectToSrv.TabIndex = 3;
            this.button4ConnectToSrv.Text = "Connect to Server";
            this.button4ConnectToSrv.UseVisualStyleBackColor = true;
            this.button4ConnectToSrv.Click += new System.EventHandler(this.Button4ConnectToSrv_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.button4ConnectToSrv);
            this.Controls.Add(this.label2SrvStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1DataPro4u);
            this.Name = "MenuView";
            this.Text = "Targil 4 BONUS - SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DataPro4u)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1DataPro4u;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1SearchEmpById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3UpdateSalaryBy5;
        private System.Windows.Forms.Button button2SearchEmpById;
        private System.Windows.Forms.Button button1ShowAllEmpQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2SrvStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4ConnectToSrv;
    }
}

