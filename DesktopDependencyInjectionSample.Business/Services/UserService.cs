using DesktopDependencyInjectionSample.Domain.Entities;
using DesktopDependencyInjectionSample.Domain.Repositories;
using DesktopDependencyInjectionSample.Domain.Services;

namespace DesktopDependencyInjectionSample.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Add(User user)
        {
            _repository.Add(user);
        }
    }
}
