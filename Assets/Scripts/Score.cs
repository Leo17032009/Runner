using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	[SerializeField] private Text _scoreText;
	private int _score;

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("SilverCoin"))
		{
			_score++;
			_scoreText.text = _score.ToString ();
			Destroy (other.gameObject);
		}
		if (other.gameObject.CompareTag ("GoldCoin")) 
		{
			_score += 2;
			_scoreText.text = _score.ToString ();
	    }
    }   
}
