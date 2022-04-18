namespace Training
{
    internal static class ExerciseCreator
    {
         public static Exercise Create(string exerciseName, int sets, int repetitions)
        {
            Exercise exercise = null;

            switch (exerciseName)
            {
                case "BenchPress":
                    exercise = new BenchPressExercise(sets, repetitions);
                    break;

                case "BentOverFly":
                    exercise = new BentOverFlyExercise(sets, repetitions);
                    break;

                case "BentOverRow":
                    exercise = new BentOverRowExercise(sets, repetitions);
                    break;

                case "BicepsCurls":
                    exercise = new BicepsCurlsExercise(sets, repetitions);
                    break;

                case "OverheadPress":
                    exercise = new OverheadPressExercise(sets, repetitions);
                    break;

                case "Squat":
                    exercise = new SquatExercise(sets, repetitions);
                    break;
            }

            return exercise;
        }
    }

}
