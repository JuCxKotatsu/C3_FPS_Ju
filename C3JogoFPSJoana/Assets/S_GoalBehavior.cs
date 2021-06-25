using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GoalBehavior : MonoBehaviour
{
    [SerializeField] GameObject sceneManagerObject;

    //[SerializeField] GameObject soundManager;

    S_ManageScene sceneManagerScript;

    [SerializeField] GameObject victoryCanvas;

    [SerializeField] AudioSource effectSound;

    [SerializeField] GameObject timeManagerObject;

    S_Timer timerScript;



    private void Start()
    {
        sceneManagerScript = sceneManagerObject.GetComponent<S_ManageScene>();

        timerScript = timeManagerObject.GetComponent<S_Timer>();
     
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You reached the goal!");

            victoryCanvas.SetActive(true);
            //soundManager.play(effectSound);
            //effectSound = soundManager.GetComponent<AudioSource>();
            //effectSound = GetComponent<AudioSource>();
            effectSound.Play();
            Destroy(timerScript);
 
        }
    }
}
