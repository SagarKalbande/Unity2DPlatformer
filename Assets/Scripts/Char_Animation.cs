using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Animation : MonoBehaviour {

    Animator CharacterAnimator;
    Rigidbody2D Body;
    BoxCollider2D BodyCollider;
    bool LookingRight = true;
    bool isgrounded;
    public GameObject BulletRef;

	void Start () {
        CharacterAnimator = GetComponent<Animator>();
        Body = GetComponent<Rigidbody2D>();
        BodyCollider = GetComponent<BoxCollider2D>();
	}
	

	void Update ()
    {
        if (isgrounded)
        {
            CharacterAnimator.SetBool("Jump", false);
        }
        if (Input.GetKeyDown("up"))
        {
            //Body.velocity = new Vector3(0.0f, 10.0f, 0.0f);
            //CharacterAnimator.SetBool("Jump", true);
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
            //SpawnBullet();
        }

        else
        {
            CharacterAnimator.SetBool("Shoot", false);
            CharacterAnimator.SetBool("Run", false);
            CharacterAnimator.SetBool("Slide", false);
            CharacterAnimator.SetBool("Meele", false);
        }
	}

    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            isgrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            isgrounded = false;
            CharacterAnimator.SetBool("Jump", true);
        }
    }
    void SpawnBullet()
    {
        GameObject SpawnedBullet = Instantiate(BulletRef, this.gameObject.transform.GetChild(0).position , Quaternion.identity);
        if (LookingRight)
        {
            SpawnedBullet.GetComponent<BulletBehavior>().direction = 1;
        }
        else
        {
            SpawnedBullet.GetComponent<BulletBehavior>().direction = -1;
        }

    }
}
