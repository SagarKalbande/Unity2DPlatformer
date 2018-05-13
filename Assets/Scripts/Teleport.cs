using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    float teleportValueOnAxis;
    public bool Verticalteleport;

    private void Start()
    {
        
        if (Verticalteleport)
        {
            teleportValueOnAxis = gameObject.transform.GetChild(0).position.y;
        }
        else
        {
            teleportValueOnAxis = gameObject.transform.GetChild(0).position.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.tag == "Player")
        {
            if (Verticalteleport)
            {
                Vector3 tempPosition = collidedObject.transform.position;
                collidedObject.transform.position = new Vector3(tempPosition.x, teleportValueOnAxis, 0.0f);
            }
            else
            {
                Vector3 tempPosition = collidedObject.transform.position;
                collidedObject.transform.position = new Vector3(teleportValueOnAxis, tempPosition.y, 0.0f);
            }
        }

        

    }
}
