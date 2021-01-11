using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_Csharp_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            bool isCheck = true;
            isCheck = false;

            int one = 1;
            int two = 2;

            isCheck = one < two;
            isCheck = one > two;
            isCheck = one == two;
            isCheck = one != two;

            this.checkBoxControl.Checked = isCheck;

        }

        /// <summary>
        /// ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonControl_Click(object sender, EventArgs e)
        {
            if (this.checkBoxControl.Checked)
            {
                this.labelControl.Text = "ON";
            }
            else
            {
                this.labelControl.Text = "0FF";
            }
        }
    }
}
