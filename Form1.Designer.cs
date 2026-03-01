namespace WindowsFormsApp12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button butProcCount;
        private System.Windows.Forms.Button butProcesses;
        private System.Windows.Forms.TextBox textBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.butProcCount = new System.Windows.Forms.Button();
            this.butProcesses = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butProcCount
            // 
            this.butProcCount.Location = new System.Drawing.Point(12, 12);
            this.butProcCount.Name = "butProcCount";
            this.butProcCount.Size = new System.Drawing.Size(180, 35);
            this.butProcCount.TabIndex = 0;
            this.butProcCount.Text = "Узнать число процессоров";
            this.butProcCount.UseVisualStyleBackColor = true;
            this.butProcCount.Click += new System.EventHandler(this.butProcCount_Click);
            // 
            // butProcesses
            // 
            this.butProcesses.Location = new System.Drawing.Point(198, 12);
            this.butProcesses.Name = "butProcesses";
            this.butProcesses.Size = new System.Drawing.Size(200, 35);
            this.butProcesses.TabIndex = 1;
            this.butProcesses.Text = "Показать оконные процессы";
            this.butProcesses.UseVisualStyleBackColor = true;
            this.butProcesses.Click += new System.EventHandler(this.butProcesses_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(386, 250);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(410, 325);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butProcesses);
            this.Controls.Add(this.butProcCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Количество процессоров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
