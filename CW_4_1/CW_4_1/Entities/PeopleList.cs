using CW_4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4_1.Entities
{
    public class PeopleList
    {
        public static List<Person> people = new List<Person>()
        {
            new Person()
            {Name="n1",Address="ad1",Age=20,EmailAddress ="e1", City="tehran",
            Gender=0, Id=1 , Mobile =9123456 ,NationalCode=1111},
            new Person()
            {Name="n2",Address="ad2",Age=33,EmailAddress ="e2", City="shiraz",
            Gender=1, Id=2 , Mobile =9123424,NationalCode=2222},
            new Person()
            {Name="n3",Address="ad3",Age=12,EmailAddress ="e3", City="babol",
            Gender=0, Id=2 , Mobile =9122222 ,NationalCode=333},
            new Person()
            {Name="n4",Address="ad4",Age=44,EmailAddress ="e4", City="shiraz",
            Gender=0, Id=1 , Mobile =9123333 ,NationalCode=4444}
        };
    }
}
