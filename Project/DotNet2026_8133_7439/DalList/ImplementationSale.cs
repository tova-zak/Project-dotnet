
using DalApi;
using DO;
using static Dal.DataSource;
using DalList;

namespace Dal;

class ImplementationSale : Isale
{

    public int Create(
        int SaleId,
    int ProductId,
    int ProductsCountToSale,
    int PriceAfterSale,
    bool OnlyClubCustomers,
    DateTime? DateStart,
    DateTime? DateEnd
)
    {
        Sale sale = new (Config.GetNextSaleId(),
     ProductId,
     ProductsCountToSale,
     PriceAfterSale,
     OnlyClubCustomers,
      DateStart,
      DateEnd
);
        Sales.Add(sale);
        return sale.ProductId;
    }
    public Sale? Read(int id)
    {
        foreach (Sale s in Sales)
        {
            if (s.SaleId == id)
                return s;
        }
        return null;
    }



    public List<Sale> ReadAll()
    {
        return Sales;
    }
    public void Update(Sale item)
    {
        int itemIndex = Sales.FindIndex(p => p?.SaleId == item.SaleId);
        Sales[itemIndex] = item;

    }

    public void Delete(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.SaleId == id);
        Sales.RemoveAt(itemIndex);
    }

}

