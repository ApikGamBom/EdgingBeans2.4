using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    public GameObject goal;

    void Start ()
    {
        target = playerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update ()
    {
        agent.SetDestination(goal.transform.position);
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius )
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                //attack player
                FaceTarget();
            }
        }
    }
    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}