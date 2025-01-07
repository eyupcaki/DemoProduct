﻿namespace DemoProduct.CQRSDesignPattern.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
    }
}
