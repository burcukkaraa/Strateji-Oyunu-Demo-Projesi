using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.AI;


public class mouse_kontrol : MonoBehaviour {

    
    
    static public Vector2 target;

    public LayerMask BuildingsMask;

    //Vector2 direction = new Vector3(100, 100);



    void Start () {
		
	}
	
	
	void Update ()

    {
        Vector2 m = Input.mousePosition;
        m = new Vector3(m.x, m.y, transform.position.z);
        Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);

        RaycastHit2D carpma = new RaycastHit2D();

        Ray2D isin = new Ray2D(new Vector2(p.x, p.y),-Vector2.up);


        //isin = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("mousekontrol calisti");

        if (Physics2D.Raycast (new Vector2(p.x, p.y),Vector3.down,5.0f,BuildingsMask))
        {
            Debug.DrawRay(isin.origin,carpma.point,Color.green);

          //  if (carpma.collider.name== "Panel_harita")
           // {
            //    target = carpma.point;
               
         }
           
     }
}

