using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    float teleportOffset;
    public bool Verticalteleport;

    private void Start()
    {
        
        if (Verticalteleport)
        {
            teleportOffset = gameObject.transform.GetChild(0).position.y - gameObject.transform.position.y;
        }
        else
        {
            teleportOffset = gameObject.transform.GetChild(0).position.x - gameObject.transform.position.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if(Verticalteleport)
        {
            Vector3 tempPosition = collidedObject.transform.position;
            collidedObject.transform.position = tempPosition + new Vector3(0.0f, teleportOffset, 0.0f);
        }
        else
        {
            Vector3 tempPosition = collidedObject.transform.position;
            collidedObject.transform.position = tempPosition + new Vector3(teleportOffset, 0.0f , 0.0f);
        }
        

    }
}
