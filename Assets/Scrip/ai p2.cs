using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class aip2 : MonoBehaviour
{
    [SerializeField] private Transform movepositionTransform;

    private NavMeshAgent NavMeshAgent;
    private void Awake()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        NavMeshAgent.destination = movepositionTransform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Taggger")
        {
            Debug.Log("oee" + other.name);
        }
    }
}
