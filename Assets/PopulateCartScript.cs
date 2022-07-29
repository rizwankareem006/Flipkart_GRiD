using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateCartScript : MonoBehaviour
{
    public Cart cart;
    public GameObject textPrefab;
    public Transform m_ContentContainer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void populate()
    {
        for (int i = 0; i < cart.items.Length; i++)
        {
            var item_go = Instantiate(textPrefab);
            // do something with the instantiated item -- for instance
            item_go.GetComponentInChildren<Text>().text = "Item #" + cart.items[i].id;
            //item_go.GetComponent<Image>().color = i % 2 == 0 ? Color.yellow : Color.cyan;
            //parent the item to the content container
            item_go.transform.SetParent(m_ContentContainer);
            //reset the item's scale -- this can get munged with UI prefabs
            item_go.transform.localScale = Vector2.one;
        }
    }
}
