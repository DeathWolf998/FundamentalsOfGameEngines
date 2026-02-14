using UnityEngine;

public class Caller : MonoBehaviour
{
    [SerializeField]
    Receiver knownReceiver;

    void Start()
    {
        print("Hello, darkness my old friend");
        print(knownReceiver.OnCalled());
    }
}
