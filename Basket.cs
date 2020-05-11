using System;
using System.Collections.Generic;
using System.Text;

namespace SaveToXMLFile
{
    public class Basket : ISaveToXMLFile
    {
        private double _basketValue = 0;
        private int _itemsQuantity = 0;

        public double BasketValue { get => _basketValue; }
        public int ItemsQuantity { get => _itemsQuantity; }

        public Basket(double basketValue, int itemsQuantity)
        {
            _basketValue = basketValue;
            _itemsQuantity = itemsQuantity;
        }

        public string SaveToXMLFile()
        {
            return $@"<Basket> <Value>{_basketValue}</Value> <ItemsQuantity>{_itemsQuantity}</ItemsQuantity> </Basket>";
        }
    }
}
