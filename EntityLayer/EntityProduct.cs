using System;

namespace EntityLayer
{
    public class EntityProduct
    {
        private int Id;
        private string ProductName;
        private string StockCode;
        private int StockQuantity;
        private int ProductQuantity;
        private double price;

        public int Id1 { get => Id; set => Id = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string StockCode1 { get => StockCode; set => StockCode = value; }
        public int StockQuantity1 { get => StockQuantity; set => StockQuantity = value; }
        public int ProductQuantity1 { get => ProductQuantity; set => ProductQuantity = value; }
        public double Price { get => price; set => price = value; }
    }
}
