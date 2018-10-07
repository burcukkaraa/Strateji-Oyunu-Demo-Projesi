using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;

public class okcuuretimac : MonoBehaviour, IPointerClickHandler
{
 
    public Button okcubinaprefab;

    public int okcuuretsahne_id = 2;
 

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)okcubinaprefab).OnPointerClick(eventData);
        SceneManager.LoadScene(okcuuretsahne_id);



     
        


    }

    void Start()
    {

    }


    void Update()
    {

    }
}
