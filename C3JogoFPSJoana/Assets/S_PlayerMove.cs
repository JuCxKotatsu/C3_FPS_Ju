using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PlayerMove : MonoBehaviour
{
    Rigidbody myRigidbody;
    //Transform myTransform;

    [SerializeField] float walkSpeed = 100f;

    [SerializeField] float rotateSpeed = 50f;

    Vector3 Direction;

    [SerializeField] float jumpHeight = 100f;
    [SerializeField] float fallSpeed = 500f;



    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        //myTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        /* Jump */
        bool jumpInput = Input.GetButtonDown("Jump");

        //Vector3 walkDirection = new Vector3((transform.forward * walkSpeed), (transform.right * walkSpeed), 0);

        //myRigidbody.MovePosition(transform.position + (transform.forward * walkSpeed * Time.deltaTime), transform.position + (transform.right * walkSpeed * Time.deltaTime), 0);

        //Vector3 playerDirection = new Vector3(transform.forward * walkSpeed * Time.deltaTime, transform.right * walkSpeed * Time.deltaTime, 0);

        //myRigidbody.velocity = new Vector3(transform.forward * walkSpeed * Time.deltaTime, transform.right * walkSpeed * Time.deltaTime, 0);


       
        Direction = new Vector3((moveHorizontal) * walkSpeed * walkSpeed * Time.deltaTime, 0, moveVertical * walkSpeed * walkSpeed * Time.deltaTime);
        myRigidbody.velocity = (Direction).normalized;

        // myTransform.Translate(Direction, Space.Self);
        //myRigidbody.velocity = (Direction).normalized;

        //----------------------Rotating-----------------------
        if (moveHorizontal !=0 || moveVertical != 0)
        {
            
            transform.forward = Vector3.Lerp(transform.position, myRigidbody.velocity, rotateSpeed);
            //transform.forward = Vector3.Lerp(transform.position, Direction, rotateSpeed);
        }

        //-------------------------Jumping---------------------

        if (jumpInput)
        {
            myRigidbody.AddForce(Vector3.up * jumpHeight * Time.deltaTime);
            //WaitForSeconds(1)
        }

        

        if (transform.position.y > 8f)
        {
            //myRigidbody.mass = 5000;
           myRigidbody.AddForce(Vector3.down * fallSpeed * Time.deltaTime);
            //myRigidbody.AddForce(Vector3.Lerp(transform.position, Vector3.down, fallSpeed * Time.deltaTime));
            //myRigidbody.MovePosition(Direction);
        }
    }

   
}
