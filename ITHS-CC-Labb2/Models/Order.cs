namespace ITHS_CC_Labb2;

public class Order
{
    public Guid Id { get; set; }
    public int TotalPrice { get; set; }
    public OrderStatus Priority { get; set; }
    public string Email { get; set; }
}

public enum OrderStatus
{
    Normal,
    Quick,
    LightningSpeed
}