using SpecificationDesignPattern.Entities;
using SpecificationDesignPattern.Repositories;
using SpecificationDesignPattern.Specifications;

ExecuteLegacyProcess();
ExecuteNewProcess();
ValidateSingleItemProcess();

void ExecuteLegacyProcess()
{
    Console.WriteLine("\n*** Legacy  Implementation ***");
    
    IEnumerable<City> cities;
    ILegacyCityRepository legacyRepository = new LegacyCityRepository();

    Console.WriteLine("-> Population >= 1000000");
    cities = legacyRepository.GetCities(1000000);
    PrintCities(cities);

    Console.WriteLine("\n-> IsCapital == true");
    cities = legacyRepository.GetCities(true);
    PrintCities(cities);

    Console.WriteLine("\n-> Population >= 1000000 AND IsCapital == true"); 
    cities = legacyRepository.GetCities(1000000, true);
    PrintCities(cities);

    Console.WriteLine("\n");
}

void ExecuteNewProcess()
{
    Console.WriteLine("\n*** Specification  Implementation ***");
    
    IEnumerable<City> cities;
    ICityRepository repository = new CityRepository();

    Console.WriteLine("\n-> Population >= 1000000"); 
    ISpecification<City> specPopulationGreaterThanOrEqual = new PopulationIsGreaterThanOrEqualSpecification(1000000);
    cities = repository.GetCities(specPopulationGreaterThanOrEqual);
    PrintCities(cities);

    Console.WriteLine("\n-> IsCapital == true");
    
    ISpecification<City> specIsCapital = new IsCountryCapitalSpecification(true);
    cities = repository.GetCities(specIsCapital);
    PrintCities(cities);

    Console.WriteLine("\n-> Population >= 1000000 AND IsCapital == true"); 
    ISpecification<City> specCompose = specPopulationGreaterThanOrEqual.And(specIsCapital);
    cities = repository.GetCities(specCompose);
    PrintCities(cities);

    Console.WriteLine("\n");
}

void ValidateSingleItemProcess()
{
    Console.WriteLine("\n*** Validation of single item ***");

    var city = new City(1, "Brasília", 4291577, "Brazil", true);
    
    ISpecification<City> specPopulationGreaterThanOrEqual = new PopulationIsGreaterThanOrEqualSpecification(1000000);
    ISpecification<City> specIsCountryCapital = new IsCountryCapitalSpecification(true);
    ISpecification<City> specCompose = specPopulationGreaterThanOrEqual.And(specIsCountryCapital);

    var isValid = specCompose.IsSatisfiedBy(city);

    Console.WriteLine(isValid ? "\nValid!" : "\nInvalid!"); 
    Console.WriteLine("\n"); 
}

void PrintCities(IEnumerable<City> cities)
{
    foreach(var city in cities)
        Console.WriteLine(city.Name);
}
