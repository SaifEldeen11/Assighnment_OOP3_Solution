using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighnment_OOP3
{
    #region Employee
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public double Salary { get; set; }

        public string HiringDate { get; set; } = string.Empty;

        public securityLeve securityLeve { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name},Salary: {Salary:c},HiringDate: {HiringDate} , ,Security Level: {securityLeve}";
        }

    }
    [Flags]
    enum securityLeve : byte
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 16
    }
    [Flags]
    enum Gender : byte
    {
        M = 1,
        F = 2,
        m = M,
        f = F,
    }
    #endregion

    #region HiringDate

    #endregion
}
