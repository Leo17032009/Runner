using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour 
{
	private GameObject _scorePanel;
	[SerializeField] private GameObject _shop, _shopButton1, _shopButton2, _shopButton3;
	private bool _check = true;

	public void OnShopButtonShop()
	{
		GameManager.instance.OnShopButton();
	}

	public void BuyButtonShop1Shop()
	{
		GameManager.instance.OnBuyButton1Down ();
	}

	public void ByButtonShop2Shop()
	{
		GameManager.instance.OnBuyButton2Down ();
	}

	public void ByButtonShop3Shop()
	{
		GameManager.instance.OnBuyButton3Down ();
	}
}
