namespace Macchine_BGW
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
            this.bgw_macchina1 = new System.ComponentModel.BackgroundWorker();
            this.bgw_macchina2 = new System.ComponentModel.BackgroundWorker();
            this.pic_strada4 = new System.Windows.Forms.PictureBox();
            this.pic_strada3 = new System.Windows.Forms.PictureBox();
            this.pic_strada2 = new System.Windows.Forms.PictureBox();
            this.pic_strada1 = new System.Windows.Forms.PictureBox();
            this.pic_macchina1 = new System.Windows.Forms.PictureBox();
            this.pic_macchina2 = new System.Windows.Forms.PictureBox();
            this.btn_avvio = new System.Windows.Forms.Button();
            this.btn_riavvio = new System.Windows.Forms.Button();
            this.txt_win = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_macchina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_macchina2)).BeginInit();
            this.SuspendLayout();
            // 
            // bgw_macchina1
            // 
            this.bgw_macchina1.WorkerReportsProgress = true;
            this.bgw_macchina1.WorkerSupportsCancellation = true;
            this.bgw_macchina1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_macchina1_DoWork);
            this.bgw_macchina1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_macchina1_ProgressChanged);
            this.bgw_macchina1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_macchina1_RunWorkerCompleted);
            // 
            // bgw_macchina2
            // 
            this.bgw_macchina2.WorkerReportsProgress = true;
            this.bgw_macchina2.WorkerSupportsCancellation = true;
            this.bgw_macchina2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_macchina2_DoWork);
            this.bgw_macchina2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_macchina2_ProgressChanged);
            this.bgw_macchina2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_macchina2_RunWorkerCompleted);
            // 
            // pic_strada4
            // 
            this.pic_strada4.Image = global::Macchine_BGW.Properties.Resources.road_trip_background_10864211;
            this.pic_strada4.Location = new System.Drawing.Point(607, 141);
            this.pic_strada4.Name = "pic_strada4";
            this.pic_strada4.Size = new System.Drawing.Size(193, 161);
            this.pic_strada4.TabIndex = 3;
            this.pic_strada4.TabStop = false;
            // 
            // pic_strada3
            // 
            this.pic_strada3.Image = global::Macchine_BGW.Properties.Resources.road_trip_background_10864211;
            this.pic_strada3.Location = new System.Drawing.Point(486, 141);
            this.pic_strada3.Name = "pic_strada3";
            this.pic_strada3.Size = new System.Drawing.Size(247, 161);
            this.pic_strada3.TabIndex = 2;
            this.pic_strada3.TabStop = false;
            // 
            // pic_strada2
            // 
            this.pic_strada2.Image = global::Macchine_BGW.Properties.Resources.road_trip_background_10864211;
            this.pic_strada2.Location = new System.Drawing.Point(240, 141);
            this.pic_strada2.Name = "pic_strada2";
            this.pic_strada2.Size = new System.Drawing.Size(247, 161);
            this.pic_strada2.TabIndex = 1;
            this.pic_strada2.TabStop = false;
            // 
            // pic_strada1
            // 
            this.pic_strada1.Image = global::Macchine_BGW.Properties.Resources.road_trip_background_10864211;
            this.pic_strada1.Location = new System.Drawing.Point(-5, 141);
            this.pic_strada1.Name = "pic_strada1";
            this.pic_strada1.Size = new System.Drawing.Size(248, 161);
            this.pic_strada1.TabIndex = 0;
            this.pic_strada1.TabStop = false;
            // 
            // pic_macchina1
            // 
            this.pic_macchina1.Image = global::Macchine_BGW.Properties.Resources.macchinabianca;
            this.pic_macchina1.Location = new System.Drawing.Point(12, 233);
            this.pic_macchina1.Name = "pic_macchina1";
            this.pic_macchina1.Size = new System.Drawing.Size(100, 50);
            this.pic_macchina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_macchina1.TabIndex = 4;
            this.pic_macchina1.TabStop = false;
            // 
            // pic_macchina2
            // 
            this.pic_macchina2.Image = global::Macchine_BGW.Properties.Resources.macchinarossa;
            this.pic_macchina2.Location = new System.Drawing.Point(12, 157);
            this.pic_macchina2.Name = "pic_macchina2";
            this.pic_macchina2.Size = new System.Drawing.Size(100, 50);
            this.pic_macchina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_macchina2.TabIndex = 5;
            this.pic_macchina2.TabStop = false;
            // 
            // btn_avvio
            // 
            this.btn_avvio.Location = new System.Drawing.Point(50, 62);
            this.btn_avvio.Name = "btn_avvio";
            this.btn_avvio.Size = new System.Drawing.Size(75, 20);
            this.btn_avvio.TabIndex = 6;
            this.btn_avvio.Text = "Avvio";
            this.btn_avvio.UseVisualStyleBackColor = true;
            this.btn_avvio.Click += new System.EventHandler(this.btn_avvio_Click);
            // 
            // btn_riavvio
            // 
            this.btn_riavvio.Location = new System.Drawing.Point(131, 62);
            this.btn_riavvio.Name = "btn_riavvio";
            this.btn_riavvio.Size = new System.Drawing.Size(75, 20);
            this.btn_riavvio.TabIndex = 7;
            this.btn_riavvio.Text = "Riavvia";
            this.btn_riavvio.UseVisualStyleBackColor = true;
            this.btn_riavvio.Click += new System.EventHandler(this.btn_riavvio_Click);
            // 
            // txt_win
            // 
            this.txt_win.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_win.Location = new System.Drawing.Point(212, 62);
            this.txt_win.Name = "txt_win";
            this.txt_win.Size = new System.Drawing.Size(159, 20);
            this.txt_win.TabIndex = 8;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(377, 62);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 20);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.txt_win);
            this.Controls.Add(this.btn_riavvio);
            this.Controls.Add(this.btn_avvio);
            this.Controls.Add(this.pic_macchina2);
            this.Controls.Add(this.pic_macchina1);
            this.Controls.Add(this.pic_strada4);
            this.Controls.Add(this.pic_strada3);
            this.Controls.Add(this.pic_strada2);
            this.Controls.Add(this.pic_strada1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_strada1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_macchina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_macchina2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgw_macchina1;
        private System.ComponentModel.BackgroundWorker bgw_macchina2;
        private System.Windows.Forms.PictureBox pic_strada1;
        private System.Windows.Forms.PictureBox pic_strada2;
        private System.Windows.Forms.PictureBox pic_strada3;
        private System.Windows.Forms.PictureBox pic_strada4;
        private System.Windows.Forms.PictureBox pic_macchina1;
        private System.Windows.Forms.PictureBox pic_macchina2;
        private System.Windows.Forms.Button btn_avvio;
        private System.Windows.Forms.Button btn_riavvio;
        private System.Windows.Forms.TextBox txt_win;
        private System.Windows.Forms.Button btn_stop;
    }
}

