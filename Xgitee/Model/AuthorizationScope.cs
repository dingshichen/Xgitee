using System.ComponentModel;

namespace Xgitee.Model;

/// <summary>
/// 授权范围
/// </summary>
public enum AuthorizationScope
{
    [Description("projects")]
    Projects,
    
    [Description("user_info")]
    UserInfo,
    
    [Description("issues")]
    Issues,
    
    [Description("notes")]
    Notes,
    
    [Description("pull_requests")]
    PullRequests,
    
    [Description("keys")]
    Keys,
    
    [Description("hook")]
    Hook,
    
    [Description("groups")]
    Groups,
    
    [Description("gists")]
    Gists,
    
    [Description("enterprises")]
    Enterprises,
}