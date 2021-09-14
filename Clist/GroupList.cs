using System;
using System.Collections.Generic;
using System.Linq;

namespace Clist
{
    public class GroupList
    {
        public static Dictionary<string, List<string>> GroupsTopics(List<string> Person, List<string> Topic)
        {
            if(Person==null||!Person.Any()||Topic==null||!Topic.Any())
            {
                throw new IndexOutOfRangeException();
            }
            var Group = new Dictionary<List<string>, List<string>>();



            //return new Dictionary<string, List<string>>();
        }
    }
}
