using System.Collections.Generic;
using System.Linq;

namespace HomeLibrary.Models
{
    public class EFElementRepository : IElementRepository
    {
        private ApplicationDbContext context;

        public EFElementRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Element> Elements => context.Elements;
    }
}
