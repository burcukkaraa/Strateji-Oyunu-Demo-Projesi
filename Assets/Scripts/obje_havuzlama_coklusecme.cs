using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class obje_havuzlama_coklusecme : MonoBehaviour {

    static List<GameObject> pooledobjects;
    static  List<GameObject> secilenobjeler;

    public int pooledamount = 10;

    public GameObject okcuaskersv1;

  

    public GameObject Panel_harita;
    


    Vector3 nokta = new Vector3(-257, -800, 0);

    private Vector2 baslangicpozisyon = Vector2.zero;
    private Vector2 bitispozisyon = Vector2.zero;
    
    public Texture mousetexture;


  


    void Start ()
    {
        secilenobjeler = new List<GameObject>();
       
     
        pooledobjects = new List<GameObject>();

        for (int i = 0; i < pooledamount; i++)
        {
            GameObject obj = (GameObject)Instantiate(okcuaskersv1,nokta, Quaternion.identity);
            obj.transform.SetParent(GameObject.Find("Panel_harita").transform, false);
            obj.SetActive(false);
            pooledobjects.Add(obj);

      




            BoxCollider2D col = obj. AddComponent<BoxCollider2D>();
            col.size= new Vector3(81, 70, 0);
            col.offset= new Vector3(0, -8, 0);



 

           

           


        }

       

    }
    

    public GameObject Getpooledobject()

    {
        for (int i = 0; i < pooledamount; i++)
        {
            if (!pooledobjects[i].activeInHierarchy)
            {
               
                
                return pooledobjects[i];
            }
               
            

        }

            return null;
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            

            if (Input.GetKeyDown(KeyCode.Mouse0))
                baslangicpozisyon = Input.mousePosition;
            else
                bitispozisyon = Input.mousePosition;

        }
        else
        {
            if (bitispozisyon != Vector2.zero && baslangicpozisyon != Vector2.zero)

                Debug.Log("obje secilebilir");
            bitispozisyon = baslangicpozisyon - Vector2.zero;
          

        }

       // if (Input.GetMouseButtonDown(1))
       // {
        //    foreach (var go in secilenobjeler)
         //   {
            //    go.GetComponentInParent<NavMeshAgent>().destination= mouse_kontrol.target;
        //

          //  }
        //}
    }


    private void OnGUI()
    {
        if (bitispozisyon != Vector2.zero && baslangicpozisyon != Vector2.zero)
        {
           // secilenobjeler.Clear();

            var rect = new Rect(baslangicpozisyon.x, Screen.height - baslangicpozisyon.y, bitispozisyon.x - baslangicpozisyon.x, -1 * (bitispozisyon.y - baslangicpozisyon.y));
            foreach (var karakter in pooledobjects)
            {
                Vector2 karakterscreenpos = Camera.main.ScreenToWorldPoint(karakter.transform.position);
                if (baslangicpozisyon.x < karakterscreenpos.x && bitispozisyon.x > karakterscreenpos.x && baslangicpozisyon.y < karakterscreenpos.y && bitispozisyon.y > karakterscreenpos.y)
                {
                    
                    Debug.Log("karakter" + karakter.name);

                    if (!secilenobjeler.Contains(karakter))
                    {
                        secilenobjeler.Add(karakter);
                    }
                   


                }

                if (baslangicpozisyon.x < karakterscreenpos.x && bitispozisyon.x < karakterscreenpos.x && baslangicpozisyon.y < karakterscreenpos.y && bitispozisyon.y > karakterscreenpos.y)
                {
                   
                    Debug.Log("karakter" + karakter.name);

                    if (!secilenobjeler.Contains(karakter))
                    {
                        secilenobjeler.Add(karakter);
                    }


                }

                if (baslangicpozisyon.x > karakterscreenpos.x && bitispozisyon.x < karakterscreenpos.x && baslangicpozisyon.y > karakterscreenpos.y && bitispozisyon.y < karakterscreenpos.y)
                {
                   
                    Debug.Log("karakter" + karakter.name);

                    if (!secilenobjeler.Contains(karakter))
                    {
                        secilenobjeler.Add(karakter);
                    }


                }

                if (baslangicpozisyon.x < karakterscreenpos.x && bitispozisyon.x > karakterscreenpos.x && baslangicpozisyon.y > karakterscreenpos.y && bitispozisyon.y < karakterscreenpos.y)
                {
                    

                    Debug.Log("karakter" + karakter.name);

                    if (!secilenobjeler.Contains(karakter))
                    {
                        secilenobjeler.Add(karakter);
                    }


                }

            }
            GUI.DrawTexture(rect, mousetexture);
        }
    }
}
