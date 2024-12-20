﻿namespace Authentication.Interaction;

public class ViewerAddInfo
{
    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;
}

public class ViewerAuthInfo
{
    public int Id { get; set; }

    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;
}
