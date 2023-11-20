using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RostrosFelices.Models
{
    internal class Servicio

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Empleado { get; set; }


        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
