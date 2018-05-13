using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float direction;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(direction*0.1f, 0.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.tag == "Zombie")
        {
            Destroy(collidedObject.gameObject);
        }

    }


}
