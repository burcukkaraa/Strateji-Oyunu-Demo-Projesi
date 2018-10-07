using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class barakauretilenler_mizrakcibina : MonoBehaviour, IPointerClickHandler
{

    public Button Button_insaet_mizrakcibina;

    public instantiate yardimcimizrakci;

    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)Button_insaet_mizrakcibina).OnPointerClick(eventData);
        yardimcimizrakci.İnstantiate(Button_insaet_mizrakcibina);
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
