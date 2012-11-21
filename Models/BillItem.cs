using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayMe.Models
{
    public class BillItem
    {

        public int Id { get; set; }

        public int BillId { get; set; }

        public byte StatusId { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        /// <summary>
        /// Get/sets list of user who should pay it
        /// </summary>
        public List<string> Debtors { get; set; }

    }
}
