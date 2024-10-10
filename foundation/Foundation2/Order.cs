using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const double USShippingCost = 5.0;
    private const double InternationalShippingCost = 35.0;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += customer.LivesInUSA() ? USShippingCost : InternationalShippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        return label;
    }
}
