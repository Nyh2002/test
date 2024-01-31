using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Перейти в режим обучения
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Education_mode education_mode = new Education_mode();
            education_mode.Show();
        }
        //Перейти в режим контроля
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Control_mode control_mode = new Control_mode();
            control_mode.Show();
        }
    }
}
