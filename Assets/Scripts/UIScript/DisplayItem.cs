﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class DisplayItem : MonoBehaviour
{
	[SerializeField] protected Text itemText;
	[SerializeField] protected Image itemImage;
	[SerializeField] protected bool isSelected;

	[SerializeField] protected Image nameBackGound;
	[SerializeField] protected Image imageBackGound;

	[SerializeField] protected Item thisItem;

	public void LinkComponentElement()
	{
		itemText = GetComponent<Text>();
		itemImage = GetComponent<Image>();
		isSelected = false;

		nameBackGound = GetComponent<Image> ();
		imageBackGound = GetComponent<Image> ();
	}

	public void UpdateComponentElement( Item Itemdata )
	{
		thisItem = Itemdata;
		itemText.text = Itemdata.Name;
		itemImage.sprite = Resources.Load<Sprite>( "ItemIcon/" + Itemdata.Name );	
	}

	public void UpdateComponentElement(Player Playerdata)
	{
		//resources background folder 
		//nameBackGound.sprite = Resources.Load<Sprite>("asdf/" + Plyaerdata.store);
		//imageBackGound.sprite = Resources.Load<Sprite>("asdf/"+Playerdata.store);
	}

	public Text Itemtext
	{
		get { return itemText;}
	}

	public bool IsSelected
	{
		get { return isSelected;}
		set { isSelected = value;}
	}

	public Item ThisItem
	{
		get{ return thisItem;}
	}

	//click Button, this method play a part produceMain method coll;
	public void ClickDisPlayItemSelect()
	{
		ProduceMain produceMain = gameObject.GetComponentInParent<ProduceMain>();
		produceMain.ProduceItemListClick (thisItem);
	}



}
