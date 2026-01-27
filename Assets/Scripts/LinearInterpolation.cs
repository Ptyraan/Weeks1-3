using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0;
    public float v = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * v;
        if (t > 1) {
            t = 0;
        }
        transform.position = Vector2.Lerp(start.transform.position, end.transform.position, t);
    }
}
