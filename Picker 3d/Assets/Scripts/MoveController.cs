using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lean.Touch;

public class MoveController : MonoBehaviour
{

    Rigidbody rigidbody;
   
   
    public bool isMove = true;
    

    private float _currentRunningSpeed;

    public LeanManualTranslateRigidbody LeanManualTranslateRigidbody;
    

    

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        
        
    }


   

    private void FixedUpdate()
    {
        if (isMove)
        {
            
            LeanManualTranslateRigidbody.TranslateWorld(new Vector3(0,0,0.2f));
            
        }
            
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("waitArea"))
        {
            Debug.Log("test2");
            isMove = false;
            rigidbody.isKinematic = true;
            other.enabled = false;
            
            transform.DOMoveZ(transform.position.z+1, 0.5f).SetEase(Ease.InOutQuad).SetLoops(2,LoopType.Yoyo);
        }
       
       
    }

    public void ContinueMove()
    {
        isMove = true;
        rigidbody.isKinematic = false;
    }
}
