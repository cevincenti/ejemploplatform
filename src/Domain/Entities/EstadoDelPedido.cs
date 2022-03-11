using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliDemo.Domain.Entities
{
    public class EstadoDelPedido
    {
        public EstadoDelPedido()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pedidos> Pedidos { get; set; }

    }
}
