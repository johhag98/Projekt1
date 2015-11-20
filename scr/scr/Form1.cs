using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //För att läsa in alla tal, kolla om talet är en int, om inte blir bool false.
            string text1 = tbxTal1.Text;
            int tal1;
            bool test1 = int.TryParse(text1, out tal1);
            
            string text2 = tbxTal2.Text;
            int tal2;
            bool test2 = int.TryParse(text2, out tal2);

            string text3 = tbxTal3.Text;
            int tal3;
            bool test3 = int.TryParse(text3, out tal3);

            string text4 = tbxTal4.Text;
            int tal4;
            bool test4 = int.TryParse(text4, out tal4);

            string text5 = tbxTal5.Text;
            int tal5;
            bool test5 = int.TryParse(text5, out tal5);

            //Kolla om någon bool är false.
            if (test1 == false || test2 == false || test3 == false || test4 == false || test5 == false)             
            {
                //Om någon bool är false öppnas en messagebox.
                MessageBox.Show("Du måste skriva in ett heltal!", "Medelande",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //För att Lägga alla tal i en array och välja ut det största talet.
            int[] array1 = { tal1, tal2, tal3, tal4, tal5 };
            int max = array1.Max();

            //För att skriva ut det största talet.
            lblAns.Text = "Svar: " + max; 
            

        }
    }
}
