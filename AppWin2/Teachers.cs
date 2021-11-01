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

        private void Teachers_Load(object sender, EventArgs e)
        {
            List<Teacher> teach = new List<Teacher>();
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate"));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate"));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate"));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate"));
            teach.Add(new Teacher("Ajikiki", "jhdsbchsdc", "math", "Intermediate"));
            dataGridView1.DataSource = teach;            

            dataGridView1.EndEdit();
        }
    }
}
