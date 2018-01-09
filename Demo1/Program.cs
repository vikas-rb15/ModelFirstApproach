using Demo1.Entities;
using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                db.Actors.AddRange(

                    new Actor()
                    {
                        Name = "Vikas",
                        Age = 26,
                        AcademyWinner = true
                    },
                    new Actor()
                    {
                        Name = "Vishal",
                        Age = 22,
                        AcademyWinner = true
                    },
                    new Actor()
                    {
                        Name = "Vivek",
                        Age = 20,
                        AcademyWinner = true
                    });
                var count = db.SaveChanges();

                //Fetch data and write it out
                Console.WriteLine($"{count} record added sucessfully");
                foreach (var actor in db.Actors)
                {
                    Console.WriteLine($"Name : {actor.Name}, \t\t" + $"Age : {actor.Age}, \t\t" + $"AcadenyWinner {actor.AcademyWinner}");
                }
                Console.ReadLine();
            }
        }
    }
}
