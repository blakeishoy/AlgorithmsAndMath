using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlakeIshoyAlgorithms.Utility
{
    public static class ListOfListComparer
    {
        public static bool Compare(IList<IList<int>> list1, List<List<int>> list2)
        {
            var same = true;
            var matchFound = false;
            foreach (var listA in list1)
            {
                listA.OrderBy(l => l);
                foreach (var listB in list2)
                {
                    listB.OrderBy(l => l);
                    if (listA.SequenceEqual(listB))
                    {
                        matchFound = true;
                    }
                }
                if (!matchFound)
                {
                    same = false;
                }
            }
            return same;
        }
    }
}
