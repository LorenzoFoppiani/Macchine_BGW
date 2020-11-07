using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macchine_BGW
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bgw_macchina1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < 38; i++)
            {
                Thread.Sleep(rng.Next(100,200));
                bgw_macchina1.ReportProgress(i);
            }
        }

        private void bgw_macchina1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pic_macchina1.Location = new Point(pic_macchina1.Location.X+e.ProgressPercentage, pic_macchina1.Location.Y);
        }

        private void bgw_macchina1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bgw_macchina2.IsBusy)
                MessageBox.Show("MACCHINA2 VINCE");
        }

        private void bgw_macchina2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 38; i++)
            {
                Thread.Sleep(rng.Next(100, 200));
                bgw_macchina2.ReportProgress(i);
            }
        }

        private void bgw_macchina2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pic_macchina2.Location = new Point(pic_macchina2.Location.X + e.ProgressPercentage, pic_macchina2.Location.Y);
            //MessageBox.Show(Convert.ToString(e.ProgressPercentage));
            

        }

        private void bgw_macchina2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bgw_macchina1.IsBusy)
                MessageBox.Show("MACCHINA1 VINCE");

        }

        private void btn_avvio_Click(object sender, EventArgs e)
        {
            bgw_macchina1.RunWorkerAsync();
            bgw_macchina2.RunWorkerAsync();
        }
    }
}
