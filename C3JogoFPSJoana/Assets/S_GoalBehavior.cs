using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GoalBehavior : MonoBehaviour
{
    [SerializeField] GameObject sceneManagerObject;

    [SerializeField] GameObject soundManager;

    S_ManageScene sceneManagerScript;

    [SerializeField] GameObject victoryCanvas;

    [SerializeField] AudioSource effectSound;



    private void Start()
    {
        sceneManagerScript = sceneManagerObject.GetComponent<S_ManageScene>();
     
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You reached the goal!");

            victoryCanvas.SetActive(true);
            //soundManager.play(effectSound);
 
        }
    }
}
