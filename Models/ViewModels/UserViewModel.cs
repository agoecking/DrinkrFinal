using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkr.Models.ViewModels
{
    public class UserViewModel
    {
        public ICollection<Carro> Carro { get; set; }
        public ICollection<Cartao> Cartao { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
    }
}
