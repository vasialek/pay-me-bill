using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayMe.Models
{
    public class Bill
    {

        public int Id { get; set; }

        public byte StatusId { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public List<string> Debtors
        {
            get
            {
                List<string> debtors = new List<string>();
                foreach( var item in Items.Where(x => x.Debtors != null) )
                {
                    foreach( var d in item.Debtors )
                    {
                        if(debtors.Contains(d) == false)
                        {
                            debtors.Add(d);
                        }
                    }
                }
                return debtors;
            }
        }

        public decimal TotalSum
        {
            get
            {
                decimal total = 0m;
                foreach( var item in Items.Where(x => x.StatusId == 1) )
                {
                    total += item.Quantity * item.Price;
                }
                return total;
            }
        }

        public IList<BillItem> Items
        {
            get
            {
                BillRepository db = new BillRepository();
                return db.GetItemsForBill(Id).OrderBy(x => x.Id).ToList();
            }
        }

        public decimal getTotalForDebtor(string username)
        {
            decimal total = 0m;
            List<string> debtors = Debtors;

            foreach( var item in Items )
            {
                // This item is for all
                if( item.Debtors == null )
                {
                    total += item.Price * item.Quantity / debtors.Count;
                } else if( (item.Debtors.Count == 1) && item.Debtors[0].Equals(username, StringComparison.InvariantCultureIgnoreCase) )
                {
                    // User debt
                    total += item.Price * item.Quantity;
                } else if(item.Debtors.Contains(username))
                {
                    // Divide sum for all users in this item
                    total += item.Price * item.Quantity / item.Debtors.Count;
                }
            }

            return total;
        }

    }
}
