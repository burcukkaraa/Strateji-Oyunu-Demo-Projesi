using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class barakadanuretilenpanel: MonoBehaviour
 {

    public GameObject Panel_barakauretilenler;
    public Button Button_barakauretilen_acilirok;
    public Button Button_barakauretilen_cikis;
   



    public void Panel_goster()
    {

        Panel_barakauretilenler.SetActive(true);
        
    }


    public void Panel_gizle()
    {

        Panel_barakauretilenler.SetActive(false);
       
    }

    
    void Start ()
    {
        
        Panel_barakauretilenler.SetActive(false);
        Panel_goster();


        Button_barakauretilen_acilirok.onClick.AddListener(Panel_goster);

        Button_barakauretilen_cikis.onClick.AddListener(Panel_gizle);

       


    }
	
	void Update () {
		
	}

   
}
