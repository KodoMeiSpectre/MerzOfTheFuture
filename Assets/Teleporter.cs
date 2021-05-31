using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject exit;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = exit.transform.position;
    }
}
