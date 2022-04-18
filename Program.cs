using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TrainingManager godMode = new TrainingManager();
            //godMode.AddExercise(DayOfWeek.Monday, MuscleGroups.Back, new BentOverRowExercise(4, 10));
            //godMode.AddExercise(DayOfWeek.Monday, MuscleGroups.Chest, new BenchPressExercise(6, 5));
            //godMode.AddExercise(DayOfWeek.Monday, MuscleGroups.Chest, new BentOverFlyExercise(3, 12));

            //godMode.AddExercise(DayOfWeek.Thursday, MuscleGroups.Legs, new SquatExercise(3, 12));
            //godMode.AddExercise(DayOfWeek.Thursday, MuscleGroups.Shoulders, new OverheadPressExercise(5, 5));
            //godMode.AddExercise(DayOfWeek.Thursday, MuscleGroups.Bicep, new BicepsCurlsExercise(2, 10));

            //godMode.ShowAll();
            //godMode.Save();

            //godMode.Load();
            //godMode.ShowAll();

            //TrainingClient c = new TrainingClient();
            ////c.ShowAll();
            //Console.WriteLine(c.GetByMuscleGroup(DayOfWeek.Monday, MuscleGroups.Back));

            MainMenu menu = new MainMenu(new TrainingManager());
            menu.Show();
        }
    }
}
