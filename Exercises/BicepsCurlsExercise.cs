namespace Training
{
    internal class BicepsCurlsExercise : Exercise
    {
        public BicepsCurlsExercise(int sets, int repetitions) : base("Biceps Curls", sets, repetitions)
        {
            Description = "Begin standing tall with your feet about hip-width apart. Keep your abdominal muscles engaged.\n" +
                "Hold one dumbbell in each hand. Let your arms relax down at the sides of your body with palms facing forward.\n" +
                "Keeping your upper arms stable and shoulders relaxed, bend at the elbow and lift the weights so that the dumbbells approach your shoulders. " +
                "Your elbows should stay tucked in close to your ribs. Exhale while lifting.\n" +
                "Lower the weights to the starting position.";
        }
    }
}
