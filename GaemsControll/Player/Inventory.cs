namespace FalloutTQBlazor.GaemsControll.Player
{
    public class Inventory
    {
        public int Id { get; set; }
        public string[] NameItem { get; set; } // название предмета
        public string[] ItemType { get; set; } // тип предмета (оружие, аптечка и т.д.)
        public int[] Count { get; set; } // кол-во
        
        public int PlayerId { get; set; } // внешний ключ
        public Player? Player { get; set; } // навигационное свойство

        public Inventory(string[] nameItem, string[]itemType, int[] count)
        {
            NameItem = nameItem;
            ItemType = itemType;
            Count = count;
        }

    }
}
