using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagementMVC.Models.Enuns
{
    public enum PaymentForm : int
    {
        Dinheiro = 0,
        Debito = 1,
        Credito = 2,
        Boleto = 3
    }
}
