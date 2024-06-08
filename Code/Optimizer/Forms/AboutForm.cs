using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
            OptionsHelper.ApplyTheme(this);

            pictureBox1.BackColor = OptionsHelper.CurrentOptions.Theme;
        }

        private void About_Load(object sender, EventArgs e) {
            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e) {
            string s0 = "";
            string s1 = "R";
            string s2 = "RG";
            string s3 = "RGB";
            string s4 = "RGBT";
            string s5 = "RGBTo";
            string s6 = "RGBToo";
            string s7 = "RGBTool";
            //string s8 = "Greytool";
            //string s9 = "Optimizer";
            switch (l1.Text) {
                case "":
                    l1.Text = s1;
                    break;
                case "R":
                    l1.Text = s2;
                    break;
                case "RG":
                    l1.Text = s3;
                    break;
                case "RGB":
                    l1.Text = s4;
                    break;
                case "RGBT":
                    l1.Text = s5;
                    break;
                case "RGBTo":
                    l1.Text = s6;
                    break;
                case "RGBToo":
                    l1.Text = s7;
                    t1.Stop();
                    t2.Start();
                    break;
                case "RGBTool":
                    l1.Text = s0;
                    break;
                //case "RGBTool":
                //    l1.Text = s0;
                //    break;
                // case "Optimizer":
                //     l1.Text = s0;
                //     break;
            }
        }

        private void t2_Tick(object sender, EventArgs e) {

            string s0 = "";
            string s1 = "R";
            string s2 = "RG";
            string s3 = "RGB";
            string s4 = "RGBT";
            string s5 = "RGBTo";
            string s6 = "RGBToo";
            string s7 = "RGBTool";
            string s8 = "RGBTool ©";
            string s9 = "RGBTool © ∞";
            //string s10 = "deadmoon © ∞";
            switch (l2.Text) {
                case "":
                    l2.Text = s1;
                    break;
                case "R":
                    l2.Text = s2;
                    break;
                case "RG":
                    l2.Text = s3;
                    break;
                case "RGB":
                    l2.Text = s4;
                    break;
                case "RGBT":
                    l2.Text = s5;     
                    break;
                case "RGBTo":
                    l2.Text = s6;
                    break;
                case "RGBToo":
                    l2.Text = s7;
                    break;
                case "RGBTool":
                    l2.Text = s8;
                    break;
                case "RGBTool ©":
                    l2.Text = s9;
                    break;
                case "RGBTool ©  ∞":
                    l2.Text = s0;
                    t2.Stop();
                    break;
                //case "deadmoon © ∞":
                //    l2.Text = s0;
                //    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/paimon3107/codeapp");
        }
    }
}
