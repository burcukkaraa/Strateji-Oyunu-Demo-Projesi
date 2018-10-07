using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;


public class mizrakciuretac : MonoBehaviour, IPointerClickHandler
{


    public Button mizrakcibinaprefab;

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)mizrakcibinaprefab).OnPointerClick(eventData);

        SceneManager.LoadScene(3);
    }

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}
}
