using ITHS_CC_Labb2;

var orderService = new OrderService(new EmailService(), new Logger(), new OrderProcessorService());

var slowOrder = new Order
{
    Id = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrice = 100
};

orderService.ProcessOrder(slowOrder);