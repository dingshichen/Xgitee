namespace Xgitee.Command;

/// <summary>
/// 分页参数
/// </summary>
public class PageInfoCmd
{
    /// <summary>
    /// 当前的页码
    /// </summary>
    protected int Page { get; }
    
    /// <summary>
    /// 每页的数量，最大为 100
    /// </summary>
    protected int PerPage { get; }
}