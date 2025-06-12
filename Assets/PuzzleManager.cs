using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool redPlaced = false;
    public bool greenPlaced = false;
    public bool bluePlaced = false;

    public GameObject successUI;

    public void CheckCompletion()
    {
        if (redPlaced && greenPlaced && bluePlaced)
        {
            Debug.Log("✅ Puzzle Completed");
            successUI.SetActive(true);
        }
    }
}
