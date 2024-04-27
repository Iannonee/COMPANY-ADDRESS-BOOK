using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public static class mpc
{
    //VA INSTALLATO TRAMITE NuGet NEWTONSOFT.JSON !!!!!!!
    public static JsonSettings settingsJson = JsonConvert.DeserializeObject<JsonSettings>(System.IO.File.ReadAllText("info.json"));
    public static void WriteJson()
    {
        File.WriteAllText("info.json", JsonConvert.SerializeObject(settingsJson));
    }
}
