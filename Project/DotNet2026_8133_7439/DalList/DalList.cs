using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;

namespace Dal;

public class DalList:IDal
{
    public Isale sale => new ImplementationSale();
    public Iproduct product => new ImplementationProduct();
    public Icustomer customer => new ImplementationCustomer();
}
