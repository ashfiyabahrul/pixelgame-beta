using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPosition : MonoBehaviour
{
    [SerializeField] private Transform destination;
    
    public Transform getDestination()
    {
        return destination;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = destination.position;
        }
    }

}
