using UnityEngine;

public class ThirdScript : MonoBehaviour
{
    public float xspeed = 0.02f;
    public float yspeed = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += xspeed;
        newPos.y += yspeed;
        transform.position = newPos;

        if (transform.position.x < -9 || transform.position.x > 9)
        {
            xspeed = xspeed * -1;
        }
        if (transform.position.y < -5 || transform.position.y > 5)
        {
            yspeed = yspeed * -1;
        }
    }
}
