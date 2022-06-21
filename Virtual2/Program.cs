using System;
using System.Collections.Generic;

namespace Virtual2
{
    class Cwety
    {
        public string name { get; set; }
        public Cwety(string name)
        {
            this.name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine("Название цветка:" + name);
        }
    }
    class Tulpan : Cwety
    {
        public int razmer { get; set; }
        public string colour { get; set; }
        public string name_kind { get; set; }
        public Tulpan(int razmer, string colour, string name_kind, string name) : base(name)
        {
            this.razmer = razmer;
            this.colour = colour;
            this.name_kind = name_kind;
        }
        public void Osobenost_t()
        {
            Console.WriteLine(name + " цветет весной");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(" Цвет цветка " + colour);
        }
    }
    class Roza : Cwety
    {
        public int razmer { get; set; }
        public string colour { get; set; }
        public string name_kind { get; set; }
        public Roza(int razmer, string colour, string name_kind, string name) : base(name)
        {
            this.razmer = razmer;
            this.colour = colour;
            this.name_kind = name_kind;
        }
        public void Osobenost_r()
        {
            Console.WriteLine(name + " цветет летом");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(" Цвет цветка " + colour);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cwety> kwity = new List<Cwety>();
            kwity.Add(new Tulpan(20, "red", "Parot", "Tulpan"));
            kwity.Add(new Tulpan(30, "orange", "Clasic", "Tulpan"));
            kwity.Add(new Roza(20, "white", "Classic", "Roza"));
            foreach (Cwety cwetok in kwity)
            {
                //cwetok.Print();

                if (cwetok is Tulpan)
                    (cwetok as Tulpan).Print();

            }
        }
    }
}
