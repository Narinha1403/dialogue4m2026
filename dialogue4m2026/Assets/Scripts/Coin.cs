using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerObserverManager.OnCoinCollected?.Invoke(1);
            Destroy(gameObject);
        }
    }
}