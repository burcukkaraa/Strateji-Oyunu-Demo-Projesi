using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class okcuaskeruretimisv2 : MonoBehaviour, IPointerClickHandler
{
    public Button okcuuret;
    public obje_havuzlamaokcuaskersv2 objehavuzlama;
    public GameObject okcuaskersv2;

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)okcuuret).OnPointerClick(eventData);

        okcuaskersv2 = GameObject.Find("obje_havuzlama_okcusv2").GetComponent<obje_havuzlamaokcuaskersv2>().Getpooledobject();
        okcuaskersv2.transform.position = transform.position;
        okcuaskersv2.SetActive(true);
    }

    void Start ()
    {
        okcuaskersv2.SetActive(false);
    }
	
	
	void Update ()
    {
		
	}
}
