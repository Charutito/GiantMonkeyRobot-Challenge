using System.Collections.Generic;

public interface IView
{
    void SetTitle(string title);
    void SetContent(List<string> headers, List<Dictionary<string, string>> data);
}
