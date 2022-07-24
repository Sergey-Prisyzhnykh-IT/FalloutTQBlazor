using FalloutTQBlazor.DateBase;

namespace FalloutTQBlazor.GaemsControll.Player
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Level { get; set; } // Уровень
        public int Experience { get; set; } // Опыт
        public int ExperienceNextLevel { get; set; } // Опыт до след. уровня
        public int Strength { get; set; } //Сила
        public int Perception { get; set; } // Восприятие
        public int Endurance { get; set; } // Выносливость
        public int Charisma { get; set; } // Харизма
        public int Intelligence { get; set; } // Интелект
        public int Agility { get; set; } // Ловкость
        public int Luck { get; set; } // Удача

        public int Сovers { get; set; } // крышки(деньги)

        public int SaveIdDialog { get; set; } // сохраняем прогресс прохождения

        public List<Inventory> Inventory { get; set; } = new();

        public Player()
        {
        }

        public Player(string name, string password)
        {
            Name = name;
            Password = password;
            Level = 1;
            Experience = 0;
            ExperienceNextLevel = 1000;
            Strength = 1;
            Perception = 1;
            Endurance = 1;
            Charisma = 1;
            Agility = 1;
            Luck = 1;
            Intelligence = 1;
            SaveIdDialog = 1;
            Сovers = 1000;
        }
    }
}
