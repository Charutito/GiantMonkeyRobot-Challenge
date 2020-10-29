using System.Collections.Generic;

public class ChallengeTableModel : IModel
{
    public string JsonPath { get; set; }

    private Dictionary<string, object> json;

    public ChallengeTableModel(string jsonPath)
    {
        JsonPath = jsonPath;
        LoadJson();
    }

    public void LoadJson()
    {
        string jsonString = JsonReader.GetJsonFromFile(JsonPath);
        json = new Dictionary<string, object>();
        json = JsonReader.GetDictionary<string, object>(jsonString);            
    }

    public string Title
    {
        get
        {
            return json.ContainsKey(StringManager.TITLE) ? json[StringManager.TITLE].ToString() : StringManager.DEFAULTTITLE;
        }
    }

    public List<string> GetHeaders()
    {
        List<string> headers = null;
        if (json.ContainsKey(StringManager.COLUMNHEADERS))
        {
            string headersString = json[StringManager.COLUMNHEADERS].ToString();
            headers = JsonReader.GetList<string>(headersString);
        }

        return headers;
    }

    public List<Dictionary<string, string>> GetContentData()
    {
        List<Dictionary<string, string>> data = null;

        if (json.ContainsKey(StringManager.COLUMNHEADERS))
        {
            string dataString = json[StringManager.DATA].ToString();
            data = JsonReader.GetList<Dictionary<string, string>>(dataString);
        }

        return data;
    }
}
