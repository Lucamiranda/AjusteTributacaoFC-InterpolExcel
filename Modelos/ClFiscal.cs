using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjusteProdutos.Modelos
{
    public class ClFiscal
    {
        public string NCM { get; set; }
        public string CST { get; set; }
        public string aliquotaICMS { get; set; }
        public string codigoPIS { get; set; }
        public string aliquotaPIS { get; set; }
        public string codigoCOFINS { get; set; }
        public string aliquotaCOFINS { get; set; }
        public string codigoIPI { get; set; }
        public string aliquotaIPI { get; set; }
        public string CFOP { get; set; }
        public string listaPisCofins { get; set; }
        public string grupoProduto { get; set; }
    }
}
