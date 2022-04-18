using System;

namespace Training
{
    internal class LoadItem : Item
    {
        ITraining _training;
        public LoadItem(ITraining training) : base("Load")
        {
            this._training = training;
            this.ItemAction = Load;
        }

        private void Load()
        {
            _training.Load("training.txt");
            Console.WriteLine("Loaded...");
        }

    }
}
