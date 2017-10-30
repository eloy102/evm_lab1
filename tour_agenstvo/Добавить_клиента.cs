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
    public partial class Добавить_клиента : Form
    {
        public Добавить_клиента()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                Clients clients = new Clients(id,textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value.ToString(), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToDouble(textBox6.Text));
                DataBaseWork.add_client(clients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Добавить_клиента_Load(object sender, EventArgs e)
        {

        }
    }
}
