using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_Ball : MonoBehaviour
{
    [SerializeField]
    private float radius;
    private Transform player;

    void Start()
    {
        player = FindObjectOfType<Move>().transform;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= radius)
        {
            Debug.Log("You pick up ball");
            Destroy(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
