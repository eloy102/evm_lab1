using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_agenstvo
{
    public partial class Добавить_Тур : Form
    {
        public Добавить_Тур()
        {
            InitializeComponent();
        }

        private void Добавить_Тур_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            Tours tours = new Tours(id,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToDecimal(textBox5.Text));
            DataBaseWork.add_tour(tours);
            MessageBox.Show("Готово", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
