using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadersGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
        private void RBTN1_CheckedChanged(object sender, EventArgs e)
        {
            //CHS RadioButton is Checked;

            int m_iLang = (int)LANGUAGE.CHS;
            LanguageChange(m_iLang);
        }
        private void RBTN2_CheckedChanged(object sender, EventArgs e)
        {
            //ENG RadioButton is Checked;
            
            int m_iLang = (int)LANGUAGE.ENG;
            LanguageChange(m_iLang);
        }

        public void LanguageChange(int iChangetoLanguage = 0)
        {
            switch (iChangetoLanguage) 
            {

                case (int)LANGUAGE.ENG:
                    Group_Lang.Text = "切换语言";
                    RBTN1.Text = "Chinese";
                    RBTN2.Text = "英文";
                    Button1.Text = "Generate!";
                    this.Text = "LeadersGenerator";
                    break;
                case (int)LANGUAGE.CHS:

                default:
                    Group_Lang.Text = "Swith Language";
                    RBTN1.Text = "中文";
                    RBTN2.Text = "English";
                    Button1.Text = "生成!";
                    this.Text = "将领生成器";
                    break;



            }

        }

    }
}
