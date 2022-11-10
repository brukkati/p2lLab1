using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    public class Player
    {
        public Player() // конструктор
        {
            Random rand = new Random();         // генерирование рандомных значений (для старта)
            this.lifes = rand.Next(5,101);      // для жизней 
            this.level = rand.Next(1, 101);     // для уровня
            this.points = rand.Next(200, 1001);    // для баллов
        }

        private string name; // характеристики

        private int lifes;

        private int points;

        private int bonus = 300;

        private int level;
        public string Name { get => name; set => name = value; }
        public int Lifes { get => lifes; set => lifes = value; }
        public int Points { get => points; set => points = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public int Level { get => level; set => level = value; }
        public void LevelUp() // повышение уровня на 1
        {
            this.level += 1;
        }
        public void LifesUp(int value) // повышение жизней на вводимое число
        {
            this.lifes += value;
        }
        public void BonusToPoints() // трансфер бонусов в баллы
        {
            this.points += bonus;
        }
        public bool Fight(Player boss) 
        {
            if ()
        }
    }
}
