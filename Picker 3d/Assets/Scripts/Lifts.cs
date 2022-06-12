using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class Lifts : MonoBehaviour
{
    public int liftPoint;
    public MoveController moveController;
    public GameObject platform;
    public TextMeshProUGUI textCount;
    private int count=0;
    
    [SerializeField] private int targetCount;

    public void Awake()
    {
        liftPoint = -2;
        moveController = GameObject.FindObjectOfType<MoveController>();
        
        SetTextCount();


    }

    private void Update()
    {
        
    }

    public void continueGame()
    {
        moveController.ContinueMove(); 
        
        
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("lift"))
        {
            liftPoint++;
            count = liftPoint;
            SetTextCount();
            if (liftPoint>=targetCount)
            {
                
                platform.transform.DOLocalMoveY(0.761322f, 0.2f).SetEase(Ease.InQuad).OnComplete(()=>continueGame());
            }


        }
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            Destroy(coll.gameObject);
        }
    }

    private void SetTextCount()
    {
        textCount.text = "Balls" + count.ToString() + " / " + targetCount.ToString();
    }
}
