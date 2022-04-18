using System;
using System.Collections.Generic;

namespace Training
{
    internal class TrainingClient : ITraining
    {
        private TrainingManager _manager;

        public TrainingClient()
        {
            _manager = new TrainingManager();
            _manager.Load();
        }

        public void ShowAll()
        {
            _manager.ShowAll();
        }

        public List<MuscleGroup> GetByDay(DayOfWeek day)
        {
            return _manager.GetByDay(day);
        }

        public List<Exercise> GetByMuscleGroup(DayOfWeek day, MuscleGroups muscleGroupName)
        {
            return _manager.GetByMuscleGroup(day, muscleGroupName);
        }

        public bool Load(string path = "training.txt")
        {
            return _manager.Load(path);
        }
    }
}
