using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Animation : MonoBehaviour {

    Animator CharacterAnimator;
    Rigidbody2D Body;
    bool LookingRight = true;

	void Start () {
        CharacterAnimator = GetComponent<Animator>();
        Body = GetComponent<Rigidbody2D>();
	}
	

	void Update ()
    {
        if (Input.GetKeyDown("up"))
        {
            Body.velocity = new Vector3(0.0f, 10.0f, 0.0f);
        }

        if (Input.GetKey("right"))
        {
            if (!LookingRight)
            {
                gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), 180);
                LookingRight = true;
            }
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.1f, 0.0f, 0.0f);
            CharacterAnimator.SetBool("Run", true);
        }
        else if (Input.GetKey("left"))
        {
            if (LookingRight)
            {
                gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), 180);
                LookingRight = false;
            }
            gameObject.transform.position = gameObject.transform.position + new Vector3(-0.1f, 0.0f, 0.0f);
            CharacterAnimator.SetBool("Run", true);
        }
        else if (Input.GetKey("down"))
        {
            CharacterAnimator.SetBool("Slide", true);
        }
 
        else if (Input.GetKey("z"))
        {
            CharacterAnimator.SetBool("Meele", true);
        }
        else if (Input.GetKey("x"))
        {
            CharacterAnimator.SetBool("Shoot", true);
        }

        else
        {
            CharacterAnimator.SetBool("Shoot", false);
            CharacterAnimator.SetBool("Run", false);
            CharacterAnimator.SetBool("Slide", false);
            CharacterAnimator.SetBool("Meele", false);
        }
	}
}
