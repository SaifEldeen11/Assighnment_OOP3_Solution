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
        #region Attributes & Prop
        private int _id;
        public int Id
        {
            get { return _id; }

            set {
                if (value >= 0 && int.TryParse(value.ToString(), out value))
                {
                    _id = value;
                }
            }
        }

        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }

            set {
                if(_name is not null)
                _name = value; 
                }
        }

        private double _salary;
        public double Salary
        {
            get { return _salary; }

            set {
                if(_salary>=0&& double.TryParse(value.ToString(), out value))
                _salary = value; 
                }
        }

        private string _hiringDate = string.Empty;
        public string HiringDate
        {
            get { return _hiringDate; }
            set
            {
                if (value is not null)
                    _hiringDate = value;
            }
        }

        private SecurityLevel _accessLevel;
        public SecurityLevel AccessLevel
        {
            get { return _accessLevel; }
            set
            {
                if (Enum.IsDefined(typeof(SecurityLevel), value))
                    _accessLevel = value;
            }
        }
        #endregion

        #region Constructors
        public Employee() : this(0, "NoName", 0.0, string.Empty, SecurityLevel.None)
        {
        }

        public Employee(int id, string name) : this(id, name, 0.0, string.Empty, SecurityLevel.None)
        {
        }

        public Employee(int id, string name, SecurityLevel accessLevel) : this(id, name, 0.0, string.Empty, accessLevel)
        {
        }

        public Employee(string name, SecurityLevel accessLevel) : this(0, name, 0.0, string.Empty, accessLevel)
        {
        }

        public Employee(int id, string name, double salary, string hiringDate, SecurityLevel accessLevel)
        {
            Id = id;
            Name = name ?? "NoName";
            Salary = salary;
            HiringDate = hiringDate ?? string.Empty;
            AccessLevel = accessLevel;
        }
        #endregion

        #region Enums
        public enum SecurityLevel : byte
        {
            None = 0,
            Guest = 1,
            Developer = 2,
            Secretary = 4,
            DBA = 16,
            Officer = Guest | Developer | Secretary | DBA
        }

        public enum Gender : byte
        {
            M = 1,
            F = 2,
            m = M,
            f = F,
        }
        #endregion

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:C}, HiringDate: {HiringDate}, AccessLevel: {AccessLevel}";
        }
    }


    #endregion

    #region HiringDate
    internal class HiringDate
    {
        public string Years { get; set; } = string.Empty;
        public string Months { get; set; } = string.Empty;

        public string Days { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Years: {Years} , Months: {Months} ,Days: {Days} ";
        }
        #endregion

    }
}
