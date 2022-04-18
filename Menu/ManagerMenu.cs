namespace Training
{
    internal class ManagerMenu : Item
    {
        public ManagerMenu(TrainingManager training) : base("God mode")
        {
            Items.Add(new ShowAllItems(training));
            Items.Add(new ShowExercisesItem(training));
            Items.Add(new AddItem(training));
            Items.Add(new RemoveItem(training));
            Items.Add(new SaveItem(training));
            Items.Add(new LoadItem(training));

            this.ItemAction = null;
        }
    }
}
