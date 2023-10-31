using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghosts : MonoBehaviour
{
    public GameObject ghost;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(ghost);
        }
    }

}
