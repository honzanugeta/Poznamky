using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poznamky
{
    public class Poznamka
    {
        public string Headline { get; set; }
        public string Description { get; set; }
        public DateTime Duedate { get; set; }
        public int ProjectId { get; set; }
        public List<string> subtasks { get; set; }
    }
}
