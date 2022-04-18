namespace Training
{
    internal class MainMenu : Item
    {
        public MainMenu(TrainingManager training) : base("Select mode")
        {
            Items.Add(new ManagerMenu(training));
            Items.Add(new ClientMenu((ITraining)training));

            this.ItemAction = null;
        }
        public new void Show() => new Menu(this).Show();
    }
}
