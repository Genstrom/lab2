namespace ITHS_CC_Labb2;

public class OrderProcessorService : IOrderProcessor
{
    public bool ProcessOrderNormally(Order order)
    {
        // Some logic we don't care about,
        return true;
    }

    public bool ProcessOrderQuickly(Order order)
    {
        // Some logic we don't care about
        return true;
    }

    public bool ProcessOrderInLigtningSpeed(Order order)
    {
        // Some logic we don't care about
        return true;
    }
}