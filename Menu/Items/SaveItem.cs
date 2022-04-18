using System;

namespace Training
{
    internal class SaveItem : Item
    {
        TrainingManager _training;
        public SaveItem(TrainingManager training) : base("Save")
        {
            this._training = training;
            this.ItemAction = Save;
        }

        private void Save()
        {
            _training.Save();
            Console.WriteLine("Saved...");
        }

    }
}
