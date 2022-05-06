using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour 
{
	[SerializeField] private GameObject _losePanel;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Obstacle")) 
		{
			_losePanel.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
