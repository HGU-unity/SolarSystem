using UnityEngine;

public class Revolve : MonoBehaviour
{
    public float rate = 100.0f;
    private void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rate);
    }
}
