using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   [SerializeField] private Bag playerBag;
    public LayerMask playerMask;
    private int earnedPoints = 1;
    private float radius = 0.3f;

    private void Start()
    {
        playerBag = GameObject.FindGameObjectWithTag("Bag").GetComponent<Bag>();
    }
    private void Update()
    {
        Collider2D player = Physics2D.OverlapCircle(gameObject.transform.position, radius, playerMask);

        if (player != null )
        {
            playerBag.points += earnedPoints;
            Destroy(gameObject);
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(gameObject.transform.position, radius);
    }
}
