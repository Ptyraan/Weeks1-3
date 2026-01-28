using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class kite : MonoBehaviour
{
    public float offset;
    public Transform top;
    public Transform bottom;
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
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(start.transform.position, end.transform.position, t);
        Vector2 Pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = Pos;
    }
}
