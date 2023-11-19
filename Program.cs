using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using RostrosFelicesContext context = new RostrosFelicesContext();

            //Servicio corte = new Servicio()
            //{
            //    Name = "Peluqueada",
            //    Empleado = "Carlos"
            //};

            //context.Servicios.Add(corte);


            //Servicio estetica = new Servicio()
            //{
            //    Name = "Estetica",
            //    Empleado = "Julian"
            //};

            //context.Add(estetica);

            //context.SaveChanges();

            var estetica = context.Servicios.Where(p => p.Name == "Cambio aplicado").FirstOrDefault();
            if (estetica is Servicio)
            {
                estetica.Name = "Cambio aplicado";

                context.Remove(estetica);
            }
            context.SaveChanges();
            var servicios = context.Servicios.OrderBy(p => p.Name);
            foreach( var category in servicios )
            {
                Console.WriteLine($"{category.Name} | {category.Empleado}");
            }
        }
    }
}