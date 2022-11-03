using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public interface IUserDomain
{
    Task<bool> Login(User user);
    Task<bool> Signup(User user);
}