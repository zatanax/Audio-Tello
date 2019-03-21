namespace AudioTello
{
    partial class AudioControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ButtonSpectrumOn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxCom = new System.Windows.Forms.ComboBox();
            this.BtnOptionOff = new System.Windows.Forms.Button();
            this.BtnOptionOn = new System.Windows.Forms.Button();
            this.comboBoxSoft = new System.Windows.Forms.ComboBox();
            this.checkBoxNameProgram = new System.Windows.Forms.CheckBox();
            this.CheckBoxSelectCom = new System.Windows.Forms.CheckBox();
            this.checkBoxSoftware = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxExit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerCron = new System.Windows.Forms.Timer(this.components);
            this.LabelExitError = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonSpectrumOff = new System.Windows.Forms.Button();
            this.AudioTxtLeft = new System.Windows.Forms.Label();
            this.AudioTxtRight = new System.Windows.Forms.Label();
            this.TimerAudioLeftRight = new System.Windows.Forms.Timer(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new AudioTello.Spectrum();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.leftRght1 = new AudioTello.LeftRght();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSpectrumOn
            // 
            this.ButtonSpectrumOn.Location = new System.Drawing.Point(383, 503);
            this.ButtonSpectrumOn.Name = "ButtonSpectrumOn";
            this.ButtonSpectrumOn.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpectrumOn.TabIndex = 0;
            this.ButtonSpectrumOn.Text = "On";
            this.ButtonSpectrumOn.UseVisualStyleBackColor = true;
            this.ButtonSpectrumOn.Click += new System.EventHandler(this.ButtonSpectrumOnOff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxCom);
            this.groupBox1.Controls.Add(this.BtnOptionOff);
            this.groupBox1.Controls.Add(this.BtnOptionOn);
            this.groupBox1.Controls.Add(this.comboBoxSoft);
            this.groupBox1.Controls.Add(this.checkBoxNameProgram);
            this.groupBox1.Controls.Add(this.CheckBoxSelectCom);
            this.groupBox1.Controls.Add(this.checkBoxSoftware);
            this.groupBox1.Location = new System.Drawing.Point(15, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ComboBoxCom
            // 
            this.ComboBoxCom.FormattingEnabled = true;
            this.ComboBoxCom.Location = new System.Drawing.Point(6, 94);
            this.ComboBoxCom.Name = "ComboBoxCom";
            this.ComboBoxCom.Size = new System.Drawing.Size(188, 21);
            this.ComboBoxCom.TabIndex = 6;
            // 
            // BtnOptionOff
            // 
            this.BtnOptionOff.Location = new System.Drawing.Point(5, 121);
            this.BtnOptionOff.Name = "BtnOptionOff";
            this.BtnOptionOff.Size = new System.Drawing.Size(75, 23);
            this.BtnOptionOff.TabIndex = 5;
            this.BtnOptionOff.Text = "Off";
            this.BtnOptionOff.UseVisualStyleBackColor = true;
            // 
            // BtnOptionOn
            // 
            this.BtnOptionOn.Location = new System.Drawing.Point(5, 221);
            this.BtnOptionOn.Name = "BtnOptionOn";
            this.BtnOptionOn.Size = new System.Drawing.Size(75, 23);
            this.BtnOptionOn.TabIndex = 4;
            this.BtnOptionOn.Text = "ON/OFF";
            this.BtnOptionOn.UseVisualStyleBackColor = true;
            this.BtnOptionOn.Click += new System.EventHandler(this.BtnOptionOn_Click);
            // 
            // comboBoxSoft
            // 
            this.comboBoxSoft.FormattingEnabled = true;
            this.comboBoxSoft.Location = new System.Drawing.Point(6, 39);
            this.comboBoxSoft.Name = "comboBoxSoft";
            this.comboBoxSoft.Size = new System.Drawing.Size(188, 21);
            this.comboBoxSoft.TabIndex = 3;
            // 
            // checkBoxNameProgram
            // 
            this.checkBoxNameProgram.AutoSize = true;
            this.checkBoxNameProgram.Location = new System.Drawing.Point(84, 220);
            this.checkBoxNameProgram.Name = "checkBoxNameProgram";
            this.checkBoxNameProgram.Size = new System.Drawing.Size(126, 17);
            this.checkBoxNameProgram.TabIndex = 2;
            this.checkBoxNameProgram.Text = "Name of the Program";
            this.checkBoxNameProgram.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSelectCom
            // 
            this.CheckBoxSelectCom.AutoSize = true;
            this.CheckBoxSelectCom.Location = new System.Drawing.Point(6, 71);
            this.CheckBoxSelectCom.Name = "CheckBoxSelectCom";
            this.CheckBoxSelectCom.Size = new System.Drawing.Size(79, 17);
            this.CheckBoxSelectCom.TabIndex = 1;
            this.CheckBoxSelectCom.Text = "Select com";
            this.CheckBoxSelectCom.UseVisualStyleBackColor = true;
            this.CheckBoxSelectCom.CheckedChanged += new System.EventHandler(this.CheckBoxSelectCom_CheckedChanged);
            // 
            // checkBoxSoftware
            // 
            this.checkBoxSoftware.AutoSize = true;
            this.checkBoxSoftware.Location = new System.Drawing.Point(7, 19);
            this.checkBoxSoftware.Name = "checkBoxSoftware";
            this.checkBoxSoftware.Size = new System.Drawing.Size(98, 17);
            this.checkBoxSoftware.TabIndex = 0;
            this.checkBoxSoftware.Text = "Select Program";
            this.checkBoxSoftware.UseVisualStyleBackColor = true;
            this.checkBoxSoftware.CheckedChanged += new System.EventHandler(this.CheckBoxSoftware_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.elementHost2);
            this.groupBox2.Location = new System.Drawing.Point(231, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio left/ right";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elementHost1);
            this.groupBox3.Location = new System.Drawing.Point(2, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1302, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio Spectrum";
            // 
            // textBoxExit
            // 
            this.textBoxExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxExit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExit.Location = new System.Drawing.Point(250, 544);
            this.textBoxExit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExit.Multiline = true;
            this.textBoxExit.Name = "textBoxExit";
            this.textBoxExit.Size = new System.Drawing.Size(558, 50);
            this.textBoxExit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // TimerCron
            // 
            this.TimerCron.Interval = 900;
            this.TimerCron.Tick += new System.EventHandler(this.TimerCron_Tick);
            // 
            // LabelExitError
            // 
            this.LabelExitError.AutoSize = true;
            this.LabelExitError.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExitError.Location = new System.Drawing.Point(12, 583);
            this.LabelExitError.Name = "LabelExitError";
            this.LabelExitError.Size = new System.Drawing.Size(0, 15);
            this.LabelExitError.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(549, 503);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(122, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 25);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(570, 10);
            this.progressBar2.MarqueeAnimationSpeed = 25;
            this.progressBar2.Maximum = 1000;
            this.progressBar2.Minimum = 1;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(440, 25);
            this.progressBar2.Step = 1000;
            this.progressBar2.TabIndex = 8;
            this.progressBar2.Value = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 195);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1323, 160);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // ButtonSpectrumOff
            // 
            this.ButtonSpectrumOff.Location = new System.Drawing.Point(464, 503);
            this.ButtonSpectrumOff.Name = "ButtonSpectrumOff";
            this.ButtonSpectrumOff.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpectrumOff.TabIndex = 10;
            this.ButtonSpectrumOff.Text = "Off";
            this.ButtonSpectrumOff.UseVisualStyleBackColor = true;
            this.ButtonSpectrumOff.Click += new System.EventHandler(this.ButtonSpectrumOff_Click);
            // 
            // AudioTxtLeft
            // 
            this.AudioTxtLeft.AutoSize = true;
            this.AudioTxtLeft.Location = new System.Drawing.Point(130, 10);
            this.AudioTxtLeft.Name = "AudioTxtLeft";
            this.AudioTxtLeft.Size = new System.Drawing.Size(28, 13);
            this.AudioTxtLeft.TabIndex = 11;
            this.AudioTxtLeft.Text = " Left";
            // 
            // AudioTxtRight
            // 
            this.AudioTxtRight.AutoSize = true;
            this.AudioTxtRight.Location = new System.Drawing.Point(588, 10);
            this.AudioTxtRight.Name = "AudioTxtRight";
            this.AudioTxtRight.Size = new System.Drawing.Size(32, 13);
            this.AudioTxtRight.TabIndex = 12;
            this.AudioTxtRight.Text = "Right";
            // 
            // TimerAudioLeftRight
            // 
            this.TimerAudioLeftRight.Enabled = true;
            this.TimerAudioLeftRight.Interval = 25;
            this.TimerAudioLeftRight.Tick += new System.EventHandler(this.TimerAudioLeftRight_Tick);
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 16);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1296, 147);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.spectrum1;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(3, 16);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(115, 167);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.leftRght1;
            // 
            // AudioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 637);
            this.Controls.Add(this.AudioTxtRight);
            this.Controls.Add(this.AudioTxtLeft);
            this.Controls.Add(this.ButtonSpectrumOff);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LabelExitError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonSpectrumOn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AudioControl";
            this.Text = "Audio";
            this.Load += new System.EventHandler(this.AudioControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSpectrumOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBoxCom;
        private System.Windows.Forms.Button BtnOptionOff;
        private System.Windows.Forms.Button BtnOptionOn;
        private System.Windows.Forms.ComboBox comboBoxSoft;
        private System.Windows.Forms.CheckBox checkBoxNameProgram;
        private System.Windows.Forms.CheckBox CheckBoxSelectCom;
        private System.Windows.Forms.CheckBox checkBoxSoftware;


        private System.Windows.Forms.TextBox textBoxExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerCron;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LeftRght leftRght1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Spectrum spectrum1;
        private System.Windows.Forms.Label LabelExitError;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ButtonSpectrumOff;
        private System.Windows.Forms.Label AudioTxtLeft;
        private System.Windows.Forms.Label AudioTxtRight;
        private System.Windows.Forms.Timer TimerAudioLeftRight;
    }
}

