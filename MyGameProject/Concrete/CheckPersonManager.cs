using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public class CheckPersonManager : ICheckPerson
    {
        public bool CheckPerson(Person person)
        {
            return true;
        }
    }
}