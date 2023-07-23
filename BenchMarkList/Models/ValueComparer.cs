namespace BenchMarkList.Models
{
    public class ValueComparer<T> : IComparer<FoolClass>
    {
        public int Compare(FoolClass x, FoolClass y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.id == y.id ? 0 :
                     x.id > y.id ? 1 : -1;
        }

        public int CompareTo(FoolClass? other)
        {
            return 0;
        }
    }
}