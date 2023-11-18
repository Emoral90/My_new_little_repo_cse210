using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

class myJSON
{
    //Attributes
    private string filePath = "NT.json";
    static string jsonScriptures;

    // Deserialize json into a dictionary
    private Dictionary<string, object> dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonScriptures);

    // Methods
    public void getScriptures()
    {
        // Read Json data from a file
        using (StreamReader sr = new StreamReader(filePath))
        {
            jsonScriptures = sr.ReadToEnd();
        }

        string reference = dict["reference"].ToString();
        Console.WriteLine(reference);

    }
}