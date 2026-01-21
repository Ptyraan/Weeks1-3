using UnityEngine;

public class Clockrotation : MonoBehaviour
{
    public float speed;
    float angle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        angle = transform.rotation.z + 1;
        Quaternion newRot = new Quaternion(0, 0, angle, 0);
        transform.rotation = newRot;
    }
}
