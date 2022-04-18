using System;

namespace Training
{
    internal class RemoveItem : Item
    {
        TrainingManager _training;
        public RemoveItem(TrainingManager training) : base("Remove an exercise")
        {
            this._training = training;
            this.ItemAction = RemoveExercise;
        }

        private void RemoveExercise()
        {
            Enumeration.PrintAllNames(typeof(DayOfWeek));

            Console.Write("Enter a day of a week: ");

            if (Int32.TryParse(Console.ReadLine(), out int day) && day >= Enumeration.Min(typeof(DayOfWeek)) && day <= Enumeration.Max(typeof(DayOfWeek)))
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                if (_training.RemoveExercise((DayOfWeek)day, ExerciseCreator.Create(name, 0, 0)))
                    Console.WriteLine("Deleted...");
                else
                    Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

    }
}
