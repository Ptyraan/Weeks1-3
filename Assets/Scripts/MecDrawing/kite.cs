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
        t += -xOffset / 20;
    }

    // Update is called once per frame
    // top right is (9, 5)
    void Update()
    {
        // kite waves faster if higher, v is the speed the up and down Lerp uses
        t += Time.deltaTime * v * (1 + (top.transform.position.y + 5) / 25);
        if (t > 1)
        {
            t = 1;
            v = -v;
        }
        if (t < 0)
        {
            t = 0;
            v = -v;
        }
        // translates linear interpolation to the curve
        y = curve.Evaluate(t);
        pos = Vector2.Lerp(top.transform.position, bottom.transform.position, y);
        // kite is stretched more the more it is to the right, xOffset is how much the segment trails behind the head
        pos.x += xOffset * (1 - (top.transform.position.x) / 90);
        pos.y += yOffset;
        transform.position = pos;
    }
}
