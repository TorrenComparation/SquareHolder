using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpike : MonoBehaviour
{
    private PlayerStatistic statistic;
    public GameObject attackPosition;
    public LayerMask[] mask;

    private int damage = 1;
    private float radius = 0.25f;
    private bool isDestroy = false;
    private bool isShoot = false;

    private void Start()
    {
        statistic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatistic>();
    }
    private void Update()
    {
        isShoot = Physics2D.OverlapCircle(attackPosition.transform.position, radius, mask[0]);
        isDestroy = Physics2D.OverlapCircle(attackPosition.transform.position, radius, mask[1]);
        if (isShoot == true)
        {
            statistic.heath -= damage;
            Destroy(gameObject);
        }
        else if(isDestroy == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPosition.transform.position, radius);
    }
}
