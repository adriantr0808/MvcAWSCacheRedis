using Microsoft.AspNetCore.Mvc;
using MvcAWSCacheRedis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAWSCacheRedis.Controllers
{
    public class ProductosController : Controller
    {
        private Repositories.RepositoryProductos repo;

        public ProductosController(Repositories.RepositoryProductos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Producto> prs = this.repo.GetProductos();
            return View(prs);
        }

        public IActionResult Details(int id)
        {
            Producto p = this.repo.FindProducto(id);
            return View(p);
        }
    }
}
