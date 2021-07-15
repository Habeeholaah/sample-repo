using STUDENTPORTAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STUDENTPORTAL.Repository
{
    public interface IStudentRepository
    {
        StudentInformation GetStudent(int Id);

        void Save(StudentInformation studentInformation);

    }
}
