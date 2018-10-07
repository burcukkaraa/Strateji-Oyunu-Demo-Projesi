using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;

public class oyunalani_geributon : MonoBehaviour, IPointerClickHandler
{
   


   void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(1);
       

  
    }

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}
}
