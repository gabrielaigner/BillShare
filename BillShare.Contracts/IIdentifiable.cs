using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts
{
    public interface IIdentifiable
    {
        /// <summary>
        /// Gets the identity of the component.
        /// </summary>
        int Id { get;  }
    }
}
