using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    internal class Pharmacy
    {
        public string Name { get; set; }
        public int UnikalId { get; }
        public Drug[] Drugs = new Drug[0];

        public void AddDrug(Drug drug)
        {
            Array.Resize(ref Drugs, Drugs.Length + 1);
            Drugs[Drugs.Length - 1] = drug;
        }
        public void DrugList()
        {
            foreach (var item in Drugs)
            {
                Console.WriteLine(item);
            }
          
        }
        public void SaleDrug(string name, int count, double money)
        {
            foreach (var item in Drugs)
            {
                if (item.Name == name && item.Count>count && item.Price < money)
                {
                    money -= count * item.Price;
                    item.Count -= count;
                    Console.WriteLine("Qalan pul: {Money");
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Satish bash vermedi");
                }
                break;

            }
            
        }
        public override string ToString()
        {
            return $"UnikalId:{UnikalId} && Name: {Name}";
        }
    }
}
