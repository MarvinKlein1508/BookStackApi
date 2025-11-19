namespace BookStackApi.Core
{
    public class Filter
    {
        public FilterOperator Operator { get; set; }

        public string Field { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        public string AsQueryField()
        {
            return $"&filter[{Field.ToSnakeCase()}:{translateOperator(Operator)}]={Value.UrlSafe()}";
        }

        private string translateOperator(FilterOperator filterOperator)
        {
            return filterOperator switch
            {
                FilterOperator.Equals => "eq",
                FilterOperator.NotEquals => "ne",
                FilterOperator.GreaterThan => "gt",
                FilterOperator.LessThan => "lt",
                FilterOperator.GreaterThanOrEqual => "gte",
                FilterOperator.LessThanOrEqual => "lte",
                FilterOperator.Like => "like",
                _ => throw new ArgumentOutOfRangeException("filterOperator", filterOperator, null),
            };
        }
    }
}