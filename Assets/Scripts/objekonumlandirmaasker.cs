using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.AI;
public class objekonumlandirmaasker : MonoBehaviour {

    private bool dragItem = false;
    public GameObject dragObject;
    private Vector2 touchOffset;

    void Start()
    {

    }


    void Update()
    {
        if (HasInput)
        {
            Drag();
        }
        else
        {
            if (dragItem)
            {
                Drop();
            }
        }




    }
    private bool HasInput
    {
        get
        {
            return Input.GetMouseButton(0);
        }
    }

    private void Drag()
    {

        var inputPosition = Position;
        if (dragItem)
        {
            dragObject.transform.position = inputPosition + touchOffset;
        }
        else
        {
            RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 1.3f);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if (hit.transform != null && hit.transform.gameObject.tag != ("sabit"))
                {
                    dragItem = true;
                    dragObject = hit.transform.gameObject;
                    touchOffset = (Vector2)hit.transform.position - inputPosition;
                    dragObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);


                }
            }

        }


    }


    Vector2 Position
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void Drop()
    {
        dragItem = false;
        dragObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
