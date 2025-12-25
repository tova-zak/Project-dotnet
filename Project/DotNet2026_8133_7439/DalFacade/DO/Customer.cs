namespace DO;

public record Customer
(
    string CustomerId,
    string CustomerName,
    string CustomerAddress,
    string CustomerPhone
)
{
    public Customer() : this("", "", "", "") { }
}