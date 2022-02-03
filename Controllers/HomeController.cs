using laboratorio0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laboratorio0.Controllers
{
    public class HomeController : Controller
    {
        //Variables
        Clientes cliente1;
        Clientes cliente2;
        Clientes cliente3;
        List<Clientes> ListaClientes;

        private readonly ILogger<HomeController> _logger;

        //Constructor
        public HomeController(ILogger<HomeController> logger)
        {
            //Inicializar variables/Objetos
            cliente1 = new Clientes
            {
                nombre = "Sebastian",
                apellido = "Reyes",
                telf = 25150099,
                descrip = "Compra naranjas"
            };
            cliente2 = new Clientes
            {
                nombre = "Joseph",
                apellido = "Osorio",
                telf = 19283711,
                descrip = "Compra manzanas"
            };
            cliente3 = new Clientes
            {
                nombre = "Jose",
                apellido = "Perez",
                telf = 98786745,
                descrip = "Compra peras"
            };
            ListaClientes = new List<Clientes>();
            ListaClientes.Add(cliente1);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);
        }

        //Metodo principal - Main
        public List<Clientes> Index()
        {
            return ListaClientes;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}