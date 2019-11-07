using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftController : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float Speed;
    Vector2 movement = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        movement.y = 20;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxis("VerticalLeft") > 0.1)
        {

            myRigidBody.AddForce(movement);
        }

        if (Input.GetAxis("VerticalLeft") < -0.1)
        {
            myRigidBody.AddForce(-movement);
        }

    }
}
