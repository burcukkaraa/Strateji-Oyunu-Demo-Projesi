using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Panel_okcukislasi_uretim : MonoBehaviour{

    public GameObject Panel_okcukislasi;
    public Button Buttoncikis_okcukislasi;
    

   

    

    public void okcukislasigizle()
    {
        Panel_okcukislasi.SetActive(false);
        
      
    }

    public void okcukislasigoster()
    {
        Panel_okcukislasi.SetActive(true);
       


        Panel_okcukislasi.transform.SetParent(GameObject.Find("Panel_harita").transform, false);


        

    }

   

    void Start ()
    {

        if (Application.isPlaying)
        {
            Panel_okcukislasi.SetActive(true);
        }

       // Buttoncikis_okcukislasi.onClick.AddListener(okcukislasigizle);
      
       
    }
    
       
    
	
	
	void Update ()
    {
		
	}
}
