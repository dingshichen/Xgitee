namespace Xgitee.Command;

/// <summary>
/// 获取某个企业的所有 Issues 的 API 入参
/// </summary>
public class GetIssuesByEntCmd : PageInfoCmd
{
    /// <summary>
    /// 用户授权码
    /// </summary>
    private string AccessToken { get; }
    
    /// <summary>
    /// ssue的状态: open（开启的）, progressing(进行中), closed（关闭的）, rejected（拒绝的）。 默认: open
    /// </summary>
    private string State { get; }
    
    /// <summary>
    /// 用逗号分开的标签。如: bug,performance
    /// </summary>
    private string Labels { get; }
    
    /// <summary>
    /// 排序依据: 创建时间(created)，更新时间(updated_at)。默认: created_at
    /// </summary>
    private string Sort { get; }
    
    /// <summary>
    /// 排序方式: 升序(asc)，降序(desc)。默认: desc
    /// </summary>
    private string Direction { get; }
    
    /// <summary>
    /// 起始的更新时间，要求时间格式为 ISO 8601
    /// </summary>
    private string Since { get; }
    
    /// <summary>
    /// 计划开始日期，格式：20181006T173008+80-20181007T173008+80（区间），或者 -20181007T173008+80（小于20181007T173008+80），或者 20181006T173008+80-（大于20181006T173008+80），要求时间格式为20181006T173008+80
    /// </summary>
    private string Schedule { get; }
    
    /// <summary>
    /// 计划截止日期，格式同上
    /// </summary>
    private string Deadline { get; }
    
    /// <summary>
    /// 任务创建时间，格式同上
    /// </summary>
    private string CreatedAt { get; }
    
    /// <summary>
    /// 任务完成时间，即任务最后一次转为已完成状态的时间点。格式同上
    /// </summary>
    private string FinishedAt { get; }
    
    /// <summary>
    /// 根据里程碑标题。none为没里程碑的，*为所有带里程碑的
    /// </summary>
    private string Milestone { get; }
    
    /// <summary>
    /// 用户的username。 none为没指派者, *为所有带有指派者的
    /// </summary>
    private string Assignee { get; }
    
    /// <summary>
    /// 创建Issues的用户username
    /// </summary>
    private string Creator { get; }
    
    /// <summary>
    /// 所属项目名称。none为没所属有项目的，*为所有带所属项目的
    /// </summary>
    private string Program { get; }
}