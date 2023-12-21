using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType ft = new FoodType("jabuka", 12, 46, 0);
            Food food = new Food(ft, 110);
            Console.WriteLine(ft.toString());
            Console.WriteLine(food.toString());
            Console.WriteLine(food.toStringInGrams());
            Console.WriteLine(String.Format("protein: {0}\ncarbs: {1}\nfat: {2}", food.getProtein(), food.getCarbs(), food.getFat()));
            Console.ReadKey();
        }

    }
    class FoodType
    {
        private string name;
        public string getName() => name;
        private int protein, carbs, fat;
        public int getProtein() => protein;
        public int getCarbs() => carbs;
        public int getFat() => fat;
        static int counter = 0;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            ++counter;
        }
        public string toString()
        {
            return String.Format("jabuka: p - {0}%, c - {1}%, f - {2}%", protein, carbs, fat);
        }
        public int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }
    class Food
    {
        public FoodType type;
        int weight;
        public double getProtein() => ((double)type.getProtein() / 100) * weight;
        public double getCarbs() => ((double)type.getCarbs() / 100) * weight;
        public double getFat() => ((double)type.getFat() / 100) * weight;

        public Food(FoodType type, int weight)
        {
            Console.WriteLine(type);
            this.type = type;
            this.weight = weight;
        }
        public string toString()
        {
            return String.Format("{0}, w - {1}g", type.toString(), weight);
        }
        public string toStringInGrams()
        {
            return String.Format("jabuka: p - {0}g, c - {1}g, f - {2}g, w - {3}g", getProtein(), getCarbs(), getFat(), weight);
        }
    }
}