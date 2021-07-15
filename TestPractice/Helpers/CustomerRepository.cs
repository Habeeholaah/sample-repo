using STUDENTPORTAL.Models;
using STUDENTPORTAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STUDENTPORTAL.Helpers
{
    public class StudentRepository : IStudentRepository
    {
        public StudentInformation GetStudent(int Id)   // implementing inherited method by adding body
        {
            StudentInformation studentInformation = new StudentInformation();

            return studentInformation;
        }

        public void Save(StudentInformation studentInformation)
        {

        }
    }
}

