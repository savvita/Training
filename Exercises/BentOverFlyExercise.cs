namespace Training
{
    internal class BentOverFlyExercise : Exercise
    {
        public BentOverFlyExercise(int sets, int repetitions) : base("Bent Over Fly", sets, repetitions)
        {
            Description = "Hold dumbbells in each hand, stand with knees slightly bent. Keeping your back flat, bend forward at the hip joint.\n" +
                "Exhale and lift both arms out to the side, maintaining a slight bend in the elbows and squeezing your shoulder blades together.\n" +
                "With control, lower the dumbbells back toward the ground.";
        }
    }
}
