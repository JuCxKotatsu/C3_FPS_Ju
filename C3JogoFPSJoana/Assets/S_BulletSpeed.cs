using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BulletSpeed : MonoBehaviour
{
    [SerializeField] float bulletVelocity = 50000f;

    Rigidbody myRigidbody;

    //Vector3 Direction;

    //[SerializeField] GameObject directionRay;

   

    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        //ray = (gameObject.transform.position, directionRay.transform.position);

        //Direction = transform.forward;

        myRigidbody.AddForce(Vector3.forward * bulletVelocity * Time.deltaTime);
        Debug.Log("BulletGo");

        //myRigidbody.MovePosition(Direction * bulletVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }
}
