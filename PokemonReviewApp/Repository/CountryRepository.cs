using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext context;

        public CountryRepository(DataContext context)
        {
            this.context = context;
        }
        public bool CountryExists(int id)
        {
            return context.Countries.Any(c => c.Id == id);
        }

        public bool CreateCountry(Country country)
        {
            context.Add(country);
            return Save();
        }

        public bool DeleteCountry(Country country)
        {
            context.Remove(country);
            return Save();
        }

        public ICollection<Country> GetCountries()
        {
            return context.Countries.OrderBy(c => c.Name).ToList();
        }

        public Country GetCountry(int id)
        {
            return context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return context.Owners.Where(o => o.Id == ownerId)
                .Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return context.Owners.Where(o => o.Country.Id == countryId).ToList();
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateCountry(Country country)
        {
            context.Update(country);
            return Save();
        }

    }
}
