using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        PickRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true) {
            spriteRenderer.color = Random.ColorHSV();
        }
    }

    void PickRandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
