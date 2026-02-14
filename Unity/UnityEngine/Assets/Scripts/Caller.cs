using UnityEngine;

public class Caller : MonoBehaviour
{
    [SerializeField]
    private Receiver knownReceiver;
    private float timer = 5.0f;

    void Start()
    {
        print("Hello, darkness my old friend");
        print(knownReceiver.OnCalled());
    }

    private void Update()
    {
        if(timer <= 0)
        {
            timer = 5.0f;
            print("Hello, darkness my old friend");
            print(knownReceiver.OnCalled());
        }
        timer -= Time.deltaTime;

    }
}
