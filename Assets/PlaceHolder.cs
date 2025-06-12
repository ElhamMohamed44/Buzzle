using UnityEngine;

public class Placeholder : MonoBehaviour
{
    public string requiredTag;
    public PuzzleManager puzzleManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(requiredTag))
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Collider>().enabled = false;

            if (requiredTag == "Red") puzzleManager.redPlaced = true;
            if (requiredTag == "Green") puzzleManager.greenPlaced = true;
            if (requiredTag == "Blue") puzzleManager.bluePlaced = true;

            puzzleManager.CheckCompletion();
        }
    }
}
