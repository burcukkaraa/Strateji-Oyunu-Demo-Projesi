using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class bilgi_okcubina : MonoBehaviour,IPointerClickHandler
{
    public Image Image_bilgi_gorsel_santral, Image_bilgibaraka, Image_bilgiokcubina, Image_bilgimizrakcibina;
    public Button Button_baraka, Button_santral, Button_okcubina, Button_mizrakcibina;
    public Text Text_bilgi_santral, Text_bilgibaraka, Text_bilgiokcubina, Text_bilgimizrakcibina;

 





    public void OnPointerClick(PointerEventData eventData)
    {
        ((IPointerClickHandler)Button_okcubina).OnPointerClick(eventData);
        Debug.Log(" IPointerClickHandler calisti okçu binası tiklandi");

        

        Image_bilgiokcubina.enabled = true;
        Text_bilgiokcubina.enabled = true;

        Image_bilgibaraka.enabled = false;
        Text_bilgibaraka.enabled = false;

        Image_bilgi_gorsel_santral.enabled = false;
        Text_bilgi_santral.enabled = false;

        Image_bilgimizrakcibina.enabled = false;
        Text_bilgimizrakcibina.enabled = false;

        

    }

    void Start () {

        Image_bilgi_gorsel_santral = GameObject.Find("Image_bilgi_gorsel_santral").GetComponent<Image>();
        Image_bilgibaraka = GameObject.Find("Image_bilgibaraka").GetComponent<Image>();
        Image_bilgiokcubina = GameObject.Find("Image_bilgiokcubina").GetComponent<Image>();
        Image_bilgimizrakcibina = GameObject.Find("Image_bilgimizrakcibina").GetComponent<Image>();

        Button_okcubina = this.GetComponent<Button>();
        Button_santral = GameObject.Find("Button_santral").GetComponent<Button>();
        Button_baraka = GameObject.Find("Button_baraka").GetComponent<Button>();
        Button_mizrakcibina= GameObject.Find("Button_mizrakcibina").GetComponent<Button>();


        Text_bilgi_santral = GameObject.Find("Text_bilgi_santral").GetComponent<Text>();
        Text_bilgibaraka = GameObject.Find("Text_bilgibaraka").GetComponent<Text>();
        Text_bilgiokcubina = GameObject.Find("Text_bilgiokcubina").GetComponent<Text>();
        Text_bilgimizrakcibina = GameObject.Find("Text_bilgimizrakcibina").GetComponent<Text>();


     



        Image_bilgiokcubina.enabled = false;
        Text_bilgiokcubina.enabled = false ;
        





    }
	
	
	void Update () {
		
	}
}
