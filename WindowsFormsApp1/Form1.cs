using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class todolist : Form
    {
        public todolist()
        {
            InitializeComponent();
        }

        private void todolist_Load(object sender, EventArgs e)
        {
            
        }
        private void ChcEkle1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChcEkle1.Checked && !listBox1.Items.Contains(TxtMessage1.Text))
            {
                listBox1.Items.Add(TxtMessage1.Text);
                MessageBox.Show("eklenme tarihi " + DateTime.Now.ToString());     
            }
            else if (!ChcEkle1.Checked)
            {
                listBox1.Items.Remove(TxtMessage1.Text);
            }
        }
        private void ChcEkle2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChcEkle2.Checked && !listBox1.Items.Contains(TxtMessage2.Text))
            {
                listBox1.Items.Add(TxtMessage2.Text);
                MessageBox.Show("eklenme tarihi " + DateTime.Now.ToString());
            }
            else if (!ChcEkle2.Checked)
            {
                listBox1.Items.Remove(TxtMessage2.Text);
            }
        }
        private void ChcEkle3_CheckedChanged(object sender, EventArgs e)
        {           
            if (ChcEkle3.Checked && !listBox1.Items.Contains(TxtMessage3.Text))
            {
                listBox1.Items.Add(TxtMessage3.Text);
                MessageBox.Show("eklenme tarihi " + DateTime.Now.ToString());
            }
            else if (!ChcEkle3.Checked)
            {
                listBox1.Items.Remove(TxtMessage3.Text);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
