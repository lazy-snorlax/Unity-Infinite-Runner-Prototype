using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _floorPrefabs;
    [SerializeField]
    private float _zOffset;

    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i < _floorPrefabs.Length; i++)
        {
            Instantiate(_floorPrefabs[Random.Range(0,_floorPrefabs.Length)], new Vector3(0, 0, i * 50), Quaternion.Euler(0, 0, 0));
            _zOffset += 50;
        }
    }

    public void RecyclePlatform(GameObject platform)
    {
        // repositioning to next z offset
        platform.transform.position = new Vector3(0, 0, _zOffset);
        _zOffset += 50;
    }
}
