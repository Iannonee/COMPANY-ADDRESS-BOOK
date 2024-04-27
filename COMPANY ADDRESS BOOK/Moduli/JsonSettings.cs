using System;

public class JsonSettings
{
    public Working Working { get; set; }
    public Access Access { get; set; }
}

public class Working
{
    public bool Debug { get; set; }
}


public class Access
{
    public string Provider { get; set; }
    public string PersistSecurityInfo { get; set; }
}
