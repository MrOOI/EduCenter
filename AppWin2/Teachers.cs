using AppWin2.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWin2
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

         List<Teacher> teach = new List<Teacher>();
        private void Teachers_Load(object sender, EventArgs e)
        {
            
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate", 1));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate", 2));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate", 3));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate", 4));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate", 5));
            dataGridView1.DataSource = teach;            

            dataGridView1.EndEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(rowindex);
        }
    }
}
