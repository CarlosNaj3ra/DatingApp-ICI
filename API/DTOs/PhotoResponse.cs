using System.Diagnostics.CodeAnalysis;

namespace API.DTOs;

[ExcludeFromCodeCoverage]
public class PhotoResponse
{
    public int Id { get; set; }
    public string? Url { get; set; }
    public bool IsMain { get; set; }
}