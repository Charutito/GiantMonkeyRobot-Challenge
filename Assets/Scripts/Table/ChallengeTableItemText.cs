using UnityEngine;
using UnityEngine.UI;

public class ChallengeTableItemText : MonoBehaviour
{
    [SerializeField]
    private Text textField;

    public void Setup(string text)
    {
        this.textField.text = text;
    }
}
