using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class start_menu : MonoBehaviour
{
    public Button start_buton;
    public Button cikis_buton;

    public Slider slider;
    public Text text_yukleniyor;
    public GameObject panel;

   

    public void load_level(int level_indeks)
    {
       

        StartCoroutine(load_progress(level_indeks));

      

    }

    IEnumerator  load_progress(int level_indeks)

    {
        

        AsyncOperation operation = SceneManager.LoadSceneAsync(level_indeks);
        panel.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/0.9f);
            slider.value = progress;
            text_yukleniyor.text = progress * 100 + "%";

            yield return null;
        }

       
    }


    public void butonlarigizle()
    {

        start_buton.gameObject.SetActive(false);
        cikis_buton.gameObject.SetActive(false);

    }

    public void cikistbuton()
    {
        Application.Quit();

    }


    void Start ()
    {
        

        cikis_buton.onClick.AddListener(cikistbuton);
        //start_buton.onClick.AddListener(startbuton);

        panel.SetActive(false);
    }
		
	void Update ()
    {
		
	}

   
}
