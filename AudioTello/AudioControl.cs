using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using AudioTello.Properties;
using Un4seen.BassWasapi;
using Un4seen.Bass;

namespace AudioTello
{
    
    public partial class AudioControl : Form
    {



       public string status = "Off";
       public string SongNow;
       public string SongLast;
       public  string AplicationSelected;

        Analyzer analyzer;
        public AudioControl()
        {
            

            DateTime dt = new DateTime();
            InitializeComponent();
            comboBoxSoft.Enabled = false;
            ComboBoxCom.Enabled = false;
            //Carga los puertos Com
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComboBoxCom.Items.Add(s);

            }
            //Carga los procesos.
            //Process[] processlist = Process.GetProcesses();
            //foreach (Process theprocess in processlist.OrderBy(p => p.ProcessName))
            //{
            //    comboBoxSoft.Items.Add(theprocess.ProcessName);
            //}

            //InitializeComponent();

            analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            
            

        }
        private void CheckBoxSoftware_CheckedChanged(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist.OrderBy(p => p.ProcessName))
            {
                comboBoxSoft.Items.Add(theprocess.ProcessName);
            }


            if (checkBoxSoftware.Checked == true) comboBoxSoft.Enabled = true;
            if (checkBoxSoftware.Checked == false) comboBoxSoft.Enabled = false;


        }

        private void CheckBoxSelectCom_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSelectCom.Checked == true) ComboBoxCom.Enabled = true;
            if (CheckBoxSelectCom.Checked == false) ComboBoxCom.Enabled = false;
        }

        private void AudioControl_Load(object sender, EventArgs e)
        {

        }

        private void BtnOptionOn_Click(object sender, EventArgs e)
        {


            if (checkBoxSoftware.Checked == true)
            {
                TimerCron.Enabled = true;

                if (sender is Button btn)
                {
                    if (btn.Text == "ON")
                    {
                        TimerCron.Enabled = false;
                        btn.Text = "OFF";
                        //accept_notif = "0";
                    }
                    else if (btn.Text == "OFF")
                    {
                        
                        btn.Text = "ON";
                        //accept_notif = "1";
                    }
                }


                //AplicationSelected = comboBoxSoft.SelectedItem.ToString();
                //TimerCron.Enabled = true;
                //textBoxExit.Text = AplicationSelected;

                //Process[] Procesospotify = Process.GetProcessesByName(AplicationSelected);
                //SongNow = Procesospotify[0].MainWindowTitle.ToString();

                //textBoxExit.Text = textBoxExit.Text + SongNow;



            }
        }

        private void TimerCron_Tick(object sender, EventArgs e)
        {

            try
            {
                AplicationSelected = comboBoxSoft.SelectedItem.ToString();
                textBoxExit.Text = AplicationSelected;
                Process[] Procesospotify = Process.GetProcessesByName(AplicationSelected);
                string programa = AplicationSelected + " : ";
                SongNow = Procesospotify[0].MainWindowTitle.ToString();
                if (checkBoxNameProgram.Checked == false) programa = "";

                if (SongNow != SongLast)
                {


                    textBoxExit.Text = programa + SongNow;// + "lastsong " + SongLast;

                    SongNow = SongLast;
                }
                else
                {
                    textBoxExit.Text = programa + SongNow;
                    // textBoxExit.Text = programa + " : " + SongNow  + "lastsong " + SongLast;
                }
            }
            catch
            {
                LabelExitError.Text = "Se produgo un error al no seleccionar el disposivo de entrada .";
            }

        }

        private void ButtonSpectrumOnOff_Click(object sender, EventArgs e)
        {
                analyzer.Enable = true;
                analyzer.DisplayEnable = true;
            List<byte> myBytes = analyzer._spectrumdata.ToList();
            LabelValores.Text = " MO MO MO MO MO ";


        }

        private void ButtonSpectrumOff_Click(object sender, EventArgs e)
        {
            analyzer.Enable = false;
            analyzer.DisplayEnable = false;
            BassWasapi.BASS_WASAPI_Stop(true);
            ButtonSpectrumOn.Enabled = true;
            comboBox1.Enabled = true;
            timer1.Enabled = false;

            

        }

        private void TimerAudioLeftRight_Tick(object sender, EventArgs e)
        {
            AudioTxtLeft.Text = progressBar1.Value.ToString();
           // ButtonSpectrumOn.Enabled = false;
            AudioTxtRight.Text = progressBar2.Value.ToString();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
