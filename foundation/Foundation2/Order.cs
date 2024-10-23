public class Order
{
    private Customer _customer;
    private List<Product> _productsList;
    public Order(Customer customer)
    {
        _customer = customer;
        _productsList = new List<Product>();
    }
    public void AddProducts(Product product)
    {
        _productsList.Add(product);
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productsList)
        {
            packingLabel += product.GetDisplayProduct() + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
        return shippingLabel;
    }
    public double ComputeTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _productsList)
        {
            totalCost += product.ComputeProductCost();
        }
        return totalCost;
    }
    public double ComputeTotalPrice()
    {
        double totalPrice = 0;
        if (_customer.LivesInUSA())
        {
            totalPrice = this.ComputeTotalCost() + 5.0;
        }
        else totalPrice = this.ComputeTotalCost() + 35.0;
        return totalPrice;
    }
}