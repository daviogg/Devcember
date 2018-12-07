using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour {

    public Item item;

    public Text nameText;

	void Start () {

        nameText.text = item.name;
        gameObject.GetComponent<Image>().sprite = item.artwork;
	}
	
}
