namespace Training
{
    internal class SquatExercise : Exercise
    {
        public SquatExercise(int sets, int repetitions) : base("Squat", sets, repetitions)
        {
            Description = "Stand with your feet shoulder-width apart or slightly wider. Extend your hands straight out in front of you to help " +
                "keep your balance. You can also hold your hands at chest level or place them behind your head.\n" +
                "Bend at your knees and hips, sticking your butt out like you're sitting into an imaginary chair. " +
                "Keep your chest lifted and your spine neutral, and protect your lower back by not rounding your spine.\n" +
                "Keep your head and chest lifted to prevent your spine from rounding.Lower your hips so your knees are over your ankles. " +
                "Make sure to keep your weight back into your heels to avoid too much pressure on the knees.\n" +
                "Keep your body tight, and push through your heels, focusing on using your glutes to bring yourself back to the starting " +
                "position in order to reduce strain on your lower back.";
        }
    }
}
