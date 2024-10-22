public class Order
{
    private List<Product> _product;
    private Customer _customer;
    public Order(Customer customer)
    {
        _product = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;

        foreach (var product in _product)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = _customer.IsInUsa() ? 5.00m : 35.00m;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _product)
        {
            label +=  $"{product.GetPackingLabel()}" + "\n"; 
        }

        return label.Trim();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";;
    }


}