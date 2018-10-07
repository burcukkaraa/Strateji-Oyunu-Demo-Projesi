using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class santralinsaet : MonoBehaviour, IPointerClickHandler
{
    
    public Button Button_insaet_santral;

    public instantiate yardimci;
    

    public void OnPointerClick(PointerEventData tiklandimi)
    {
        ((IPointerClickHandler)Button_insaet_santral).OnPointerClick(tiklandimi);
      
        yardimci.İnstantiate(yardimci.Button_insaet_santral);
        
    }


    void Start ()
    {
       // Button butoninsaetsantral= Button_insaet_santral.GetComponent<Button>();

    }
	
	 
	void Update ()
    {
		
	}
}
