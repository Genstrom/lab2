namespace ITHS_CC_Labb2;

public interface IOrderProcessor
{
    bool ProcessOrderNormally(Order order);
    bool ProcessOrderQuickly(Order order);
    bool ProcessOrderInLigtningSpeed(Order order);
}