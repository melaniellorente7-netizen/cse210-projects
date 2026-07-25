public class Product
{
    private string _name;
    private string _productID;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string id, double unitPrice, int quantity)
    {
        _name = name;
        _productID = id;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _unitPrice * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productID;
    }
}