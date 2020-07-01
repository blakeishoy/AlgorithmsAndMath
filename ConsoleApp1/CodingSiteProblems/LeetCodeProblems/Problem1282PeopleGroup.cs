using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BlakeIshoyAlgorithms.CodingSiteProblems.LeetCodeProblems
{
    public class Problem1282PeopleGroup : ICodingProblem<IList<IList<int>>>
    {
        // [0,1,2], [3,4,6], [5], [7,9], [8,10,12,13], [9,14]
        public IList<IList<int>> Execute()
        {
            return GroupThePeople2(new int[] { 3, 3, 3, 3, 3, 1, 3, 2, 4, 2, 4, 5, 4, 4, 5 });
        }

        public IList<IList<int>> GroupThePeople2(int[] groupSizes)
        {
            if (groupSizes.Length < 1 || groupSizes.Length > 500)
            {
                return null;
            }

            var manager = new GroupManager();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                var newPerson = new Person(i, groupSizes[i]);
                manager.AddPersonToCorrectGroup(newPerson);
            }

            return manager.GetGroupIds();
        }

        public class Person
        {
            public int Id { get; set; }
            public int Size { get; set; }

            public Person(int id, int size)
            {
                this.Id = id;
                this.Size = size;
            }
        }

        public class Group
        {
            public List<Person> Members { get; set; }
            public int Size { get; set; }

            public Group(int size)
            {
                this.Members = new List<Person>();
                this.Size = size;
            }
        }

        public class GroupManager
        {
            public List<Group> Groups { get; set; }

            public GroupManager()
            {
                this.Groups = new List<Group>();
            }

            public void AddPersonToCorrectGroup(Person newPerson)
            {
                foreach (var group in this.Groups)
                {
                    if (newPerson.Size == group.Size && group.Members.Count < group.Size)
                    {
                        group.Members.Add(newPerson);
                        return;
                    }
                }
                var newGroup = new Group(newPerson.Size);
                this.Groups.Add(newGroup);
                newGroup.Members.Add(newPerson);
            }

            public List<IList<int>> GetGroupIds()
            {
                var result = new List<IList<int>>();
                foreach (var group in this.Groups)
                {
                    result.Add(group.Members.Select(p => p.Id).ToList());
                }
                return result;
            }
        }

    }
}
