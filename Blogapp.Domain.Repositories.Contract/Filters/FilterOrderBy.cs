using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.IRepositories.Filters
{
    public class FilterOrderBy
    {
        public const string asc = "asc";

        public string Column { get; set; }
        public string Direction { get; set; }
        public bool OrderByDate { get; set; }
        public string ColumnAndDirection { get { return Column + " " + Direction; } }
    }
}
