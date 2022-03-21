using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDespawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Block"))
        {
            Destroy(other.gameObject);
        }

        Debug.Log($"Triggered {other.name}");
    }

}
