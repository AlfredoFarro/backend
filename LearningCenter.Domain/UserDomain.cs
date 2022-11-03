using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public class UserDomain :IUserDomain
{
    private readonly IUserRepository _userRepository;
    
    public UserDomain(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> Login(User user)
    {
        var result = await _userRepository.GetByUsername(user.Username);

        return result.Password == user.Password;
    }

    public async Task<bool> Signup(User user)
    {
        return await _userRepository.Singup(user);
    }
}