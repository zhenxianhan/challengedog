using System;

namespace Dog
{
    public class Dog
    {
        public enum Gender
        {
            Male, Female
        };
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public void bark(int x)
        {
            int a;

            for (a = 0; a < x; a++)
            {
                Console.Write("Woof!");

            }
            Console.WriteLine();
        }

        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            return "Her";
        }
        public Dog(string name1, string owner1, int age1, Gender gender1)
        {
            name = name1;
            owner = owner1;
            age = age1;
            gender = gender1;
        }



        public string getTag()
        {

            string HerHis = getGender(gender).ToString();

            string HeShe;


            if (HerHis == "His")
            {
                HeShe = "he";
            }
            else
            {
                HeShe = "she";
            }


            string year = age.ToString();
            if (age == 1)
            {
                year = "year";


            }
            if (age > 1)
            {
                year = "years";
            }

            return "If lost, call " + owner + ". " + HerHis + " name is " + name + " and " + HeShe + " is " + age + " " + year + " old.";
        }



    }
    class MainClass
    {
        public static void Main(string[] args)
        {


            Dog puppy = new Dog("Orion", "Shawn", 1, Dog.Gender.Male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());



            Dog myDog = new Dog("Lileu", "Dale", 4, Dog.Gender.Female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());



        }
    }
}