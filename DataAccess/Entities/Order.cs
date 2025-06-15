﻿namespace OrderService.DataAccess.Entities;

public class    Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Quantity { get; set; }
}