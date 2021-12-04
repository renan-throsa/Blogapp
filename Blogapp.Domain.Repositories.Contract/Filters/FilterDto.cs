namespace Blogapp.Domain.IRepositories.Filters
{
    public class FilterDto
    {
        public FilterTypeEnum Type { get; set; }
        public string Field { get; set; }
        public object Arg { get; set; }
        public object[] MultipleArgs { get; set; }
        public bool IsMultiple { get { return MultipleArgs != null; } }
    }
}
