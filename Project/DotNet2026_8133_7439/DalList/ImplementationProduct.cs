
using DalApi;
using DO;
using static Dal.DataSource;
using DalList;

namespace Dal;

class ImplementationProduct: Iproduct
{

    public int Create(
    string ProductName,
    ProductsCategories ProductCategory,
    double ProductPrice,
    int ProductCount)
    {
        Product product = new Product(Config.GetNextProductId(),
     ProductName,
     ProductCategory,
     ProductPrice,
     ProductCount);
        Products.Add(product);
        return product.ProductId;
    }
    public Product? Read(int id)
    {
        foreach (Product p in Products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }



    public List<Product> ReadAll()
    {
        return Products;
    }
    public void Update(Product item)
    {
        int itemIndex = Sales.FindIndex(p => p?.ProductId == item.ProductId);
       Products[itemIndex] = item;

    }

    public void Delete(int id)
    {
        int itemIndex = Sales.FindIndex(p => p?.ProductId == id);
        if (itemIndex == -1)
        {

        throw new Exception(    )
        }
        Products.RemoveAt(itemIndex);

    }


}

