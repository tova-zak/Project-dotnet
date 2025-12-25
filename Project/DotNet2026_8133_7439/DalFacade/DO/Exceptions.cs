using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

internal class Exceptions:Exception
{
  public ItemNotFoundException(string message) 
            : base(message) 
        { 
        }

    public CustomerApperException(string message)
            : base(message)
    {
    }

}
//using System;

//namespace DO
//{
//    // Custom exception for item not found
//    internal class ItemNotFoundException : Exception
//    {
//        public ItemNotFoundException(string message)
//            : base(message)
//        {
//        }
//    }

//    // Custom exception for customer appearance related issues
//    internal class CustomerApperException : Exception
//    {
//        public CustomerApperException(string message)
//            : base(message)
//        {
//        }
//    }
//}
