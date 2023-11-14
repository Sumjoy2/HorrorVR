using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class ai : MonoBehaviour
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
}
