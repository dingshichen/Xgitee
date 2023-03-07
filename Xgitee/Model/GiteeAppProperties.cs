namespace Xgitee.Model;

/// <summary>
/// Gitee 第三方应用
/// </summary>
public class GiteeAppProperties
{
    private string ClientId { get; }

    private string ClientSecret { get; }

    public GiteeAppProperties(string clientId, string clientSecret)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
    }
}