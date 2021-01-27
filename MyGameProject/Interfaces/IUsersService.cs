using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public interface IUsersService
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
