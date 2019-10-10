using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class NameJoiner
    {
        public string Join(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}