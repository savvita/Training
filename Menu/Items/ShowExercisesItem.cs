using System;

namespace Training
{
    internal class ShowExercisesItem : Item
    {
        ITraining _training;
        public ShowExercisesItem(ITraining training) : base("Show exercises by a day")
        {
            this._training = training;
            this.ItemAction = ShowExercises;
        }

        private void ShowExercises()
        {
            Enumeration.PrintAllNames(typeof(DayOfWeek));

            Console.Write("Enter a day of a week: ");

            if (Int32.TryParse(Console.ReadLine(), out int day) && day >= Enumeration.Min(typeof(DayOfWeek)) && day <= Enumeration.Max(typeof(DayOfWeek)))
            {
                try
                {
                    var groups = _training.GetByDay((DayOfWeek)day);

                    foreach (var group in groups)
                    {
                        Console.WriteLine(group.Name);

                        foreach (var exercise in _training.GetByMuscleGroup((DayOfWeek)day, (MuscleGroups)Enumeration.GetValueByName(typeof(MuscleGroups), group.Name)))
                        {
                            Console.WriteLine(exercise);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("There are no trainings at this day");
                }
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }

    }
}
