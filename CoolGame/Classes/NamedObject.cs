namespace CoolGame.Classes
{
    internal class NamedObject
    {
        /// <summary>
        /// Represents the Name of the Object.
        /// </summary>
        private string name;
        /// <summary>
        /// Exposes the name field.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            private set
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
