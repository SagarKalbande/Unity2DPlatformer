using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    public GameObject Target;
    Animator ZombieAnimator;

	// Use this for initialization
	void Start ()
    {
        ZombieAnimator = GetComponent<Animator>();
	}   
	
	// Update is called once per frame
	void Update () {

        if (Target.transform.position.x > gameObject.transform.position.x)
        {
            gameObject.transform.position += new Vector3(0.01f, 0.0f, 0.0f);
        }
        if (Target.transform.position.x < gameObject.transform.position.x)
        {
            gameObject.transform.position += new Vector3(-0.01f, 0.0f, 0.0f);
        }
    }
}
