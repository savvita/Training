namespace Training
{
    internal class OverheadPressExercise : Exercise
    {
        public OverheadPressExercise(int sets, int repetitions) : base("Overhead Press", sets, repetitions)
        {
            Description = "Adjust the barbell to just below shoulder height then load the desired weight onto the bar.\n" +
                "Assume a shoulder width stance and place your hands at(or just outside of) shoulder width with a pronated grip on the bar.\n" +
                "Step underneath the bar and unrack it while keeping the spine in a neutral position.\n" +
                "Take two steps back, inhale, brace, tuck the chin, then press the bar to lockout overhead.\n" +
                "Exhale once the bar gets to lockout and reverse the movement slowly while controlling the bar back to your chest.";
        }
    }
}
