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
    public partial class PoznamkaView : UserControl
    {
        private Poznamka poznamka;
        public event Action PoznamkaDeleted;
        public PoznamkaView()
        {
            InitializeComponent();

        }

        public void SetPoznamka(Poznamka data)
        {
            label1.Text = data.Headline;
            label2.Text = data.Description;
            label3.Text = $"Termín Splnění: {data.Duedate}";
            checkedListBox1.Items.Clear();
            foreach (var task in data.subtasks)
            {
                checkedListBox1.Items.Add(task);
            }
            var project = DataManager.Instance.ProjectList.First(p => p.Id == data.ProjectId);
            pictureBox1.BackColor = project.color;
            label5.Text = project.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.Instance.RemovePoznamka(poznamka);
            PoznamkaDeleted?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count)
            {
                UdelatSplenno();
            }
            else
            {
                MessageBox.Show("Nemas splněno");
            }

        }

        private void UdelatSplenno()
        {
            pictureBox1.BackColor = Color.Green;
            label1.Font = new Font(label1.Font, FontStyle.Italic);
            label4.Font = new Font(label4.Font, FontStyle.Italic);
        }
    }
}
