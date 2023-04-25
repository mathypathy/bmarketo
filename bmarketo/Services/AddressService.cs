using bmarketo.Contexts.Identity;
using bmarketo.Models.Entities;
using bmarketo.Repos;
using Microsoft.Identity.Client;

namespace bmarketo.Services
{
    public class AddressService
    {
        private readonly AddressRepository _addressRepo;
        private readonly UserAddressRepository _userAdressRepository;
        
        public AddressService(AddressRepository addressRepo, UserAddressRepository userAddressRepository)
        {
            _addressRepo = addressRepo; 
            _userAdressRepository = userAddressRepository;
        }


        public async Task<AdressEntity> GetOrCreateAsync(AdressEntity adressEntity)
        {
            var entity = await _addressRepo.GetAsync(x =>
            x.StreetName == adressEntity.StreetName &&
            x.PostalCode == adressEntity.PostalCode &&
            x.City == adressEntity.City
            );
            entity ??= await _addressRepo.AddAsync(adressEntity);
            return entity!;
        }
        public async Task AddAddressAsync(AppUser user, AdressEntity adressEntity)
        {
            await _userAdressRepository.AddAsync(new UserAdressEntity
            {
                UserId = user.Id,
                AddressID = adressEntity.Id,
            });
        }
        

      
      
    }
}
