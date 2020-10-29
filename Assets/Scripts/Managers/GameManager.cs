using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform canvasContainer;
    [SerializeField]
    private ChallengeTableView tableControllerPrefab;

    private ChallengeTableView challengeTable;

    void Start()
    {
        string jsonFilePath = Application.streamingAssetsPath + "/JsonChallenge.json";

        challengeTable = Instantiate(tableControllerPrefab, canvasContainer);
        ChallengeTableModel tableModel = new ChallengeTableModel(jsonFilePath);

        ChallengeTableController tableController = new ChallengeTableController(tableModel, challengeTable);
    }

}
