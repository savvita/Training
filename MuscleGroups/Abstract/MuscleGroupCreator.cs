namespace Training
{
    internal static class MuscleGroupCreator
    {
        public static MuscleGroup Create (MuscleGroups muscleGroupName)
        {
            MuscleGroup muscleGroup = null;

            switch (muscleGroupName)
            {
                case MuscleGroups.Back:
                    muscleGroup = new BackMuscleGroup();
                    break;

                case MuscleGroups.Bicep:
                    muscleGroup = new BicepMuscleGroup();
                    break;

                case MuscleGroups.Chest:
                    muscleGroup = new ChestMuscleGroup();
                    break;

                case MuscleGroups.Legs:
                    muscleGroup = new LegsMuscleGroup();
                    break;

                case MuscleGroups.Shoulders:
                    muscleGroup = new ShouldersMuscleGroup();
                    break;
            }

            return muscleGroup;
        }

        public static MuscleGroup Create(string muscleGroupName)
        {
            MuscleGroup muscleGroup = null;

            switch (muscleGroupName)
            {
                case "Back":
                    muscleGroup = new BackMuscleGroup();
                    break;

                case "Bicep":
                    muscleGroup = new BicepMuscleGroup();
                    break;

                case "Chest":
                    muscleGroup = new ChestMuscleGroup();
                    break;

                case "Legs":
                    muscleGroup = new LegsMuscleGroup();
                    break;

                case "Shoulders":
                    muscleGroup = new ShouldersMuscleGroup();
                    break;
            }

            return muscleGroup;
        }
    }

}
