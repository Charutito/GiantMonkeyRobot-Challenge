using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeTableView : MonoBehaviour, IView
{
    [SerializeField]
    private Button refreshButton;
    [SerializeField]
    private Text title;
    [SerializeField]
    private ChallengeTableData rowObjectPrefab;
    [SerializeField]
    private VerticalLayoutGroup contentContainer;
    [SerializeField]
    private ChallengeTableItemText contentHeaderPrefab;
    [SerializeField]
    private ChallengeTableItemText contentPrefab;

    public void SetTitle(string title)
    {
        this.title.text = title;
    }

    public void SetContent(List<string> headers, List<Dictionary<string, string>> data)
    {
        SetupHeaders(headers);
        SetupContentData(data);
    }

    private void SetupHeaders(List<string> headers)
    {
        ChallengeTableData headerContentData = Instantiate(rowObjectPrefab, contentContainer.transform);
        headerContentData.Setup(contentHeaderPrefab, headers);
        //cachedColumnContent.Add(headerContentData);
    }

    private void SetupContentData(List<Dictionary<string, string>> contentData)
    {
        for (int i = 0; i < contentData.Count; i++)
        {
            ChallengeTableData data = Instantiate(rowObjectPrefab, contentContainer.transform);
            List<string> contentList = new List<string>();
            foreach (KeyValuePair<string, string> item in contentData[i])
            {
                contentList.Add(item.Value);
            }

            data.Setup(contentPrefab, contentList);
            //cachedColumnContent.Add(data);
        }
    }
}
