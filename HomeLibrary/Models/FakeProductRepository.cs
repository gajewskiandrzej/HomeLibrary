using System.Collections.Generic;
using System.Linq;

namespace HomeLibrary.Models
{
    public class FakeElementsRepository : IElementRepository
    {
        public IQueryable<Element> Elements => new List<Element>
        {
            new Element {Title = "C# 6.0 Kompletny przewodnik dla praktyków", Status = "Na półce"},
            new Element {Title = "C# 7.0 w pgółce", Status = "Wypożyczona"},
            new Element {Title = "WPF 4.5 Księga eksperta", Status = "Wypożyczona"}
        }.AsQueryable<Element>();
    }
}
