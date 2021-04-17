using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    class EntityCategory
    {
        private int CategoryId;
        private string CategoryName;
        private int CategoryRowNumber;
        private float PriceRatio;

        public int CategoryId1 { get => CategoryId; set => CategoryId = value; }
        public string CategoryName1 { get => CategoryName; set => CategoryName = value; }
        public int CategoryRowNumber1 { get => CategoryRowNumber; set => CategoryRowNumber = value; }
        public float PriceRatio1 { get => PriceRatio; set => PriceRatio = value; }
    }
}
