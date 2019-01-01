using System.Linq;

namespace HomeLibrary.Models
{
    public interface IElementRepository
    {
        IQueryable<Element> Elements { get; }
    }
}