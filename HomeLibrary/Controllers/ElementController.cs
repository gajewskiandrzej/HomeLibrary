using Microsoft.AspNetCore.Mvc;
using HomeLibrary.Models;
using System.Linq;
using HomeLibrary.Models.ViewModels;

namespace HomeLibrary.Controllers
{
    public class ElementController : Controller
    {
        private IElementRepository repository;
        public int PageSize = 4;

        public ElementController(IElementRepository repo)
        {
            repository = repo;
        }

        public ViewResult Elements(string status, string carries, int elementPage = 1)
            => View(new ElementsListViewModel
            {
                Elements = repository.Elements
                    .Where(p => (status == null || p.Status == status) || (carries == null || p.Carries == carries))
                    .OrderBy(p => p.IDElement)
                    .Skip((elementPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = elementPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Elements.Count()
                },
                CurrentCarries = carries,
                CurrentStatus = status
            });
    }
}