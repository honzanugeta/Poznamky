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
    public partial class ProjectManagerForm : Form
    {
        public ProjectManagerForm()
        {
            InitializeComponent();
        }
        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < DataManager.Instance.ProjectList.Count ; i++) {
                CreateProjectView(DataManager.Instance.ProjectList[i]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            Project newproject = new Project()
            {
                color = button1.BackColor,
                name = textBox1.Text,
                Id = DataManager.Instance.getRandomProjectId()
            };
            DataManager.Instance.addproject(newproject);
            CreateProjectView(newproject);

        }

        private void CreateProjectView(Project newproject)
        {
            ProjectView projectView = new ProjectView();
            projectView.Project = newproject;
            flowLayoutPanel1.Controls.Add(projectView);
            projectView.deleteRequested += (view) =>
            {
                flowLayoutPanel1.Controls.Remove(view);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
