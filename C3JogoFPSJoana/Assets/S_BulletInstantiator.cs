using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BulletInstantiator : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    Transform myTransform;

    

    //Vector3 myPosition;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        

       
    }

    
    void Update()
    {

        //myPosition = (transform.position.x, transform.position.y, transform.position.z);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }




    }

    void Shoot()
    {
        Instantiate(bulletPrefab);
    }
}
