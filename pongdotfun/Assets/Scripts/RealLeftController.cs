using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealLeftController : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float Speed;
    Vector2 movementy = new Vector2(0, 10);
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxis("VerticalLeft") > 0.1 && transform.position.y < 3.5)
        {
       
            transform.position += new Vector3(0,5,0) * Time.deltaTime;
        }
        else if (Input.GetAxis("VerticalLeft") < -0.1 && transform.position.y > -3.5)
        {
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
        } 
        

    }
}
