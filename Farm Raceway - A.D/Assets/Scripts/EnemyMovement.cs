using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoMove : MonoBehaviour
    {
        public float speed = 1.0f;
        public Transform target;
        public NavMeshAgent agent;
        public float aggroRange;
        public Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
        target = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
void Update()
    {
     if(Vector3.Distance(target.position, transform.position) <= aggroRange)
        {
            agent.SetDestination(target.position);
        }
     else if (Vector3.Distance(target.position, transform.position) > aggroRange)
        {
            agent.SetDestination(startingPosition);
        }
    }
}

/*public class AgentController : MonoBehaviour
{
    
}*/
