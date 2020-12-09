using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Participation4.Models
{
    public class StudentRepository
    { 
        List<StudentModel> myStudents = new List<StudentModel>();
        public StudentRepository()
        {
            myStudents.Add(new StudentModel(0, "Reed", 12));
            myStudents.Add(new StudentModel(1, "Bryen", 16));
            myStudents.Add(new StudentModel(2, "Whatshisface", 24));
        }

        public List<StudentModel> getAllStudents()
        {
            return myStudents;
        }

        //
    }
}
