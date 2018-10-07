using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.AI;
public class obje_havuzlamaokcuaskersv2 : MonoBehaviour {


    static List<GameObject> pooledobjects;
    static List<GameObject> secilenobjeler;

    public int pooledamount = 10;

    public GameObject okcuaskersv2;

    public GameObject Panel_harita;

    
    Vector3 nokta = new Vector3(-257, -800, 0);

    private Vector2 baslangicpozisyon = Vector2.zero;
    private Vector2 bitispozisyon = Vector2.zero;

    public Texture mousetexture;

    void Start()
    {
        secilenobjeler = new List<GameObject>();


        pooledobjects = new List<GameObject>();

        for (int i = 0; i < pooledamount; i++)
        {


            GameObject obj2 = (GameObject)Instantiate(okcuaskersv2, nokta, Quaternion.identity);
            obj2.transform.SetParent(GameObject.Find("Panel_harita").transform, false);
            obj2.SetActive(false);
            pooledobjects.Add(obj2);

            BoxCollider2D col2 = obj2.AddComponent<BoxCollider2D>();
            col2.size = new Vector3(70, 83, 0);
            col2.offset = new Vector3(-2, -7, 0);



        }
    }

    public GameObject Getpooledobject()

    {
        for (int i = 0; i < pooledamount; i++)
        {
            if (!pooledobjects[i].activeInHierarchy)
                return pooledobjects[i];


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
        //  {
        //   foreach (var go in secilenobjeler)
        //  {
        //    go.GetComponentInParent<NavMeshAgent>().destination = mouse_kontrol.target;


        // }
        // }
    }

    private void OnGUI()
    {
        if (bitispozisyon != Vector2.zero && baslangicpozisyon != Vector2.zero)
        {
            //secilenobjeler.Clear();

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
                    /* GameObject[] sprite = karakter.GetComponentsInChildren<GameObject>();


                    /foreach (var sprite_ in sprite)
                     {
                         if (sprite_.name == "Sprite_secildi")
                         {
                             Debug.Log("Seçildi");
                            sprite_.GetComponent<SpriteRenderer>().enabled = true;
                         }
                     }*/

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




