using System;

namespace Prov
{

    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        Random generator = new Random();

                    //genererar slumpmässiga tal för hur mycker boken är vald plus namn och om den är cursed
        public Book()
        {
            actualValue = generator.Next(101);
            rarity = generator.Next(11);
            //cursedär en bool och därför funkar inte detta men skulle kunna konvertera den om jag hade tid samma med name där jag skulle kunna göra en lista och sedan stoppa in dem som värden i generatorn

            cursed = generator.Next();
            name = generator.Next();

           

        }
        //printar vad för sorts bok det är för något
         public static void PrintInfo()
        {
            Console.WriteLine("Bokens namn är " + name + " dens rarity är " + rarity + 
            " kategorin är " + category + " och priset är " + pris);
        }
        private int evaliation;
        //räknar ut rätt värde av boken
        public int Evaluate()
        {
            evaliation = actualValue * rarity;
            //vet inte hur jag skulle göra och det är därför det är rött under procenten men skulle kunna använda mig av double eller float men det var inte det man skulle använda
            evaliation = evaliation * generator.Next(50%, 150%);
        }
    
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            
            return cursed;
        }
}
