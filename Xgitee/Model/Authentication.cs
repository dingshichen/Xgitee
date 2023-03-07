namespace Xgitee.Model;

/// <summary>
/// 账号密码认证
/// </summary>
public class Authentication
{
    private string Email { get; }
    
    private string Password { get; }

    public Authentication(string email, string password)
    {
        Email = email;
        Password = password;
    }
}