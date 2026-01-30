using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(
            x * speed * Time.deltaTime,
            y * speed * Time.deltaTime,
            0
        );
    }
}