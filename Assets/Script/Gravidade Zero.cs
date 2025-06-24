using UnityEngine;

public class GravidadeZero : MonoBehaviour
{
    void Start()
    {
        Physics.gravity = new Vector3(0, -4.6f, 0);
    }
}
