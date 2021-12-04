using Blogapp.Domain.Entities.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Blogapp.Domain.IRepositories.Filters
{
    public interface IBaseFilter
    {        
        List<FilterDto> FilterList { get; set; }        
        string Nulls { get; set; }        
        
       
        int Page { get; set; }
        int PageSize { get; set; }
        int PageTotal { get; }
        bool Paginated { get; set; }
        int? RowsPerPage { get; set; }
        int Skipsize { get; }
        long TotalCount { get; set; }

        void AdjustPageNumber();       
    }
}
