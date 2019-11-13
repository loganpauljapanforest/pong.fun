using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftController : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float Speed;
    Vector2 movementx = new Vector2(20, 0);
    Vector2 movementy = new Vector2(0, 20);
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetAxis("VerticalLeft") > 0.1) // up
            {

                myRigidBody.AddForce(movementy);
            }

            if (Input.GetAxis("VerticalLeft") < -0.1) // down
            {
                myRigidBody.AddForce(-movementy);
            }

            if (Input.GetAxis("HorizontalLeft") > 0.1 && myRigidBody.transform.position.x < -2) // right
            {

                myRigidBody.AddForce(movementx);
                if (myRigidBody.transform.position.x > -2f)
                {
                myRigidBody.velocity = new Vector3(0, 0, 0);
                }
             }

            if (Input.GetAxis("HorizontalLeft") < -0.1) // left
            {
                myRigidBody.AddForce(-movementx);
            }
             

    }
}
