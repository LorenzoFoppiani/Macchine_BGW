using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                if (bgw_macchina1.CancellationPending)
                    break;
            }

        }

        private void bgw_macchina1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pic_macchina1.Location = new Point(pic_macchina1.Location.X+e.ProgressPercentage, pic_macchina1.Location.Y);
        }

        private void bgw_macchina1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Se macchina2 sta correndo ed è indietro rispetto a macchina1
            if (bgw_macchina2.IsBusy && pic_macchina1.Location.X > pic_macchina2.Location.X)
                txt_win.Text = "MACCHINA 2 VINCE!";
            //Altrimenti (gara annullata)
            else if (bgw_macchina1.CancellationPending)
                txt_win.Text = "Gara annullata";
        }

        private void bgw_macchina2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 38; i++)
            {
                Thread.Sleep(rng.Next(100, 200));
                bgw_macchina2.ReportProgress(i);
                if (bgw_macchina2.CancellationPending)
                {
                    break;
                }
            }
        }

        private void bgw_macchina2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pic_macchina2.Location = new Point(pic_macchina2.Location.X + e.ProgressPercentage, pic_macchina2.Location.Y);

        }

        private void bgw_macchina2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bgw_macchina1.IsBusy && pic_macchina2.Location.X > pic_macchina1.Location.X)
                txt_win.Text = "MACCHINA 1 VINCE!";
            else if(bgw_macchina2.CancellationPending)
                txt_win.Text = "Gara annullata";
        }

        private void btn_avvio_Click(object sender, EventArgs e)
        {
            bgw_macchina1.RunWorkerAsync();
            bgw_macchina2.RunWorkerAsync();
        }

        private void btn_riavvio_Click(object sender, EventArgs e)
        {
            pic_macchina1.Location = new Point(0, pic_macchina1.Location.Y);
            pic_macchina2.Location = new Point(0, pic_macchina2.Location.Y);

            txt_win.Text = "";

            bgw_macchina1.RunWorkerAsync();
            bgw_macchina2.RunWorkerAsync();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            bgw_macchina1.CancelAsync();
            bgw_macchina2.CancelAsync();
            txt_win.Text = "";
            txt_win.Text = "Gara annullata";
        }
    }
}
