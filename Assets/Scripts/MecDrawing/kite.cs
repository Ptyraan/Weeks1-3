using UnityEngine;
using UnityEngine.InputSystem;

public class kite : MonoBehaviour
{
    public float offset;
    public AnimationCurve curve;
    public Transform top;
    public Transform bottom;
    public float t = 0;
    public float v = 0;
    float y = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * v;
        if (t > 1 || t < 0)
        {
            v = -v;
        }
        y = curve.Evaluate(t);
        transform.position = Vector2.Lerp(top.transform.position, bottom.transform.position, y);
    }
}
