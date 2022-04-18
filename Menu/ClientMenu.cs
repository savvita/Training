namespace Training
{
    internal class ClientMenu : Item
    {
        public ClientMenu(ITraining training) : base("Client mode")
        {
            Items.Add(new LoadItem(training));
            Items.Add(new ShowAllItems(training));
            Items.Add(new ShowExercisesItem(training));

            this.ItemAction = null;
        }
    }
}
