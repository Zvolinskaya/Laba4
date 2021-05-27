using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    private Animator animator;
    private bool run = false;
    private NavMeshAgent NavMeshAgent;



    void Start()
    {
        animator = GetComponent<Animator>();
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit, 100))
            {
                NavMeshAgent.destination = hit.point;
            }
        }

        run = NavMeshAgent.remainingDistance > NavMeshAgent.stoppingDistance;

        animator.SetBool("Run", run);
    }
}