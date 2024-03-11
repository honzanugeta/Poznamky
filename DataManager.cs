using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Poznamky
{
    public class DataManager
    {
        private static DataManager instance = new DataManager();
        public static DataManager Instance => instance;

        public IReadOnlyList<Project> ProjectList 
        { 
            get { return Projects; }
            
        }

        public IReadOnlyList<Poznamka> PoznamkaList
        {
            get { return Poznamkas; }
        }

        private DataManager() { }

        private string pathtoProjects = "Projects.json";
        private string pathtopoznamkas = "poznamkas.json";

        private List<Project> Projects = new List<Project>();

        private List<Poznamka> Poznamkas = new List<Poznamka>();

        public int getRandomProjectId()
        {
            Random r = new Random();
            int id;
            do
            {
                id = r.Next(0, 10000);
            } while(Projects.Any(p => p.Id == id)); 
            return id;
        }

        public void addproject(Project newProject)
        {
            Projects.Add(newProject);
            saveprojects();
        }
        public void removeproject(Project projectsToremove)
        {
            Projects.Remove(projectsToremove);
            saveprojects();
        }

        public void AddPoznamka(Poznamka poznamka)
        {
            Poznamkas.Add(poznamka);
            SavePoznamkas();
        }

        public void SavePoznamkas()
        {
            string dataToSave = JsonConvert.SerializeObject(Poznamkas);
            File.WriteAllText(pathtopoznamkas, dataToSave);
        }

        public void loadPoznamkas()
        {
            if (!File.Exists(pathtopoznamkas))
            {
                Poznamkas = new List<Poznamka>();
                return;
            }
            string data = File.ReadAllText(pathtopoznamkas);
            Poznamkas = JsonConvert.DeserializeObject<List <Poznamka>>(data);
            if(Poznamkas == null)
            {
                MessageBox.Show("Neda se nacist poznamky");
                Poznamkas = new List<Poznamka>();
            }
        }

        public void RemovePoznamka(Poznamka poznamka)
        {
            Poznamkas.Remove(poznamka);
            SavePoznamkas();
        }

        public void saveprojects()
        {
            string datatosave = JsonConvert.SerializeObject(Projects);
            File.WriteAllText(pathtoProjects, datatosave);
        }

        public void LoadProjects() {
            if(!File.Exists(pathtoProjects))
            {
                Projects = new List<Project>();
                return;
            }



        string datatoload = File.ReadAllText(pathtoProjects);
        Projects = JsonConvert.DeserializeObject<List<Project>>(datatoload);
            if (Projects == null)
            {
                MessageBox.Show("Neda se nacist poznamky");
                Projects = new List<Project>();
            }

        }
    }

}

