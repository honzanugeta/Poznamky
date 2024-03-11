using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poznamky
{
    public partial class AddPoznamkaFoem : Form
    {
        public AddPoznamkaFoem()
        {
            InitializeComponent();
        }
        private void AddPoznamkaFoem_Load(object sender, EventArgs e)
        {
            foreach (var project in DataManager.Instance.ProjectList)
            {
                comboBox1.Items.Add(project);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text)) { return; }
            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poznamka newpozbamka = new Poznamka();
            newpozbamka.Headline = textBox1.Text;
            newpozbamka.Description = richTextBox1.Text;
            newpozbamka.Duedate = dateTimePicker1.Value;

            var project = comboBox1.SelectedItem as Project;
            if(project == null) {
                MessageBox.Show("Vyber projekt ty kokos");
                return;
            }
            newpozbamka.ProjectId = project.Id;

            List<string> subtasks = new List<string>();
            foreach(var item in listBox1.Items)
            {
                subtasks.Add(item.ToString());
            }

            newpozbamka.subtasks = subtasks;

            DataManager.Instance.AddPoznamka(newpozbamka);
            this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected != null)
            {
                listBox1.Items.Remove(selected);
            }
        }
    }
}
