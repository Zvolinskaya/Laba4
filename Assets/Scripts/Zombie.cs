using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
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
            Debug.Log("I wanna kill you");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
