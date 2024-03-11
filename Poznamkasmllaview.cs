using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poznamky
{
    public partial class Poznamkasmllaview : UserControl
    {
        Poznamka data;
        public Poznamka Data { get { return data; } }

        public event Action<Poznamkasmllaview> PoznamkaSelected;
        public Poznamkasmllaview()
        {
            InitializeComponent();
        }

        public void Setupoznamka(Poznamka poznamka)
        {
            data = poznamka;
            label1.Text = data.Headline;
            label2.Text = data.Duedate.ToString();
            pictureBox1.BackColor = DataManager.Instance.ProjectList.First(p => p.Id == data.ProjectId).color;
        }

        private void Poznamkasmllaview_Click(object sender, EventArgs e)
        {
            PoznamkaSelected?.Invoke(this);
        }
    }
}
