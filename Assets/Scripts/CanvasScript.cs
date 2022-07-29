using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public int itemId;
    public Text quantityText;
    public Slider slider;

    public Cart cart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQuantityText()
    {
        quantityText.text = slider.value.ToString();
        cart.SetQuantity(itemId, (int)slider.value);
    }
}
