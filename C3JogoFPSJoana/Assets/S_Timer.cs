using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class S_Timer : MonoBehaviour
{
    //[SerializeField] float timeLeft = 4;
    [SerializeField] GameObject timerGameObject;

    TextMeshProUGUI timerUGUI;

    [SerializeField] GameObject defeatCanvas;
    //[SerializeField] GameObject victoryCanvas;


    [SerializeField] float timeLeft = 120f;

    //[SerializeField] float timeMinutesLeft = 1f;
    [SerializeField] float timeSecondsleft = 7f;



    [SerializeField] float timeMinutesLeft = 1f;

    [SerializeField] GameObject playerGameObject;
    S_PlayerMove playerMoveScript;

    //[SerializeField] GameObject soundEffectHolder;

    //AudioSource soundEffect;
    
    void Start()
    {
        timerUGUI = timerGameObject.GetComponent<TextMeshProUGUI>();

        playerMoveScript = playerGameObject.GetComponent<S_PlayerMove>();

        //soundEffect = soundEffectHolder.GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        

        //timeSecondsleft = timeSecondsleft - Time.deltaTime;
        timeLeft = timeLeft - Time.deltaTime;

                //timeMinutesLeft = timeMinutesLeft - Time.deltaTime;

        //timeSecondsleft = (timeSecondsleft % 60);
        timeSecondsleft = (timeLeft % 60);

                timeMinutesLeft = (timeLeft / 60);

        //timeSecondsleft = (Mathf.FloorToInt(timeSecondsleft));
        //Debug.Log("Passo 3" + timeSecondsleft);

        //string timeToDisplay = string.Format({0:00},"", timeSecondsLeft);

        //timerUGUI.text = string.Format("{0:00}", timeSecondsLeft);


                   /* if (timeMinutesLeft <= 0)
                     {
                        timeMinutesLeft = 00;
                     }*/


        /*if(timeSecondsleft <= 0)
        {
            timeSecondsleft = 00;
            timerWentToZero();
        }*/

        if(timeLeft <= 0)
        {
            timeLeft = 00;
            timerWentToZero();
        }

        timerUGUI.text = (timeLeft + "");
        




        /*if (Input.GetButtonDown("Fire1"))
        {
            timerWentToZero();
        }*/
    }

    public void timerWentToZero()
    {
        //timerUGUI.text = ("Whoops try again!");
        defeatCanvas.SetActive(true);
        //soundEffect.Play();

        Destroy(playerMoveScript);
    }

    



}
