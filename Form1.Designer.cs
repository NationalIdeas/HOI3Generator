namespace LeadersGenerator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button1 = new System.Windows.Forms.Button();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.Group_Lang = new System.Windows.Forms.GroupBox();
            this.RBTN2 = new System.Windows.Forms.RadioButton();
            this.RBTN1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.Group_Lang.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(500, 100);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ListBox1);
            this.Panel1.Location = new System.Drawing.Point(10, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(337, 280);
            this.Panel1.TabIndex = 1;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(30, 15);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(209, 228);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(10, 476);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(250, 25);
            this.ProgressBar1.TabIndex = 2;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(277, 476);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(85, 30);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "生成";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(42, 314);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(209, 56);
            this.TrackBar1.TabIndex = 4;
            this.TrackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Group_Lang
            // 
            this.Group_Lang.Controls.Add(this.RBTN2);
            this.Group_Lang.Controls.Add(this.RBTN1);
            this.Group_Lang.Location = new System.Drawing.Point(514, 12);
            this.Group_Lang.Name = "Group_Lang";
            this.Group_Lang.Size = new System.Drawing.Size(243, 52);
            this.Group_Lang.TabIndex = 5;
            this.Group_Lang.TabStop = false;
            this.Group_Lang.Text = "语言设置 / Languages";
            // 
            // RBTN2
            // 
            this.RBTN2.AutoSize = true;
            this.RBTN2.Location = new System.Drawing.Point(151, 16);
            this.RBTN2.Name = "RBTN2";
            this.RBTN2.Size = new System.Drawing.Size(75, 21);
            this.RBTN2.TabIndex = 1;
            this.RBTN2.TabStop = true;
            this.RBTN2.Text = "English";
            this.RBTN2.UseVisualStyleBackColor = true;
            this.RBTN2.CheckedChanged += new System.EventHandler(this.RBTN2_CheckedChanged);
            // 
            // RBTN1
            // 
            this.RBTN1.AutoSize = true;
            this.RBTN1.Checked = true;
            this.RBTN1.Location = new System.Drawing.Point(6, 16);
            this.RBTN1.Name = "RBTN1";
            this.RBTN1.Size = new System.Drawing.Size(57, 21);
            this.RBTN1.TabIndex = 0;
            this.RBTN1.TabStop = true;
            this.RBTN1.Text = "中文";
            this.RBTN1.UseVisualStyleBackColor = true;
            this.RBTN1.CheckedChanged += new System.EventHandler(this.RBTN1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 513);
            this.Controls.Add(this.Group_Lang);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "将领生成器";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.Group_Lang.ResumeLayout(false);
            this.Group_Lang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TrackBar TrackBar1;
        private System.Windows.Forms.GroupBox Group_Lang;
        private System.Windows.Forms.RadioButton RBTN2;
        private System.Windows.Forms.RadioButton RBTN1;
    }












    enum LANGUAGE { CHS, ENG };



}

