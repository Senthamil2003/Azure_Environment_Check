using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WebApplication3.Controllers;

[ApiController]
[Route("[controller]")]
public class SystemDetailsController : ControllerBase
{
    private readonly IWebHostEnvironment _environment;

    public SystemDetailsController(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    [HttpGet(Name = "GetSystemDetails")]
    public IActionResult GetSystemDetails()
    {
        var systemDetails = new[]
        {
            new { Category = "Environment", Key = "ASPNETCORE_ENVIRONMENT", Value = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production" },
            new { Category = "Environment", Key = "Environment Name", Value = _environment.EnvironmentName },
            new { Category = "Environment", Key = "Content Root Path", Value = _environment.ContentRootPath },
            new { Category = "Environment", Key = "Web Root Path", Value = _environment.WebRootPath },
            new { Category = "Environment", Key = "Is Development", Value = _environment.IsDevelopment().ToString() },
            new { Category = "Environment", Key = "Is Production", Value = _environment.IsProduction().ToString() },
            new { Category = "Environment", Key = "Is Staging", Value = _environment.IsStaging().ToString() },
            
            new { Category = "System", Key = "Machine Name", Value = Environment.MachineName },
            new { Category = "System", Key = "User Name", Value = Environment.UserName },
            new { Category = "System", Key = "OS Version", Value = Environment.OSVersion.ToString() },
            new { Category = "System", Key = "OS Platform", Value = RuntimeInformation.OSDescription },
            new { Category = "System", Key = "OS Architecture", Value = RuntimeInformation.OSArchitecture.ToString() },
            new { Category = "System", Key = "Process Architecture", Value = RuntimeInformation.ProcessArchitecture.ToString() },
            new { Category = "System", Key = "Is 64-bit OS", Value = Environment.Is64BitOperatingSystem.ToString() },
            new { Category = "System", Key = "Is 64-bit Process", Value = Environment.Is64BitProcess.ToString() },
            
            new { Category = "Hardware", Key = "Processor Count", Value = Environment.ProcessorCount.ToString() },
            new { Category = "Hardware", Key = "System Page Size", Value = Environment.SystemPageSize.ToString() },
            new { Category = "Hardware", Key = "Working Set (bytes)", Value = Environment.WorkingSet.ToString() },
            
            new { Category = "Runtime", Key = ".NET Version", Value = RuntimeInformation.FrameworkDescription },
            new { Category = "Runtime", Key = "Runtime Identifier", Value = RuntimeInformation.RuntimeIdentifier },
            new { Category = "Runtime", Key = "CLR Version", Value = Environment.Version.ToString() },
            new { Category = "Runtime", Key = "Current Directory", Value = Environment.CurrentDirectory },
            new { Category = "Runtime", Key = "System Directory", Value = Environment.SystemDirectory },
            new { Category = "Runtime", Key = "Has Shutdown Started", Value = Environment.HasShutdownStarted.ToString() },
            
            new { Category = "Application", Key = "Application Name", Value = Assembly.GetExecutingAssembly().GetName().Name ?? "Unknown" },
            new { Category = "Application", Key = "Application Version", Value = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown" },
            new { Category = "Application", Key = "Entry Assembly", Value = Assembly.GetEntryAssembly()?.GetName().Name ?? "Unknown" },
            new { Category = "Application", Key = "Process ID", Value = Environment.ProcessId.ToString() },
            new { Category = "Application", Key = "Command Line", Value = Environment.CommandLine },
            new { Category = "Application", Key = "Startup Time", Value = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC") },
            
            new { Category = "Memory", Key = "GC Total Memory (bytes)", Value = GC.GetTotalMemory(false).ToString() },
            new { Category = "Memory", Key = "GC Generation 0 Collections", Value = GC.CollectionCount(0).ToString() },
            new { Category = "Memory", Key = "GC Generation 1 Collections", Value = GC.CollectionCount(1).ToString() },
            new { Category = "Memory", Key = "GC Generation 2 Collections", Value = GC.CollectionCount(2).ToString() },
            
            new { Category = "Network", Key = "Host Name", Value = System.Net.Dns.GetHostName() },
            new { Category = "Network", Key = "Domain Name", Value = Environment.UserDomainName },
            
            new { Category = "Time", Key = "Current UTC Time", Value = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC") },
            new { Category = "Time", Key = "Current Local Time", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
            new { Category = "Time", Key = "Time Zone", Value = TimeZoneInfo.Local.DisplayName },
            new { Category = "Time", Key = "Tick Count", Value = Environment.TickCount64.ToString() }
        };

        return Ok(systemDetails);
    }

    [HttpGet("grouped", Name = "GetSystemDetailsGrouped")]
    public IActionResult GetSystemDetailsGrouped()
    {
        var systemDetails = new[]
        {
            new { Category = "Environment", Key = "ASPNETCORE_ENVIRONMENT", Value = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production" },
            new { Category = "Environment", Key = "Environment Name", Value = _environment.EnvironmentName },
            new { Category = "Environment", Key = "Content Root Path", Value = _environment.ContentRootPath },
            new { Category = "Environment", Key = "Web Root Path", Value = _environment.WebRootPath },
            new { Category = "Environment", Key = "Is Development", Value = _environment.IsDevelopment().ToString() },
            new { Category = "Environment", Key = "Is Production", Value = _environment.IsProduction().ToString() },
            new { Category = "Environment", Key = "Is Staging", Value = _environment.IsStaging().ToString() },
            
            new { Category = "System", Key = "Machine Name", Value = Environment.MachineName },
            new { Category = "System", Key = "User Name", Value = Environment.UserName },
            new { Category = "System", Key = "OS Version", Value = Environment.OSVersion.ToString() },
            new { Category = "System", Key = "OS Platform", Value = RuntimeInformation.OSDescription },
            new { Category = "System", Key = "OS Architecture", Value = RuntimeInformation.OSArchitecture.ToString() },
            new { Category = "System", Key = "Process Architecture", Value = RuntimeInformation.ProcessArchitecture.ToString() },
            new { Category = "System", Key = "Is 64-bit OS", Value = Environment.Is64BitOperatingSystem.ToString() },
            new { Category = "System", Key = "Is 64-bit Process", Value = Environment.Is64BitProcess.ToString() },
            
            new { Category = "Hardware", Key = "Processor Count", Value = Environment.ProcessorCount.ToString() },
            new { Category = "Hardware", Key = "System Page Size", Value = Environment.SystemPageSize.ToString() },
            new { Category = "Hardware", Key = "Working Set (bytes)", Value = Environment.WorkingSet.ToString() },
            
            new { Category = "Runtime", Key = ".NET Version", Value = RuntimeInformation.FrameworkDescription },
            new { Category = "Runtime", Key = "Runtime Identifier", Value = RuntimeInformation.RuntimeIdentifier },
            new { Category = "Runtime", Key = "CLR Version", Value = Environment.Version.ToString() },
            new { Category = "Runtime", Key = "Current Directory", Value = Environment.CurrentDirectory },
            new { Category = "Runtime", Key = "System Directory", Value = Environment.SystemDirectory },
            new { Category = "Runtime", Key = "Has Shutdown Started", Value = Environment.HasShutdownStarted.ToString() },
            
            new { Category = "Application", Key = "Application Name", Value = Assembly.GetExecutingAssembly().GetName().Name ?? "Unknown" },
            new { Category = "Application", Key = "Application Version", Value = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown" },
            new { Category = "Application", Key = "Entry Assembly", Value = Assembly.GetEntryAssembly()?.GetName().Name ?? "Unknown" },
            new { Category = "Application", Key = "Process ID", Value = Environment.ProcessId.ToString() },
            new { Category = "Application", Key = "Command Line", Value = Environment.CommandLine },
            new { Category = "Application", Key = "Startup Time", Value = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC") },
            
            new { Category = "Memory", Key = "GC Total Memory (bytes)", Value = GC.GetTotalMemory(false).ToString() },
            new { Category = "Memory", Key = "GC Generation 0 Collections", Value = GC.CollectionCount(0).ToString() },
            new { Category = "Memory", Key = "GC Generation 1 Collections", Value = GC.CollectionCount(1).ToString() },
            new { Category = "Memory", Key = "GC Generation 2 Collections", Value = GC.CollectionCount(2).ToString() },
            
            new { Category = "Network", Key = "Host Name", Value = System.Net.Dns.GetHostName() },
            new { Category = "Network", Key = "Domain Name", Value = Environment.UserDomainName },
            
            new { Category = "Time", Key = "Current UTC Time", Value = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC") },
            new { Category = "Time", Key = "Current Local Time", Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
            new { Category = "Time", Key = "Time Zone", Value = TimeZoneInfo.Local.DisplayName },
            new { Category = "Time", Key = "Tick Count", Value = Environment.TickCount64.ToString() }
        };

        var groupedDetails = systemDetails
            .GroupBy(x => x.Category)
            .ToDictionary(
                g => g.Key,
                g => g.Select(x => new { x.Key, x.Value }).ToArray()
            );

        return Ok(groupedDetails);
    }
}
