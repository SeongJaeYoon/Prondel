using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle_control : MonoBehaviour {

    public float MoveSpeed;    
    public float DestroyYPos;

    void Update()
    {
        transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);

        if (transform.position.y >= DestroyYPos)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}
    