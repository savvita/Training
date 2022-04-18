using System;
using System.Collections.Generic;

namespace Training
{
    internal interface ITraining
    {
        void ShowAll();

        List<MuscleGroup> GetByDay(DayOfWeek day);

        List<Exercise> GetByMuscleGroup(DayOfWeek day, MuscleGroups muscleGroupName);

        bool Load(string path);
    }
}
