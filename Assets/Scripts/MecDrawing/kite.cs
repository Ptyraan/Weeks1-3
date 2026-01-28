using UnityEngine;
using UnityEngine.InputSystem;

public class kite : MonoBehaviour
{
    public float xOffset = 0;
    public float yOffset = 0;
    public AnimationCurve curve;
    public Transform top;
    public Transform bottom;
    public float t = 0;
    public float v = 0;
    float y = 0;
    Vector2 pos;

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
        pos = Vector2.Lerp(top.transform.position, bottom.transform.position, y);
        pos.x += xOffset;
        pos.y += yOffset;
        transform.position = pos;
    }
}
