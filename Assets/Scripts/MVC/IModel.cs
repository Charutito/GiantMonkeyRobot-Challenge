using System.Collections.Generic;

public interface IModel
{
    string Title { get; }
    string JsonPath { get; set; }
    void LoadJson();
    List<string> GetHeaders();
    List<Dictionary<string, string>> GetContentData();
}
