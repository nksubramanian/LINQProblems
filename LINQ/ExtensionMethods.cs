using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            List<T> Aa = a.ToList();
            List<T> Bb = b.ToList();
            return Enumerable.Range(0, Math.Max(a.Count(), b.Count())).
                    Select(i =>
                    {
                        dynamic t1 = i < a.Count() ? Aa[i] : default(T);
                        dynamic t2 = i < b.Count() ? Bb[i] : default(T);
                        T ans = Convert.ChangeType(t1 + t2, typeof(T));
                        return ans;
                    });
        }


        public static IEnumerable<T> Multiply<T>(this T a, IEnumerable<T> b)
        {
            return b.Select(x => {
               dynamic temp=  (dynamic)x* (dynamic)a;
                T ans = Convert.ChangeType(temp, typeof(T));
                return ans;
            });

        }

    }
}
