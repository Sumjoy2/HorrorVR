using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class AInotfollowing : MonoBehaviour
{
    [SerializeField] private Transform movepositionTransform;
    public GameObject player;
    private NavMeshAgent NavMeshAgent;
    private void Awake()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        NavMeshAgent.destination = movepositionTransform.position;
    }
    /* private void OnTriggerEnter(Collider other)
     {
         Debug.Log("thing" );
     }
    */
    private void OnTriggerEnter(Collider other )
    {
        Debug.Log("it did not" );
        if (other.tag ==  "player")
        {
            Debug.Log("it wolked");
            
        }
    }
}