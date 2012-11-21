using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayMe.Models
{
    public class BillRepository
    {
        private List<Bill> _bills = null;

        private List<BillItem> _billItems = null;

        public BillRepository()
        {
            _bills = new List<Bill>();
            _billItems = new List<BillItem>();

            _bills.Add(new Bill {
                Id = 1000
                , Name = "Alaus namai, november 17"
                , StatusId = 1
                , CreatedAt = DateTime.Parse("2012-11-20")
                , Username = "pmadmin"
            });

            BillItem bi = new BillItem { BillId = 1000, Id = 50001, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Dron" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50002, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50003, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Dron" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50004, Name = "Alyvuoges", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50005, Name = "Rinkinys neissirenkantiems", Price = 25m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50006, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50007, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50008, Name = "Daujotu", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50009, Name = "Kalmaru ziedai", Price = 7.5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50010, Name = "Varniuku", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50011, Name = "Vilniaus", Price = 5m, Quantity = 2, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Dron", "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50012, Name = "Vistenos lazdeles", Price = 8m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50013, Name = "Astrus padazas", Price = 2m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50014, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50015, Name = "Varniuku", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50016, Name = "Daujotu", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50017, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Dron" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50018, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50019, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50020, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50021, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50022, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50023, Name = "Varniuku", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "pmadmin" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50024, Name = "Cizo", Price = 6m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Zhenka" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50025, Name = "Vilniaus", Price = 5m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            bi.Debtors = new List<string> { "Seryi" };
            _billItems.Add(bi);
            bi = new BillItem { BillId = 1000, Id = 50026, Name = "Tips", Price = 16m, Quantity = 1, StatusId = 1, Username = "pmadmin" };
            _billItems.Add(bi);
        }

        public Bill GetById(int id)
        {
            return _bills.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Returns list of all items whic belong to bill
        /// </summary>
        /// <param name="billId"></param>
        public IList<BillItem> GetItemsForBill(int billId)
        {
            return _billItems.Where(x => x.BillId == billId).ToList();
        }

    }
}
