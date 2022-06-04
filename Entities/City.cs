namespace SpecificationDesignPattern.Entities
{
    public class City
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Population { get; private set; }
        public string Country { get; private set; }
        public bool IsCountryCapital { get; private set; }

        public City(int id, 
                    string name, 
                    int population, 
                    string country, 
                    bool isCountryCapital)
        {
            this.Id = id;
            this.Name = name;
            this.Population = population;
            this.Country = country;
            this.IsCountryCapital = isCountryCapital;
        }
    }
}