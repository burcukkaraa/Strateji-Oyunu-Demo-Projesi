using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class mizrakciaskeruretimi : MonoBehaviour, IPointerClickHandler
{

    public Button mizrakciuret;
    public obje_havuzlamamizrakci objehavuzlama;
    public GameObject mizrakciasker;

    public void OnPointerClick(PointerEventData eventData)
    {
        mizrakciasker = GameObject.Find("obje_havuzlama_mizrakci").GetComponent<obje_havuzlamamizrakci>().Getpooledobject();
        mizrakciasker.transform.position = transform.position;
        mizrakciasker.SetActive(true);

    }

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		
	}
}
