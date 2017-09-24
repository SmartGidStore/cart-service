using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public IEnumerable<CartLine> Lines { get { return lineCollection; } }

        public void AddItem(Gadget gadget, int quantity)
        {
            CartLine line = lineCollection
                .Where(b => b.Gadget.IdGadgets == gadget.IdGadgets)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine { Gadget = gadget, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(int id)
        {
            lineCollection.RemoveAll(l => l.Gadget.IdGadgets == id);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Gadget.Price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class CartLine
    {
        public Gadget Gadget { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrise { get; set; }
    }
}
