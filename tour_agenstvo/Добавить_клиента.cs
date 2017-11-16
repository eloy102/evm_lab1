using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

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
                string[] s1 = comboBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Clients clients = new Clients(id, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value.ToString(), textBox4.Text, Convert.ToInt32(s1[0]), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox7.Text), Convert.ToDecimal(textBox6.Text));
                DataBaseWork.add_client(clients);
                MessageBox.Show("Готово", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Добавить_клиента_Load(object sender, EventArgs e)
        {
            try
            {
                List<Tours> tour_list = DataBaseWork.ReadAllTours();
                foreach (var t in tour_list)
                {
                    comboBox1.Items.Add(t.id_tour + " " + t.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  
        {
            try
            {
                string[] s1 = comboBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<decimal> list_summ = DataBaseWork.find_summ(Convert.ToInt32(s1[0]));
                decimal sum = list_summ[0] * Convert.ToInt32(textBox5.Text) + list_summ[1] * Convert.ToInt32(textBox7.Text);
                textBox6.Text = sum.ToString();
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
