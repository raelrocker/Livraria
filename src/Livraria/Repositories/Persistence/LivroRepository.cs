using Livraria.Models;
using Livraria.Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Repositories.Persistence
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(AppDbContext contect)
            :base(contect)
        { }

        public AppDbContext AppDbContext
        {
            get { return Context as AppDbContext; }
        }
    }
}
