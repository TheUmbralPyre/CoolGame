namespace CoolGame.Classes
{
    internal class NamedObject
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public NamedObject(string name)
        {
            Name = name;
        }
    }
}
