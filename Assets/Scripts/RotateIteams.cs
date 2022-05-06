using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIteams : MonoBehaviour 
{
	private int _degreesRotation = 10;

	private void Update()
	{
		transform.Rotate (0, _degreesRotation * Time.timeScale, 0);
	}
}
