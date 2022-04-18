using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training
{
    internal class TrainingManager : ITraining
    {
        public Dictionary<DayOfWeek, List<MuscleGroup>> TrainingDays {get; private set; }

        public TrainingManager()
        {
            TrainingDays = new Dictionary<DayOfWeek, List<MuscleGroup>>();
        }

        public bool AddExercise(DayOfWeek day, MuscleGroups muscleGroupName, Exercise exercise)
        {
            if (TrainingDays.ContainsKey(day))
            {
                MuscleGroup muscleGroup = TrainingDays[day].Find((group) => group.Name == muscleGroupName.ToString());

                if (muscleGroup == null)
                {
                    TrainingDays[day].Add(MuscleGroupCreator.Create(muscleGroupName));
                    TrainingDays[day][TrainingDays[day].Count - 1].AddExercise(exercise);

                    return true;
                }

                if (muscleGroup.Exercises.Find((ex) => ex.Name == exercise.Name) != null)
                {
                    muscleGroup.AddExercise(exercise);
                    return true;
                }

                else return false;
            }
            else
            {
                TrainingDays[day] = new List<MuscleGroup>();
                TrainingDays[day].Add(MuscleGroupCreator.Create(muscleGroupName));
                TrainingDays[day][TrainingDays[day].Count - 1].AddExercise(exercise);

                return true;
            }
        }

        public bool RemoveExercise(DayOfWeek day, Exercise exercise)
        {
            bool res = false;

            foreach(var group in TrainingDays[day])
            {
                if (group.Exercises.Remove(group.Exercises.Find((ex) => ex.Name == exercise.Name)))
                {
                    res = true;
                }
            }

            return res;
        }

        public bool RemoveExercise(Exercise exercise)
        {
            bool res = false;

            foreach (var day in TrainingDays.Keys)
            {
                if (RemoveExercise(day,exercise))
                    res = true;
            }

            return res;
        }

        public void Save(string path = "training.txt")
        {
            if (File.Exists(path))
                File.Delete(path);

            StringBuilder sb = new StringBuilder();

            foreach(var day in TrainingDays.Keys)
            {
                sb.Append(day);
                sb.Append('\n');

                foreach (var group in TrainingDays[day])
                {
                    sb.Append(group);
                    sb.Append('\n');
                }

                sb.Append(new string('=', 15));
                sb.Append('\n');
            }

            File.AppendAllText(path, sb.ToString());
        }

        public bool Load (string path = "training.txt")
        {
            if (!File.Exists(path))
                return false;

            TrainingDays.Clear();

            string[] lines = File.ReadAllLines(path);

            int i = 0;

            while(i < lines.Length)
            {
                while (i < lines.Length && !Enumeration.IsEnumerationContains(lines[i], typeof(DayOfWeek)))
                    i++;

                if (i >= lines.Length)
                    break;

                DayOfWeek day = Date.StringToDay(lines[i]);

                if (!TrainingDays.ContainsKey(day))
                    TrainingDays[day] = new List<MuscleGroup>();

                i++;

                while (i < lines.Length && !Enumeration.IsEnumerationContains(lines[i], typeof(DayOfWeek)))
                {
                    string groupName = lines[i];

                    if (Enumeration.IsEnumerationContains(lines[i], typeof(MuscleGroups)))
                    {
                        TrainingDays[day].Add(MuscleGroupCreator.Create(lines[i]));
                        i++;
                        TrainingDays[day].Find((group) => group.Name == groupName)?.AddExercise(Exercise.GetExercise(lines[i]));
                    }

                    i++;
                }
            }

            return true;
        }

        public void ShowAll()
        {
            foreach (var day in TrainingDays.Keys)
            {
                Console.WriteLine(day);

                foreach (var group in TrainingDays[day])
                    Console.WriteLine(group);

                Console.WriteLine(new string('=', 15));
            }
        }

        public List<MuscleGroup> GetByDay(DayOfWeek day)
        {
            return TrainingDays[day];
        }

        public List<Exercise> GetByMuscleGroup(DayOfWeek day, MuscleGroups muscleGroupName)
        {
            return TrainingDays[day].Find((group) => group.Name == muscleGroupName.ToString())?.Exercises;
        }

    }
}
