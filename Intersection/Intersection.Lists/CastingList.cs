using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intersection.Intersection.Casting;


namespace Intersection.Intersection.Lists
{
    public class CastingList<T> : List<T>, IEnumerable<T> where T : ICasting
    {
        public CastingList() { }

        public CastingList<T> GetIntersection(CastingList<T> other)
        {
            if (other == null)
                throw new ArgumentNullException("cannot intersect with null list");

            CastingList<T> tmp = new CastingList<T>();
            IEnumerable<T> d = this.Intersect(other);
            foreach(T cast in d){
                tmp.Add(cast);
            }
            return tmp;
        }
    }
}
