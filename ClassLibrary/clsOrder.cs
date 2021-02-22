using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public string BookName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }
        public bool Dispatched { get; set; }
       
    }
}