using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public EndTrigger()
    {
    }

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}