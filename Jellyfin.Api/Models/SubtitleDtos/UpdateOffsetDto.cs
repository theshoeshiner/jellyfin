using System.ComponentModel.DataAnnotations;

namespace Jellyfin.Api.Models.SubtitleDtos;

/// <summary>
/// Update subtitles offset dto.
/// </summary>
public class UpdateOffsetDto
{
    /// <summary>
    /// Gets or sets the subtitle offset.
    /// </summary>
    [Required]
    public string Offset { get; set; } = string.Empty;
}
