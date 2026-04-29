List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "Qurbonbek", Age = 25, CityId = 1 },
    new Person { Id = 2, Name = "Muhammadsodik", Age = 22, CityId = 2 },
    new Person { Id = 3, Name = "Maruf", Age = 21, CityId = 3 },
    new Person { Id = 4, Name = "Abdullo", Age = 22, CityId = 4 },
    new Person { Id = 5, Name = "Muhammadsoleh", Age = 19, CityId = 5 }
};

List<City> cities = new List<City>
{
    new City { Id = 1, Name = "New York", Population = 8000000, CountryId = 1 },
    new City { Id = 2, Name = "Otava", Population = 4000000, CountryId = 2 },
    new City { Id = 3, Name = "Mexico City", Population = 2700000, CountryId = 3 },
    new City { Id = 4, Name = "Brazilia", Population = 2300000, CountryId = 4 },
    new City { Id = 5, Name = "Buenos Aires", Population = 1600000, CountryId = 5 }
};

List<Country> countries = new List<Country>
{
    new Country { Id = 1, Name = "USA" },
    new Country { Id = 2, Name = "Canada"},
    new Country { Id = 3, Name = "Mexico"},
    new Country { Id = 4, Name = "Brazil"},
    new Country { Id = 5, Name = "Argentina"}
};  

public class LinqExamTasks
{
    // Task 1: People living in cities with population > 3 million
    public IEnumerable<Person> GetPeopleInLargeCities(IEnumerable<Person> people, IEnumerable<City> cities)
    {
        return people.Join(cities.Where(c => c.Population > 3000000),person => person.CityId,city => city.Id,(person, city) => person);
    }

    // Task 2: Cities with population above the average of their specific country
    public IEnumerable<City> GetCitiesWithAboveAveragePopulation(IEnumerable<City> cities)
    {
        return cities.GroupBy(c => c.CountryId)
            .SelectMany(group => 
            {
                double average = group.Average(c => c.Population);
                return group.Where(c => c.Population > average);
            });
    }

    // Task 3: The city with the highest population for each country
    public IEnumerable<City> GetMostPopulatedCitiesByCountry(IEnumerable<City> cities)
    {
        return cities.GroupBy(c => c.CountryId).Select(group => group.OrderByDescending(c => c.Population).First());
    }

    // Task 4: All people with their associated City and Country names
    public dynamic GetPeopleWithLocationDetails(IEnumerable<Person> people, IEnumerable<City> cities, IEnumerable<Country> countries)
    {
        return people.Join(cities,p => p.CityId,ci => ci.Id,(p, ci) => new { p, ci }).Join(countries,combined => combined.ci.CountryId,co => co.Id, 
        (combined, co) => new 
        {
            PersonName = combined.p.Name,
            CityName = combined.ci.Name,
            CountryName = co.Name
        });
    }

    // Task 5: Cities that have at least one person named "Alice" (case insensitive)
    public IEnumerable<City> GetCitiesWithAnAlice(IEnumerable<City> cities, IEnumerable<Person> people)
    {
        return cities.Where(city => people.Any(p => p.CityId == city.Id && p.Name.Equals("Alice", StringComparison.OrdinalIgnoreCase)));
    }

    // Task 6: The oldest person in each city
    public IEnumerable<Person> GetOldestPersonInEachCity(IEnumerable<Person> people)
    {
        return people.GroupBy(p => p.CityId).Select(group => group.OrderByDescending(p => p.Age).First());
    }

    // Task 7: People living in the most populated city of each country
    public IEnumerable<Person> GetPeopleInTopCityOfEachCountry(IEnumerable<Person> people, IEnumerable<City> cities)
    {
        var topCityIds = cities.GroupBy(c => c.CountryId).Select(group => group.OrderByDescending(c => c.Population).First().Id);
        return people.Where(p => topCityIds.Contains(p.CityId));
    }

    // Task 8: People living in cities where the name length is exactly N
    public IEnumerable<Person> GetPeopleInCitiesWithNameLengthN(IEnumerable<Person> people, IEnumerable<City> cities, int n)
    {
        return people.Join(cities.Where(c => c.Name.Length == n),p => p.CityId,c => c.Id,(p, c) => p);
    }

    // Task 9: The youngest person in each country
    public IEnumerable<Person> GetYoungestPersonInEachCountry(IEnumerable<Person> people, IEnumerable<City> cities)
    {
        return people.Join(cities, p => p.CityId, c => c.Id, (p, c) => new { p, c.CountryId }).GroupBy(x => x.CountryId).Select(group => group.OrderBy(x => x.p.Age).First().p);
    }

    // Task 10: The city with the highest count of people within a specific age range
    public City GetCityWithMostPeopleInRange(IEnumerable<Person> people, IEnumerable<City> cities, int minAge, int maxAge)
    {
        var cityIdWithMostPeople = people.Where(p => p.Age >= minAge && p.Age <= maxAge).GroupBy(p => p.CityId).OrderByDescending(group => group.Count()).Select(group => group.Key).FirstOrDefault();
        return cities.FirstOrDefault(c => c.Id == cityIdWithMostPeople);
    }

    // Task 11: Cities that have more than 2 people
    public IEnumerable<City> GetCitiesWithMoreThanTwoPeople(IEnumerable<City> cities, IEnumerable<Person> people)
    {
        return cities.Where(c => people.Count(p => p.CityId == c.Id) > 2);
    }

    // Task 12: Countries that have at least one city with population < 1 million
    public IEnumerable<Country> GetCountriesWithSmallCities(IEnumerable<Country> countries, IEnumerable<City> cities)
    {
        return countries.Where(country => cities.Any(city => city.CountryId == country.Id && city.Population < 1_000_000));
    }

    // Task 13: People whose age is above the overall average age
    public IEnumerable<Person> GetPeopleAboveAverageAge(IEnumerable<Person> people)
    {
        double averageAge = people.Average(p => p.Age);
        return people.Where(p => p.Age > averageAge);
    }

    // Task 14: Cities that have no people (empty cities)
    public IEnumerable<City> GetCitiesWithNoPeople(IEnumerable<City> cities, IEnumerable<Person> people)
    {
        return cities.Where(city => !people.Any(p => p.CityId == city.Id));
    }

    // Task 15: Count the number of people in each country
    public dynamic GetPeopleCountByCountry(IEnumerable<Person> people, IEnumerable<City> cities, IEnumerable<Country> countries)
    {
        return countries.Select(country => new
        {
            CountryName = country.Name,
            PeopleCount = people.Join(cities,p => p.CityId,c => c.Id,(p, c) => c).Count(c => c.CountryId == country.Id)
        });
    }
}