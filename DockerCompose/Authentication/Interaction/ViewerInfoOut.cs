namespace Authentication.Interaction;

public class ViewerInfoOut
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string Mail { get; set; } = null!;

    public string? Phone { get; set; }
}
