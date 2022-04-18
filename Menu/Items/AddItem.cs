using System;

namespace Training
{
    internal class AddItem : Item
    {
        TrainingManager _training;
        public AddItem(TrainingManager training) : base("Add an exercise")
        {
            this._training = training;
            this.ItemAction = AddExercise;
        }

        private void AddExercise()
        {
            Enumeration.PrintAllNames(typeof(DayOfWeek));

            Console.Write("Enter a day of a week: ");

            if(Int32.TryParse(Console.ReadLine(), out int day) && day >= Enumeration.Min(typeof(DayOfWeek)) && day <= Enumeration.Max(typeof(DayOfWeek)))
            {
                Enumeration.PrintAllNames(typeof(MuscleGroups));

                Console.Write("Enter a muscle group: ");
                if (Int32.TryParse(Console.ReadLine(), out int group) && group >= Enumeration.Min(typeof(MuscleGroups)) && group <= Enumeration.Max(typeof(MuscleGroups)))
                {
                    Console.Write("Enter a name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter a count of sets: ");

                    if (Int32.TryParse(Console.ReadLine(), out int sets) && sets > 0)
                    {
                        Console.Write("Enter a count of repetitions: ");

                        if (Int32.TryParse(Console.ReadLine(), out int rep) && rep > 0)
                        {
                            _training.AddExercise((DayOfWeek)day, (MuscleGroups)group, ExerciseCreator.Create(name, sets, rep));
                            Console.WriteLine("Added...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid data");
                    }

                }

                else Console.WriteLine("Invalid group");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

    }
}
