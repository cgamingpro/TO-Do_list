using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ALLTOOOLS
{
    public partial class Form1 : Form
    {
        Dictionary<string,Task> todo = new Dictionary<string,Task>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            BackColor = Color.Aqua;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NewTask NewTaskForm = new NewTask(ref todo);
            NewTaskForm.Show();
        }

        private void TitleLb_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var key in todo)
            {
                //MessageBox.Show(key.Key);

                comboBox1.Items.Add(key.Key);
            }
        }

        private void LoadTaskBt_Click(object sender, EventArgs e)
        {
            string seleccted = "";
            Task task;
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("somting sometin");
            }
            else
            {
                seleccted = comboBox1.SelectedItem.ToString();
                task = todo[seleccted];
                headTb.Text = task.name;
                datatb.Text = task.data;
            
            }
            
        }

        private void DontBt_Click(object sender, EventArgs e)
        {
            todo.Remove(comboBox1.SelectedItem.ToString());
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            headTb.Clear();
            datatb.Clear();
        }
    }
}
