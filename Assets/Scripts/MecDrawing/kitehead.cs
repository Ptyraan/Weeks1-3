using UnityEngine;
using UnityEngine.InputSystem;

public class kitehead : MonoBehaviour
{
    public float offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // this is literally just track mouse but has an option to offset it vertically
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos.y += offset;
        transform.position = mousePos;
    }
}
