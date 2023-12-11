namespace Models
{
    public class Title : ValueObject
    {
        public string Name { get; private set; }
        public Colour Colour { get; private set; }
        public Title() { }

        public Title(string name, Colour colour)
        {
            Name = name;
            Colour = colour;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Colour;
        }
    }
}
