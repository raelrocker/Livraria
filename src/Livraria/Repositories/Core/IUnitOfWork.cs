using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ILivroRepository Livros { get; }
        int Complete();
    }
}
