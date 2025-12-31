
using DalApi;
using DO;
using static Dal.DataSource;
using DalList;

namespace Dal;

class ImplementationProduct: Iproduct
{

    public int Create(Product item)
    {
        
        Products.Add(item);
        return item.ProductId;
    }
    public Product? Read(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.ProductId == id);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");

        }
        return Products[itemIndex];
    }



    public List<Product> ReadAll()
    {
        return Products;
    }
    public void Update(Product item)
    {
        int itemIndex = Sales.FindIndex(p => p?.ProductId == item.ProductId);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");

        }
        Products[itemIndex] = item;

    }

    public void Delete(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.ProductId == id);
        if (itemIndex == -1)
        {
            throw new ItemNotFoundException("item not found");
        }
        Products.RemoveAt(itemIndex);

    }


}

