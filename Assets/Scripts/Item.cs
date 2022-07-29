using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    public int id;
    public string item_name;
    public float cost;
    public int quantity;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        canvas.GetComponent<CanvasScript>().itemId = id;
        canvas.gameObject.SetActive(true);
    }
}
