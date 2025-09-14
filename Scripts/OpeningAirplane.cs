using UnityEngine;

public class OpeningAirplane : MonoBehaviour
{
    Rigidbody2D opening;
    float theTimer = 0;
    float jampTime = 1f;
    float jamping = 5f;

    void Start()
    {
        opening = GetComponent<Rigidbody2D>();
        Physics2D.gravity = new Vector2(0, -5); // �d�͂�ݒ�
    }

    void Update()
    {
        theTimer += Time.deltaTime;
        if (theTimer >= jampTime)
        {
            theTimer = 0;
            opening.linearVelocity = Vector2.up * jamping;
        }
    }
}