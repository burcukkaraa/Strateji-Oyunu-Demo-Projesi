using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class lutfenbarakinsaet : MonoBehaviour {

    public GameObject Panel_lutfenbarakainsaet;
    public GameObject image_arkaplanerisimkapatmabarakainsaet;

    public Button Button_lutfenbarakinsaet;

    public barakainsaet barakainsaetscript;



    public void Panel_lutfenbarakainsaetgizle()
    {
        Panel_lutfenbarakainsaet.SetActive(false);
        image_arkaplanerisimkapatmabarakainsaet.SetActive(true);
    }

    public void barakaolusturuldu()
    {
        Debug.Log("baraka olusturuldu ");
        image_arkaplanerisimkapatmabarakainsaet.SetActive(false);
        Panel_lutfenbarakainsaet.SetActive(false);
       
       
    }

    void Start ()
    {
       
       
            Panel_lutfenbarakainsaet.SetActive(true);

            image_arkaplanerisimkapatmabarakainsaet.SetActive(true);
        

      
       
        barakainsaetscript.Button_insaet_baraka.onClick.AddListener(barakaolusturuldu);
       
    }
	
	
	void Update ()
    {
		
	}
}
