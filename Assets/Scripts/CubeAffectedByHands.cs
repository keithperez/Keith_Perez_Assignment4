using System.Numerics;
using UnityEngine;

public class CubeAffectedByHands : MonoBehaviour
{

    bool spin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spin)
        {
            transform.Rotate(new UnityEngine.Vector3(0, 0, 1));
        }
    }

    public void startSpin()
    {
        spin = true;
    }

    public void stopSpin()
    {
        spin = false;
    }
}
