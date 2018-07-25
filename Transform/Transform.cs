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
 // public static TEnumerable<TResult> Map<TSource,TResult>(this IEnumerable<TSource> x,Func<TSource,TResult> operation)
 //return x.Select(transformer);

            throw new NotImplementedException();
        }
    }
}
