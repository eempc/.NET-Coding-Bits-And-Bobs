using System;
using System.Collections.Generic;

namespace Interface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            IWalk aaa = new Cat("Ann");
            ISwim bbb = new Duck("Bob");
            ISwim ccc = new Fish("Ciara");
            ISwim ddd = new Dolphin("Dan");

            List<ISwim> swimList = new List<ISwim>();
            swimList.Add(bbb);
            swimList.Add(ccc);
            swimList.Add(ddd);

            foreach (var x in swimList) {
                Console.WriteLine(x.Swim());
            }
        }
    }

    public interface IFly {
        string Fly();
    }

    public interface ISwim {
        string Swim();
    }

    public interface IWalk {
        string Walk();
    }

    public abstract class Animal {
        protected string _name;
        public Animal(string name) {
            _name = name;
        }
        public abstract string Talk();
    }

    public class Cat : Animal, IWalk {
        public Cat(string name) : base(name) {
            _name = name;
        }
        public override string Talk() {
            return "Meow";
        }
        public string Walk() {
            return _name + " walks";
        }
    }

    public class Duck : Animal, IWalk, ISwim, IFly {
        public Duck(string name) : base(name) {
            _name = name;
        }
        public override string Talk() {
            return "Quack";
        }
        public string Walk() {
            return _name + " walks";
        }
        public string Swim() {
            return _name + " swims";
        }
        public string Fly() {
            return _name + " flies";
        }
    }

    public class Fish : Animal, ISwim {
        public Fish(string name) : base(name) {
            _name = name;
        }
        public override string Talk() {
            return "Glug";
        }
        public string Swim() {
            return _name + " swims";
        }
    }

    public class Dolphin : Animal, ISwim {
        public Dolphin(string name) : base(name) {
            _name = name;
        }
        public override string Talk() {
            return "Ahhhahahah";
        }
        public string Swim() {
            return _name + " swims";
        }
    }
}
