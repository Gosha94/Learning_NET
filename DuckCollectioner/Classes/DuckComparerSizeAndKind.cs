using DuckCollectioner.Enums;
using System.Collections.Generic;

namespace DuckCollectioner.Classes
{
    class DuckComparerSizeAndKind : IComparer<Duck>
    {
        public SortCriteries SortBy = SortCriteries.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteries.SizeThenKind)
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
            else
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
        }
    }
}
