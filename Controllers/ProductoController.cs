using Formulario.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formulario.Controllers
{
    public class ProductoController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(Producto objproduc)
        {
            decimal subtotal=0;
            decimal ventat=0;
            decimal igv=1.18m;
            ViewData["Message"] = "Sin resultado";
            subtotal=objproduc.Precio*objproduc.Cantidad;
            ViewData["Subtotal"] = "El subtotal de la venta es "+decimal.Round(subtotal,2);
            ventat=subtotal * igv;
            ViewData["VentaT"] = "El total de venta es "+decimal.Round(ventat,2);
            ViewData["Nombre"] = "Sen vendio "+objproduc.Cantidad+" unidades del producto "+objproduc.Nombre+" por la cantidad de "+decimal.Round(ventat,2);
            return View("Index");
        }
    }
}