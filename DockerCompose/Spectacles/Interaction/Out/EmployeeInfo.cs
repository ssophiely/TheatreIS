﻿namespace Spectacles.Interaction.Out;

public class EmployeeInfo
{
    public string FullName { get; set; } = null!;

    public int Experience { get; set; }

    public string? Phone { get; set; }

    public string Position { get; set; } = null!;

    public List<RoleInfo>? Role { get; set; } = null!;
}

public class RoleInfo
{
    public string Name { get; set; } = null!;

    public string Spectacle { get; set; } = null!;
}
