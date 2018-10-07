using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class barakainsaet : MonoBehaviour,IPointerClickHandler
{
    
    public Button Button_insaet_baraka;

   

    public instantiate yardimci ;

    public obje_havuzlama_coklusecme obje_Havuzlama_Coklusecme;

    public void OnPointerClick(PointerEventData tiklandimi)
    {
        ((IPointerClickHandler)Button_insaet_baraka).OnPointerClick(tiklandimi);
        
            yardimci.İnstantiate(Button_insaet_baraka);
           

    }

    

    void Start ()
    {
       
       
      
    }


    void Update ()
    {
       
    }


}
