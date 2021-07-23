using System;

namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new System.Collections.Generic.List<Models.Person>
            {
                new Models.Person{ Name = "Arash" },
                new Models.Person{ Name = "Mohsen" },
            };

            var groups = new System.Collections.Generic.List<Models.Group>
            {
                new Models.Group
                {
                    Name = "Developers",
                    Nodes = new System.Collections.Generic.List<Composite.INode>
                    {
                        new Models.Person{ Name = "Alireza" },
                        new Models.Person{ Name = "Amir" },
                        new Models.Group
                        {
                            Name = "Teacher",
                            Nodes = new System.Collections.Generic.List<Composite.INode>
                            {
                                new Models.Person{ Name = "Iman" },
                                new Models.Person{ Name = "Mehrdad" },
                            }
                        }
                    }
                }
            };

            var items = new System.Collections.Generic.List<Composite.INode>();
            items.AddRange(people);
            items.AddRange(groups);

            int score = 1000;
            int count = items.Count;
            int individualScore = score / count;
            foreach (var item in items)
            {
                item.Score = individualScore;
            }

        }
    }
}
