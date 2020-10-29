using System.Collections.Generic;

public interface IModel
{
    string Title { get; }
    string JsonPath { get; set; }
    List<string> GetHeaders();
    List<Dictionary<string, string>> GetContentData();
}
