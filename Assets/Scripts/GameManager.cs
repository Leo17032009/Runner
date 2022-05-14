using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{

	[SerializeField] private float _sensivity, _speed;
	private int _xRange = 6;
	private Rigidbody _rigidbody;
	[SerializeField] private GameObject _shop, _shopButton1, _shopButton2, _shopButton3;
	private bool _check = true;
	[SerializeField] private Text _scoreText;
	private int _score;
	public static GameManager instance;

	public void Awake()
	{
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}

	public void Start()
	{
		_rigidbody = GetComponent<Rigidbody> ();
	}

	public void PlayerUpdate()
	{
		Move (Vector3.forward);
		PlayerLimit ();
		if (Input.touchCount > 0) 
		{
			PlayerMoveHorizontal ();
		}
	}

	public void Move(Vector3 direction)
	{
		transform.Translate (direction * _speed * Time.deltaTime);
	}

	public void PlayerLimit()
	{
		if (transform.position.x < -_xRange) 
		{
			transform.position = new Vector3 (-_xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > _xRange) 
		{
			transform.position = new Vector3 (_xRange, transform.position.y, transform.position.z);
		}
	}

	public void PlayerMoveHorizontal()
	{
		Touch touch = Input.GetTouch (0);
		if (touch.phase == TouchPhase.Moved) 
		{
			float move = touch.deltaPosition.x * Time.deltaTime * _sensivity;
			_rigidbody.AddForce (Vector3.right * move);
		}
	}

	/*public void OnTriggerEnter(Collider other)
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
	}*/

	public void OnShopButton()
	{
		if (_check == true) {
			_shop.SetActive (true);
			_check = false;
		} else {
			_shop.SetActive (false);
			_check = true;
		}
	}

	public void OnBuyButton1Down()
	{
		if (_score >= 100)
			_score -= 100;
		_speed = 5;
		Destroy (_shopButton1);
	}

	public void OnBuyButton2Down()
	{
		if (_score >= 450) 
		{
			_score -= 450;
			_speed = 3;
			Destroy (_shopButton2);
		}
	}

	public void OnBuyButton3Down()
	{
		if (_score >= 900) 
		{
			_score -= 900;
			_speed = 1;
			Destroy (_shopButton3);
		}
	}
}
