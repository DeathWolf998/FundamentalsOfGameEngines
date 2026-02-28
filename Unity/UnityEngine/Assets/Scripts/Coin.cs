using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Coin Collected");
        }
    }
}
