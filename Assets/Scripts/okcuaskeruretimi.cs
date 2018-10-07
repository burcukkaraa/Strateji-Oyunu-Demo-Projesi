using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class okcuaskeruretimi : MonoBehaviour ,IPointerClickHandler {

    public Button okcuuret;
    public obje_havuzlama_coklusecme objehavuzlama;
    public GameObject okcuaskersv1;
 
    


    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)okcuuret).OnPointerClick(eventData);

        okcuaskersv1 = GameObject.Find("obje_havuzlama_okcusv1").GetComponent<obje_havuzlama_coklusecme>().Getpooledobject();
        okcuaskersv1.transform.position = transform.position;
        okcuaskersv1.SetActive(true);

       


    }

    void Start ()
    {
        okcuaskersv1.SetActive(false);
      
    }
	
	void Update ()
    {
		
	}
}
