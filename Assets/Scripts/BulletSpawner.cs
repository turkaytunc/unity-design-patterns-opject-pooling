using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject _objectToSpawn;//used to spawn the Bullets if _poolType is set to None
    public Transform _bulletSpawnPos;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            SpawnBullet();
    }

    private void SpawnBullet()
    {

        GameObject newBullet = Instantiate(_objectToSpawn, _bulletSpawnPos.position, _bulletSpawnPos.rotation);
    }

}
