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

    // Start is called before the first frame update
    void Start()
    {
        timerUGUI = timerGameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            timerWentToZero();
        }
    }

    void timerWentToZero()
    {
        timerUGUI.text = ("Whoops try again!");
        defeatCanvas.SetActive(true);
    }

    



}
