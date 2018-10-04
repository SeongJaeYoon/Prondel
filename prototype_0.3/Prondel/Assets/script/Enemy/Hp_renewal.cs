using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp_renewal : MonoBehaviour {

    public int HP;
    private Enemy_info EnemyInfo;
    private Roel_Info Roelinfo;
    
	void Start () {
        EnemyInfo = new Enemy_info(HP);
        Roelinfo = new Roel_Info();
	}

    void Update() {

        if (EnemyInfo.ReturnHP() <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.CompareTag("Player_Missle"))
        {
            EnemyInfo.DecreaseHP(Roelinfo.Damage);
        }
    }
}

