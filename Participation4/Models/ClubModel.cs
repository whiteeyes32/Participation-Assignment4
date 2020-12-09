using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Participation4.Models
{
    public class ClubModel
    {
        private int id;
        private string name;
        private string facultyAdvisor;

        public ClubModel(int id, string name, string facultyAdvisor)
        {
            this.id = id;
            this.name = name;
            this.facultyAdvisor = facultyAdvisor;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string FacultyAdvisor { get => facultyAdvisor; set => facultyAdvisor = value; }
    }
}
