using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawner;
    public void SpawnWeapon()
    {
        Instantiate(prefab, spawner.position, spawner.rotation);
    }
}
