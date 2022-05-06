using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	[SerializeField] private float _sensivity, _speed;
	private int _xRange = 6;
	private Rigidbody _rigidbody;
	private Vector3 _direction = new Vector3(0, 0, 1); 

	private void PlayerStart()
	{
		GameManager.instance.Start ();
	}

	private void Update()
	{
		GameManager.instance.PlayerUpdate ();
	    Move (_direction);
	}

	public void Move(Vector3 direction)
	{
		transform.Translate (direction * _speed * Time.deltaTime);
	}

	private void Limit()
	{
		GameManager.instance.PlayerLimit ();
	}

	private void MoveHorizontal()
	{
		GameManager.instance.PlayerMoveHorizontal ();
	}
}
