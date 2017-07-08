using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Livraria.Repositories.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Livraria.Controllers
{
    public class LivrosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LivrosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var livros = _unitOfWork.Livros.GetAll();
            return View(livros);
        }
    }
}
