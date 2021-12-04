using Blogapp.Domain.Entities.Constants;
using Blogapp.Domain.Entities.Entities;
using Blogapp.Domain.IRepositories.Filters;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Blogapp.Domain.Repositories.Filters
{
    public class BaseFilter : IBaseFilter
    {
        public const string DESC = "DESC";
        public const string ASC = "ASC";
        public const string NULLS_LAST = "NULLS LAST";       

        public int? RowsPerPage { get; set; }

        public List<FilterOrderBy> OrderByColumns { get; set; }

        public string Nulls { get; set; }

        public bool Paginated { get; set; }

        public int Page { get; set; }

        private int? _pageSize;
        public int PageSize
        {
            get
            {
                return _pageSize ?? RowsPerPage ?? ApplicationConstants.DefaultPageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        public long TotalCount { get; set; }

        public int PageTotal { get { return (int)Math.Ceiling((double)TotalCount / (double)PageSize); } }

        public List<FilterDto> FilterList { get; set; }

        
        public List<FilterDto> SearchFilter { get; set; }        

        public int Skipsize { get { return (Page - 1) * PageSize; } }       
        

        public BaseFilter()
        {
            Nulls = NULLS_LAST;
            Paginated = false;
            Page = 1;
            FilterList = new List<FilterDto>();
        }       
        

        public IFindFluent<T, T> Paginate<T>(IFindFluent<T, T> sortedQuery)
        {
            TotalCount = sortedQuery.CountDocuments();
            AdjustPageNumber();

            return Paginated ? sortedQuery.Skip(Skipsize).Limit(PageSize) : sortedQuery;
        }

        public void AdjustPageNumber()
        {
            var numberOfPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            Page = Page > numberOfPages ? Math.Max(numberOfPages, 1) : Page;
        }
        
    }
}
