using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public static class JsonReader
{
    /// <summary>
    /// Read and deserialize a json in a Dictionary
    /// </summary>
    /// <typeparam name="TKey">Dictionary key taken from Json</typeparam>
    /// <typeparam name="TValue">Dictionary value taken from Json</typeparam>
    /// <param name="json">Json file in string format</param>
    /// <returns></returns>
    /// 
    public static Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(string json)
    {
        Dictionary<TKey, TValue> jsonDictionary = JsonConvert.DeserializeObject<Dictionary<TKey, TValue>>(json);
        return jsonDictionary;
    }

    /// <summary>
    /// Read and return the json of a specified path
    /// </summary>
    /// <param name="jsonPath">Json path to be read</param>
    /// <returns></returns>
    public static string GetJsonFromFile(string jsonPath)
    {
        StreamReader streamReader = new StreamReader(jsonPath);
        string json = streamReader.ReadToEnd();
        streamReader.Close();

        return json;
    }
}
