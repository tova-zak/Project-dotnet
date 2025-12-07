

namespace DO;

internal record Sale
{
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int ProductsCountToSale { get; set; } 
    public int PriceAfterSale { get; set; }
    public bool OnlyClubCustomers { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }

}
