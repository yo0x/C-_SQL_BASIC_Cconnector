namespace Targil4Bonus
{
    partial class CustomQuery
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
            this.dataGridView1CustomMissionsProj = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CustomMissionsProj)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1CustomMissionsProj
            // 
            this.dataGridView1CustomMissionsProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1CustomMissionsProj.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1CustomMissionsProj.Name = "dataGridView1CustomMissionsProj";
            this.dataGridView1CustomMissionsProj.Size = new System.Drawing.Size(1104, 352);
            this.dataGridView1CustomMissionsProj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worker Details:";
            // 
            // CustomQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1CustomMissionsProj);
            this.Name = "CustomQuery";
            this.Text = "Targil4Bonus - Custom Missions by Emp";
            this.Load += new System.EventHandler(this.CustomQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CustomMissionsProj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1CustomMissionsProj;
        private System.Windows.Forms.Label label1;
    }
}