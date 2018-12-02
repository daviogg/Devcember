using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour {

    public Item item;

    public Text nameText;
    public Image artwork;



	void Start () {
        nameText.text = item.name;
        artwork.sprite = item.artwork;
	}
	
}
