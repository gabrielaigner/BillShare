using BillShare.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Logic.Entities.Persistence
{
    internal class Bill : IdentityObject, Contracts.Persistence.IBill
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Friends { get; set; }

        public void CopyProterties(IBill other)
        {
            throw new NotImplementedException();
        }
    }
}
