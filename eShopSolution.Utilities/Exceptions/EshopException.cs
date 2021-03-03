using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Exceptions
{
    public class EshopException : Exception
    {
        public EshopException()
        {
        }

        public EshopException(string message)
            : base(message)
        {
        }

        public EshopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
