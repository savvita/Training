namespace Training
{
    internal class BenchPressExercise : Exercise
    {
        public BenchPressExercise(int sets, int repetitions) : base("Bench Press", sets, repetitions)
        {
            Description = "Set the bar to a weight you are comfortable with.\n" +
                "Lie on the bench with your head under the barbell and your feet firmly on the floor.\n" +
                "Squeeze your shoulder blades together and slightly arch your back.\n" +
                "Grip the barbell with your hands slightly wider than shoulder-width apart.\n" +
                "Push the barbell up to take it off the rack, and then press it towards the ceiling by extending your arms upwards, " +
                "making sure to keep your wrists straight.\n" +
                "Inhale while lowering the barbell in a controlled, smooth movement, stopping when it is resting just above the bottom half of your sternum " +
                "and your triceps are parallel with the floor.\n" +
                "Pause before driving the barbell back up as you exhale.";
        }
    }
}
