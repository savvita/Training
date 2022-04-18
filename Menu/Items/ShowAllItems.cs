namespace Training
{
    internal class ShowAllItems : Item
    {
        ITraining _training;
        public ShowAllItems(ITraining training) : base("Show all training")
        {
            this._training = training;
            this.ItemAction = ShowAll;
        }

        private void ShowAll() => _training.ShowAll();
    }
}
