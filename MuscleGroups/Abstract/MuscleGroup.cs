using System;
using System.Text;
using System.Collections.Generic;

namespace Training
{
    internal abstract class MuscleGroup
    {
        public string Name { get; private set; }

        public List<Exercise> Exercises { get; protected set; }

        public MuscleGroup(string name)
        {
            if (Enum.IsDefined(typeof(MuscleGroups), name))
                Name = name;
            else
                Name = MuscleGroups.Undefined.ToString();

            Exercises = new List<Exercise>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + "\n");

            foreach(Exercise exercise in Exercises)
            {
                sb.Append(exercise);
            }

            return sb.ToString();
        }

        public void AddExercise(Exercise exercise) => Exercises.Add(exercise);

        public void RemoveExercise(Exercise exercise) => Exercises.Remove(Exercises.Find((_exercise) => _exercise.Name == exercise.Name));
    }

    enum MuscleGroups
    {
        Back,
        Chest,
        Legs,
        Shoulders,
        Bicep,
        Undefined
    }
}
