namespace BookStackApi.Core
{
    public class ListParameters
    {
        private int _count;

        private int _offset;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Count", "must be greater than zero");
                }

                if (value > 500)
                {
                    throw new ArgumentOutOfRangeException("Count", "must be less than 500");
                }

                _count = value;
            }
        }

        public int Offset
        {
            get
            {
                return _offset;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Count", "must be zero or greater");
                }

                _offset = value;
            }
        }

        public SortDirection SortDirection { get; set; }

        public string SortField { get; set; }

        public List<Filter> Filters { get; }

        public ListParameters(int count = 100, int offset = 0)
        {
            Count = count;
            Offset = offset;
            SortDirection = SortDirection.Ascending;
            SortField = null;
            Filters = new List<Filter>();
        }

        public string AsQuery()
        {
            string text = $"?count={Count}&offset={Offset}";
            if (!string.IsNullOrWhiteSpace(SortField))
            {
                text = text + "&" + translateSortDirection(SortDirection) + SortField.ToSnakeCase();
            }

            foreach (Filter filter in Filters)
            {
                text += filter.AsQueryField();
            }

            return text;
        }

        private string translateSortDirection(SortDirection sortDirection)
        {
            return sortDirection switch
            {
                SortDirection.Ascending => "+",
                SortDirection.Descending => "-",
                _ => throw new ArgumentOutOfRangeException("sortDirection", sortDirection, null),
            };
        }
    }
}