using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLibrary.Models.ViewModels
{
    public class ElementsListViewModel
    {
        public IEnumerable<Element> Elements { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCarries { get; set; }
        public string CurrentStatus { get; set; }
    }
}
