using System;
using System.Collections.Generic;

public interface IView
{
    event Action OnRefresh;
    void SetTitle(string title);
    void SetContent(List<string> headers, List<Dictionary<string, string>> data);
    void ClearView();
}
