using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class barakauretilenler_okcubina: MonoBehaviour, IPointerClickHandler
{
    public Button Button_insaet_okcubina;

    public instantiate yardimciokcu;

    public GameObject scrollrect;
    public Canvas canvas;


    barakainsaet barakainsaetscript;


    public void OnPointerClick(PointerEventData eventData)
    {
        
        
            ((IPointerClickHandler)Button_insaet_okcubina).OnPointerClick(eventData);

            yardimciokcu.İnstantiate(Button_insaet_okcubina);

        

       


    }

    void Start ()

    {
        // Button butoninsaetokcubina = Button_insaet_okcubina.GetComponent<Button>();

       
       
    }

    
    void Update ()

    {
		
	}

    
}
