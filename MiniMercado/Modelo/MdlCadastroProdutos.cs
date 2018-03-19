using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MdlCadastroProdutos
    {
        public int     Codigo   { get; set; }
        public string  Produto  { get; set; }
        public decimal Preco    { get; set; }
        public int     QTD      { get; set; }
    }
}
