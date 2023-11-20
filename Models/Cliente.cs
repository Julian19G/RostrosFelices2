using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RostrosFelices.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Servicio> Servicios { get; set; }
    }
}
