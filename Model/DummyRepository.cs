using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model
{
    public class DummyRepository
    {
        public ObservableCollection<Family> GetFamilies()
        {

            var fam1 = new Family()
            {
                Name = "Hickey",
                FamilyMembers = new ObservableCollection<Member>
                {
                    new Member()
                    {
                        Name = "Alex",
                        Toys = new ObservableCollection<Toy>
                        {
                            new Toy{Name = "PC"},
                            new Toy{Name = "iPad"},
                            new Toy{Name = "DSI"}

                        }
                    },
                    new Member()
                    {
                        Name = "Sam",
                        Toys = new ObservableCollection<Toy>
                        {
                            new Toy{Name = "Chin up frame"},
                            new Toy(){Name="Bench press bench"},
                            new Toy(){Name = "iPad"}
                        }

                    }
                }
            };


            var fam2 = new Family()
            {
                Name = "Bennett",
                FamilyMembers = new ObservableCollection<Member>
                {
                    new Member()
                    {
                        Name = "Bernie",
                        Toys = new ObservableCollection<Toy>
                        {
                            new Toy{Name = "Facebook"},
                            new Toy{Name = "Garden"},
                            new Toy{Name = "Cats"}

                        }
                    },
                    new Member()
                    {
                        Name = "Dan",
                        Toys = new ObservableCollection<Toy>
                        {
                            new Toy{Name = "Aloe Vera"},
                            new Toy(){Name="Running shoes"},
                            new Toy(){Name = "Canoe"}
                        }

                    }
                }
            };



            var families = new ObservableCollection<Family>
            {
                fam1,
                fam2
            };

            return families;
        }
    }
}
