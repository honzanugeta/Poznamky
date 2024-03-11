using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Poznamky
{
    public partial class MainForm : Form
    {
        Poznamkasmllaview selectedpoznamka = null;
        public MainForm()
        {
            InitializeComponent();
            poznamkaView1.PoznamkaDeleted += () =>
            {
                CreatePoznamkasViews();
                poznamkaView1.Hide();
            };
            poznamkaView1.Hide();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataManager.Instance.LoadProjects();
            fillfilter();

            DataManager.Instance.loadPoznamkas();
            CreatePoznamkasViews();
        }

        private void CreatePoznamkasViews()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var poznamka in DataManager.Instance.PoznamkaList)
            {
                CreatePoznamkaView(poznamka);
            }
        }

        private void CreatePoznamkaView(Poznamka poznamka)
        {
            Poznamkasmllaview smamllpoznamka = new Poznamkasmllaview();
            smamllpoznamka.Setupoznamka(poznamka);
            smamllpoznamka.PoznamkaSelected += OnPoznamkaSelected;
            flowLayoutPanel1.Controls.Add(smamllpoznamka);
        }

        private void OnPoznamkaSelected(Poznamkasmllaview view)
        {
            if (selectedpoznamka != null)
            {
                selectedpoznamka.BackColor = SystemColors.Control;
            }
            selectedpoznamka = view;
            poznamkaView1.SetPoznamka(view.Data);
            view.BackColor = Color.LightBlue;
            poznamkaView1.Show();
        }
        
        private void fillfilter()
        {
            comboBox1.Items.Clear();
            foreach (var project in DataManager.Instance.ProjectList)
            {
                comboBox1.Items.Add(project);
            }
        }

        private void projectManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagerForm projectForm = new ProjectManagerForm();
            projectForm.ShowDialog();
            fillfilter();
        }

        private void přidatPoznámkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPoznamkaFoem addPoznamka = new AddPoznamkaFoem();
            addPoznamka.ShowDialog();

            CreatePoznamkasViews();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            if (item != null)
            {
                var selectedProject = item as Project;
                var id = selectedProject.Id;
                foreach (var control in flowLayoutPanel1.Controls)
                {
                    var smallView = control as Poznamkasmllaview;
                    if (smallView.Data.ProjectId == id)
                    {
                        smallView.Visible = true;
                    }
                    else
                    {
                        smallView.Visible = false;
                    }
                }
            }
        }
    }
}
