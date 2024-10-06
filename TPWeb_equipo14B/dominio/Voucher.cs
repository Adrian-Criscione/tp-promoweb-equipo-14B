using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaCanje { get; set; }
        public int IdArticulo { get; set; }

        public Voucher(string codigoVoucher, int idCliente, DateTime fechaCanje, int idArticulo)
        {
            CodigoVoucher = codigoVoucher;
            IdCliente = idCliente;
            FechaCanje = fechaCanje;
            IdArticulo = idArticulo;
        }

        public Voucher()
        {
        }

    }
}
