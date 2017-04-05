namespace Clasification
{
    public interface ICartProduct
    {
        AbstractProduct Product { get; set; }
        int Quantity { get; }
        decimal Subtotal { get; }
    }
}