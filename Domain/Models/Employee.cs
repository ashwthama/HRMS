using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Address { get; set; }       
        public string Region { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string BloodGroup { get; set; }
        public string AadharNo { get; set; }
        public string PANNo { get; set; }
        public string ProfileImg { get; set; }
        public string Experience {  get; set; }
        public List<Tech> Techs { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary {  get; set; }


    }
    public class Tech
    {
        public string TechName {  get; set; }
        public double TechExperience { get; set;}
    }
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
