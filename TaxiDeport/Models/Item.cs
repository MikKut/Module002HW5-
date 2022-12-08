namespace TaxiDeportProgram.Models
{
    internal abstract class Item
    {
        private int _id;
        private string _name;
        private string _description;
        public Item(string name, string description, int id)
        {
            Name = name;
            Description = description;
            ID = id;
        }

        public string Name
        {
            get => _name;
            private set => _name = string.IsNullOrEmpty(value)
                ? throw new ArgumentNullException($"{nameof(Name)} is null or empty")
                : value;
        }

        public string Description
        {
            get => _description;
            private set => _description = string.IsNullOrEmpty(value)
                ? throw new ArgumentNullException($"{nameof(Description)} is null or empty")
                : value;
        }

        public int ID
        {
            get => _id;
            private set => _id = (value > 0)
                ? value
                : throw new ArgumentOutOfRangeException($"{nameof(ID)} is less then null");
        }
    }
}
