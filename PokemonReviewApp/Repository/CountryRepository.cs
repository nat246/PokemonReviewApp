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
            return context.
        }

        public ICollection<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
