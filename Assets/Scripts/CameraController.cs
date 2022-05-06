using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
	private Vector3 _offset = new Vector3 (0, 5, -12);
	[SerializeField] private Transform _player;

	private void LateUpdate()
	{
		transform.position = _player.transform.position + _offset;
	}
}
