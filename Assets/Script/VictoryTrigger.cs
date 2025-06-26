using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
   public VitoriaManager victoryManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victoryManager.Vitoria();
        }
    }
}


