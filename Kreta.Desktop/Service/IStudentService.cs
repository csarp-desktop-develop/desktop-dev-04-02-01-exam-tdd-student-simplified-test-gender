using Kreta.Desktop.Models;
using System;

namespace Kreta.Desktop.Service
{
    public interface IStudentService
    {
        public int GetNumberOfWomen();
        public int GetNumberOfWomen(int year, SchoolClassType type);
        public int GetNumberOfMen();
        public int GetNumberOfMen(int year, SchoolClassType type);
        public Guid GetYoungestStudent();
        public Guid GetYoungestStudent(bool gender);
        public Guid GetOldestStudent();
        public Guid GetOldestestStudent(bool gender);
        public double GetAvgAge(int year, SchoolClassType type);
    }
}
