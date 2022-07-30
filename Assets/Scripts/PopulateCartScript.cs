using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateCartScript : MonoBehaviour
{
    public Cart cart;
    public GameObject textPrefab;
    public Transform m_ContentContainer;

    public Canvas canvasCart;
    public bool cartCanvasActive = false;

    public Text totalCostText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleCartCanvas()
    {
        cartCanvasActive = !cartCanvasActive;
        
            for (int i = 0; i < m_ContentContainer.childCount; ++i)
            {
                Destroy(m_ContentContainer.GetChild(i).gameObject);
            }
        
        canvasCart.gameObject.SetActive(cartCanvasActive);
    }

    public void populate()
    {

        for (int i = 0; i < cart.items.Length; i++)
        {
            GameObject item_go = Instantiate(textPrefab);
            // do something with the instantiated item -- for instance
            item_go.GetComponentInChildren<Text>().text = cart.items[i].item_name + "\t (" 
                + cart.items[i].cost + " x " + cart.items[i].quantity + " = "
                + (cart.items[i].cost * cart.items[i].quantity) + " )";
            //item_go.GetComponent<Image>().color = i % 2 == 0 ? Color.yellow : Color.cyan;
            //parent the item to the content container
            item_go.transform.SetParent(m_ContentContainer);

            item_go.transform.localPosition = Vector3.zero;
            item_go.transform.localScale = Vector3.one;
            item_go.transform.localRotation = Quaternion.identity;
            //reset the item's scale -- this can get munged with UI prefabs
            //item_go.transform.localScale = Vector2.one;
        }

        float total = 0;
        for (int i = 0; i < cart.items.Length; ++i)
        {
            total += (cart.items[i].quantity * cart.items[i].cost);
        }

        totalCostText.text = total.ToString();
    }
}
