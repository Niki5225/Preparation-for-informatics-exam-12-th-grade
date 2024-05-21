using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Family
    {
        List<Person> familyMembers = new List<Person>();

        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = familyMembers[0];

            foreach(Person member in familyMembers)
            {
                if (oldestMember.Age < member.Age)
                {
                    oldestMember = member;
                }
            }

            return oldestMember;
        }
    }
}
