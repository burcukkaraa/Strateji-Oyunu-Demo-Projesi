using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;





public class instantiate : MonoBehaviour {
    
    public Button Button_insaet_okcubina;
    public GameObject Button_okcubina;

    public GameObject buton_baraka;
    public Button Button_insaet_baraka;

    public Button Button_insaet_santral;
    public GameObject Button_santral;

    public Button Button_insaet_mizrakcibina;
    public GameObject Button_mizrakcibina;

    public GameObject Panel_harita;

 

  

    public void İnstantiate (Button mybutton)

    {
    
        int x = Random.Range(370,420);
        int y = Random.Range(-150, 150);
        
        
        Vector3 nokta = new Vector3(x, y, 0); //klonlama noktası olusturuldu

        try
        {

            if (mybutton.name == "Button_insaet_baraka")
            {

                
                    Debug.Log(" baraka inşa ediliyor.");

                    GameObject btn_baraka_yeni = Instantiate(buton_baraka, nokta, Quaternion.identity) as GameObject;

                    btn_baraka_yeni.tag = "temas";

                    btn_baraka_yeni.transform.SetParent(GameObject.Find("Button_baraka").transform, false); 

                    Debug.Log(" baraka klonlandı");
 
            }

          

             if (mybutton.name == "Button_insaet_santral")

            {
                Debug.Log(" santral inşa ediliyor.");

                GameObject btn_santral_yeni = Instantiate(Button_santral, nokta, Quaternion.identity) as GameObject;

                btn_santral_yeni.tag = "temas";

                btn_santral_yeni.transform.SetParent(GameObject.Find("Button_santral").transform, false);  

                Debug.Log(" santral klonlandı");
            }

             if (mybutton.name=="Button_insaet_okcubina")
            {
                

                Debug.Log(" okçu bina inşa ediliyor.");

                GameObject btn_okcubina_yeni=Instantiate(Button_okcubina, nokta, Quaternion.identity) as GameObject;

                btn_okcubina_yeni.tag = "temas";

                btn_okcubina_yeni.transform.SetParent(GameObject.Find("Button_baraka").transform, false);
                
                Debug.Log(" okçu bina klonlandı");

               
                


            }
             if (mybutton.name == "Button_insaet_mizrakcibina")
            {
                Debug.Log(" mızrakçı bina inşa ediliyor.");

                GameObject btn_mizrakcibina_yeni = Instantiate(Button_mizrakcibina, nokta, Quaternion.identity) as GameObject;

                btn_mizrakcibina_yeni.tag = "temas";

                btn_mizrakcibina_yeni.transform.SetParent(GameObject.Find("Panel_harita").transform, false);

                Debug.Log(" mızrakçı bina klonlandı");

                  

            }

         

        }

        catch (System.Exception)

        {

            Debug.Log(" birim inşa edilemedi. ");
            throw;
        }

    }







void Start ()

    {
        
    }
	
	
	void Update () {
       

    }
}

