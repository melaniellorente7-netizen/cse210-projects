public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _client;


    public Order(Customer client)
    {
        _client = client;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _productList)
        {
            total += product.GetTotalCost();
        }
        double shippingCost;
        if (_client.LivesInUSA())
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _productList)
        {
            label += $"Product: {product.GetProductName()} | ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"--- SHIPPING LABEL ---\n{_client.GetCustomerName()}\n{_client.GetFormattedAddress()}";
    }
}