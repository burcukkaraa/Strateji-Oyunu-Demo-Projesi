using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class alan_uygun_dolu : MonoBehaviour {
    
    private string mesaj = "BU ALAN İNŞA ETMEK İÇİN UYGUN DEĞİL";
    
    private bool trigger = false;

    public GUIStyle guıstyle;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag==("temas"))
        {
           
        }
     
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
       
        trigger = true;
      
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(" TRİGGER SONA ERDİ");
        trigger = false;

    }

    public void OnGUI()
    {

        if (trigger==true)
        {
            GUI.Label(new Rect(400, 450, Screen.width, 150), mesaj + "", guıstyle);
           
        }
        
    }


    void Start ()
    {
        

       
       
    }

   

    void Update () {
		
	}
}
