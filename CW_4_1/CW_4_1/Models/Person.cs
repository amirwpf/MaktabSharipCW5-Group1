using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4_1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NationalCode { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }


        public override string ToString()
        {
            string outPut = "";
            outPut += $"id ={Id} - Name: {Name} - City: {City} - Age: {Age}";
            return outPut;
        }
    }
}
