using DalApi;
using DO;
namespace DelTest;

public static class Initialization
{
    private static IDal s_dal;
    public static void Initialize(IDal dal)
    {
        s_dal= dal;
        createCustomers();
        createProducts();
        createSales();
    }
    private static void createSales()
    {
        s_dal.sale.Create(new Sale(1, 1, 1, 1, true,DateTime.Now, DateTime.Now.AddMonths(1)));
    }
    private static void createProducts()
    {
        s_dal.product.Create(new Product(1,"k", ProductsCategories.DIARY,1,1));
    }
    private static void createCustomers()
    {
        s_dal.customer.Create(new Customer(1,"fj","gyy","6556385698"));
    }
}
