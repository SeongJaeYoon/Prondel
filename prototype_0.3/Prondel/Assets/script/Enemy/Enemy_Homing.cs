using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Homing : MonoBehaviour {
    
    public GameObject EnemyMissle;
    public Transform PlayerLocate;
    public float FireDelay;
    private bool FireState;
    private bool Fire;

    void Start () {
        FireState = true;
        Fire = true;
	}
	
	void Update () {
        Checking();
        LookAtPlayer();
        FireToPlayer();
	}

    private void Checking()
    {
        if (gameObject == null) Fire = false;
    }

    private void LookAtPlayer()
    {
        Vector3 dir = PlayerLocate.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
    }

    private void FireToPlayer()
    {
        if (Fire)
        {
            if (FireState)
            {
                StartCoroutine(FireCycleControl());

                Instantiate(EnemyMissle, transform.position, transform.rotation);
            }
        }
    }

    IEnumerator FireCycleControl()
    {
        FireState = false;

        yield return new WaitForSeconds(FireDelay);

        FireState = true;
    }

}
