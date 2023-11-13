namespace Question2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemlist = new List<Item>
            {
                new Item { ItemId = 1, ItemDescription = "Bag" },
                new Item { ItemId = 2, ItemDescription = "Pen" },
                new Item { ItemId = 3, ItemDescription = "Book" },
                new Item { ItemId = 4, ItemDescription = "Shoe" },
                new Item { ItemId = 5, ItemDescription = "Pin" }
            };

            List<Sales> saleslist = new List<Sales>
            {
                new Sales { InvNo = 1, ItemId = 3, Qty = 10 },
                new Sales { InvNo = 2, ItemId = 2, Qty = 20 },
                new Sales { InvNo = 3, ItemId = 3, Qty = 500 },
                new Sales { InvNo = 4, ItemId = 4, Qty = 20 },
                new Sales { InvNo = 5, ItemId = 3, Qty = 100 },
                new Sales { InvNo = 6, ItemId = 1, Qty = 50 }
            };

            var distinctItems = itemlist.Join(saleslist, item => item.ItemId, sale => sale.ItemId, (item, sale) =>
                                new
                                {
                                    ItemId = item.ItemId,
                                    ItemName = item.ItemDescription,
                                    Quantity = sale.Qty
                                }).Distinct();

            Console.WriteLine("Item ID  Item Name\t Quantity");
            Console.WriteLine("-------------------------------");

            foreach (var item in distinctItems)
            {
                Console.WriteLine($"{item.ItemId}\t {item.ItemName}\t\t {item.Quantity}");
            }
        }
    }
}