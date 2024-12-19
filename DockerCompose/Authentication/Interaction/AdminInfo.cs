namespace Authentication.Interaction;

public class AdminAddInfo
{
    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;
}

public class AdminAuthInfo
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;
}