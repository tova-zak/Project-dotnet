
using DalApi;
using DO;
namespace Dal;

class ImplementationSale : Isale
{

    public int Create(Sale item)
    {
        Sales.Add(item);
        return item.SaleId;
    }
    public Sale? Read(int id)
    {
        foreach(Sale s in Sales)
        {
            if (s.SaleId == id)
                return s;
        }
        return null;
    }


}public List<Sale> ReadAll() {
    return Sales;
}
public void Update(Sale item) {
    foreach (Sale s in Sales)
    {
        if (s.SaleId == item.id)
        {
            Delete(s.id);
            Create(item);

        }
            
    }

}

public void Delete(int id) {
    foreach (Sale s in Sales)
    {
        if (s.SaleId == id)
            Sales.Remove(s);
    }
}

}

