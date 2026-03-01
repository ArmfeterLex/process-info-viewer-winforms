using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butProcCount_Click(object sender, EventArgs e)
        {
            int count = Environment.ProcessorCount;
            MessageBox.Show("Количество процессоров: " + count.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butProcesses_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Process[] processes = Process.GetProcesses(Environment.MachineName);
            foreach (Process p in processes)
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    sb.AppendLine(p.ProcessName);
                }
            }

            textBox1.Text = sb.Length > 0 ? sb.ToString() : "Нет оконных процессов.";
        }
    }
}
