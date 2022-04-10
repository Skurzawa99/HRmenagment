using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRmenager
{
    class GroupHelper
    {
        public static List<Group> GetGroup()
        {
            return new List<Group>
            {
                new Group{Id=0, Name = "Wszyscy"},
                new Group{Id=1, Name = "Zatrudnieni"},
                new Group{Id=2, Name = "Zwolnieni"}
            };
        }

    }
}
