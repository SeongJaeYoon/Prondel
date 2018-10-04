using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Missle_Shot : MonoBehaviour
{

    public float MoveSpeed;
    public float DestroyYPos;

   

    void Update()
    {
        transform.Translate(Vector2.up * -MoveSpeed * Time.deltaTime);

        if (transform.position.y <= DestroyYPos)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
