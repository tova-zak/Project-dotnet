
using DalApi;
using DO;
using static Dal.DataSource;
using DalList;

namespace Dal;

class ImplementationSale : Isale
{

    public int Create(Sale item)
                                              
    {

        Sales.Add(item);
        return item.ProductId;
    }
    public Sale? Read(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.SaleId == id);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");

        }
        return Sales[itemIndex];

    }




    public List<Sale> ReadAll()
    {
        return Sales;
    }
    public void Update(Sale item)
    {
        int itemIndex = Sales.FindIndex(p => p?.SaleId == item.SaleId);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");

        }
        Sales[itemIndex] = item;

    }

    public void Delete(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.SaleId == id);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");

        }
        Sales.RemoveAt(itemIndex);
    }

}

