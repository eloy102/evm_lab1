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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<Tours> list = new List<Tours>();
                list = DataBaseWork.ReadAllTours();
                foreach (var l in list)
                {
                    listBox1.Items.Add("Название:" + l.Name + " Страна:" + l.Country + " Город:" + l.Sity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
