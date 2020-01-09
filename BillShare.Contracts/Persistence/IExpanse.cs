using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts.Persistence
{
    interface IExpanse : IIdentifiable, ICopyable<IExpanse>
    {
        int BillId { get; set; }
        string Designation { get; set; }
        double Amount { get; set; }
        string Friend { get; set; }
    }
}
