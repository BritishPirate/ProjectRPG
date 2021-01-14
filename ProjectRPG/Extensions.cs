using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRPG {
    public static class Extensions {

        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB) {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }

        public static List<T> Join<T>(this List<T> list, List<T> b) {
            for(int i = 0; i < b.Count;i++) { list.Add(b[i]); }
            return list;
        }

    }
}
