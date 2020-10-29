using System.Collections.Generic;
using UnityEngine;

public class ChallengeTableData : MonoBehaviour
{   
    public void Setup(ChallengeTableItemText textContentPrefab, List<string> contentData)
    {
        for (int i = 0; i < contentData.Count; i++)
        {
            ChallengeTableItemText contentText = GameObject.Instantiate(textContentPrefab, transform);
            contentText.Setup(contentData[i]);
        }
    }
}
