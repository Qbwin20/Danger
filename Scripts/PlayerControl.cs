using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool KeyDown => _keyDown; 
    [SerializeField] private bool _clickEneble=true;
    [SerializeField] private bool _keyDown=false;

    private void Update() 
    {
        _keyDown=false;
        Controler(_clickEneble);
    }

    private void Controler(bool ClickEneble)
    {
        if(ClickEneble)
        {
            if (Input.GetKeyDown("space"))
            {
                _keyDown=true;
            }
            
        /*    if (Input.touchCount>0)
         *    {
         *        Touch touch = Input.GetTouch(0);
         *        if(touch.phase==TouchPhase.Began)
         *        {
         *           _keyDown=true;
         *        }
         *    }
         */   
         }
    }
    private void OnTriggerEnter2D(Collider2D Border) 
    {
        _clickEneble=false;
    }
    private void OnTriggerExit2D(Collider2D Border) {
        _clickEneble=true;
    }
}
