using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    //public record Money
    //{
    //    //immutable bir nesne: Nesne oluşturulduktan sonra bir daha verileri set edemezsiniz.
    //    public Money(decimal amount, string currency)
    //    {
    //        Amount = amount;
    //        Currency = currency;
    //    }
    //    public decimal Amount { get; init; }
    //    public string Currency { get; init; }
    //}

    public record Money(decimal Amount, string Currency);
}
