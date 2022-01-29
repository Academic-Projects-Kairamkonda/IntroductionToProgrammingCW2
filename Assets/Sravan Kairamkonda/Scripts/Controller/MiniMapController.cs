using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 newPosition= player.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}
