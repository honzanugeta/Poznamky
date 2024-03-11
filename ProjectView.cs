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
    public partial class ProjectView : UserControl
    {
        private Project project;

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataManager.Instance.PoznamkaList.Any(p => p.ProjectId == project.Id))
            {
                MessageBox.Show("Nemazu to");
                return; 
            }
            DataManager.Instance.removeproject(project);
            deleteRequested.Invoke(this);
        }

        public Project Project
        {
            get { return project; }
            set
            {
                project = value;
                
                pictureBox1.BackColor = project.color;
                label1.Text = project.name;
            }
        }
        public event Action<ProjectView> deleteRequested;
        public ProjectView()
        {
            InitializeComponent();
        }
    }
}
