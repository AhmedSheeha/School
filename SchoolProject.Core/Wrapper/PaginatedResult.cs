using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Wrapper
{
    public class PaginatedResult<T>
    {
        public List<T> Data { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public int TotalCount { get; set; }
        public object Meta {  get; set; }
        public List<String> Messages { get; set; } = new();
        public bool Succeeded { get; set; }

        public PaginatedResult(List<T> data)
        {
            Data = data;
        }
        internal PaginatedResult(bool succeded, List<T> data = default, List<string> messages = null, int count = 0, int page = 1, int pageSize = 10 )
        {
            Data = data;
            PageSize = pageSize;
            CurrentPage = page;
            TotalPages = (int)Math.Ceiling(count / (double)(pageSize));
            Succeeded = succeded;
            Messages = messages;

        }
        public static PaginatedResult<T> Success(List<T> data, int count, int page, int pageSize)
        {
            return new (true, data, null, count, page, pageSize);
        }
    }
}
