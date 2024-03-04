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
    public partial class NewTask : Form
    {
        private Dictionary<string, Task> dataDictionary = new Dictionary<string, Task>(); 
        public NewTask(ref Dictionary<string ,Task> redDICtionary )
        {
            InitializeComponent();
            dataDictionary = redDICtionary; 
        }

        private void NewTask_Load(object sender, EventArgs e)
        {

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            string title = titletx.Text;
            string data = datatx.Text;
            Task task = new Task(title,data);

            dataDictionary.Add(title,task);
            this.Close();
   

        }
    }
}
