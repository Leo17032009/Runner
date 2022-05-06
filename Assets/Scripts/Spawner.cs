using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
	[SerializeField] private GameObject[] _tilePrefabs;
	[SerializeField] List<GameObject> _activeTiles = new List<GameObject> ();
	[SerializeField] private Transform _player;
	private float _spawnPosition = 0;
	private float _tileLength = 30;
	private int _valueSpawnTiles = 5;
	private int _tileNumber = 2;

	private void Start()
	{
		for (int i = 0; i < _valueSpawnTiles; i++) 
		{
			SpawnTile (Random.Range (0, _tilePrefabs.Length));
		}
	}

	private void Update()
	{
		if((_player.position.z - _tileLength > _activeTiles[0].transform.position.z) && (_activeTiles.Count > 1))
		{
			DeleteTile();
			_tileNumber = Random.Range(0, _tilePrefabs.Length);
			SpawnTile(_tileNumber);
		}
	}

	private void SpawnTile(int tileIndex)
	{
		GameObject nextTile = Instantiate (_tilePrefabs [tileIndex], transform.forward * _spawnPosition, transform.rotation);
		_activeTiles.Add (nextTile);
		_spawnPosition += _tileLength;
	}

	private void DeleteTile()
	{
		DestroyImmediate(_activeTiles [0], true);
		_activeTiles.RemoveAt (0);
	}
}
