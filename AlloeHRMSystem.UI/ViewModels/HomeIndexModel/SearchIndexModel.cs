using AlloeHRMSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlloeHRMSystem.UI.ViewModels.HomeIndexModel
{
    public class SearchIndexModel
    {
        public IEnumerable<Employee> SearchR { get; set; }
        public string SearchString { get; set; }
        public bool EmptySearchResults { get; set; }
    }
}
