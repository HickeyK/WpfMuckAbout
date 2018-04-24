using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model
{
    public class Member
    {
        public string Name { get; set; }
        public ObservableCollection<Toy> Toys { get; set; }
    }
}
