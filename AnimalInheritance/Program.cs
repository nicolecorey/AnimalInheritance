using System;
namespace AnimalInheritance
{

    class Animal
    {
        private string name; 
        protected string type; 
        public string color;  

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class Shark : Animal
    {
            public string type; 
            protected int age;
            public int weight; 

            public void setAge(int age)
            {
                this.age = age;
            }
            public virtual int getAge()
            {
                return age;
            }

           
            public override string getName()
            {
                return base.getName();
            }

           
            public override string getType()
            {
                return base.getType();
            }
            
            public void setWeight(int weight)
             {
                this.weight = weight;
             }
            public int getWeight()
            {
                return weight;
            }

            public virtual string sound()
            {
                return "chomp";
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
                Animal pup = new Animal();
                pup.setName("Jaws");
                pup.setType("shark");
                pup.color = "gray";

                Console.WriteLine("Animal Information...");
                Console.WriteLine($"My name is {pup.getName()}");
                Console.WriteLine($"I am a {pup.getType()}");
                Console.WriteLine($"I am {pup.color} in color");
                Console.WriteLine();

                // new object from Shark class
                Shark cub = new Shark();
                cub.setName("Chomper");
                cub.setType("great white shark");
                cub.color = "white";
                cub.setAge(5);
                cub.setWeight(200);

                Console.WriteLine("Shark Information...");
                Console.WriteLine($"My name is {cub.getName()}");
                Console.WriteLine($"I am a {cub.getType()}");
                Console.WriteLine($"I am {cub.color} in color");
                Console.WriteLine($"I am {cub.getAge()} years old");
                Console.WriteLine($"I like to {cub.sound()}");
                Console.WriteLine($"I weigh {cub.weight} pounds.");

                Console.ReadLine();
            }

        }
    }
