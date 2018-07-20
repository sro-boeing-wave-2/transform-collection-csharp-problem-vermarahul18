using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] array,Func<int,int> Operation)
        {
            List<int> li = new List<int>(); 
            foreach (int x in array) {
                li.Add(Operation(x));
            }
            return li;
 

            throw new NotImplementedException();
        }
    }
}
