using AplicacaoMVClinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVClinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Bob", "bob@example.com", "2345-6789", new DateOnly(2001, 10, 06));
            Cliente c3 = new Cliente(3, "Charlie", "charlie@example.com", "3456-7890", new DateOnly(1999, 12, 06));
            Cliente c4 = new Cliente(4, "David", "david@example.com", "4567-8901", new DateOnly(2000, 12, 01));
            Cliente c5 = new Cliente(5, "Eve", "eve@example.com", "5678-9012", new DateOnly(2000, 12, 06));
            List<Cliente> listaClientes = new List<Cliente>();
            //Adicinar os Objetos Clientes na lista Clientes
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
