namespace Aheadrace.SeedSystem.Business.Contracts.Login
{
    public interface ILoginBLL
    {
        bool ValidateLoginAndPrepareToken(string username, string password);
    }
}
