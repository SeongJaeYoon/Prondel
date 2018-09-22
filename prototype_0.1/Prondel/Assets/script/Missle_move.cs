using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle_move : MonoBehaviour {

    public float MoveSpeed;     // 미사일이 날라가는 속도
    public float DestroyYPos;   // 미사일이 사라지는 지점

    void Update()
    {
        transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);

        if (transform.position.y >= DestroyYPos)
        {
            Destroy(gameObject);
        }
    }

}
