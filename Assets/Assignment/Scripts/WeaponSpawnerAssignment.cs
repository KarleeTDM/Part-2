using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WeaponSpawnerAssignment : MonoBehaviour // F in the chat for this not going into the project because no dynamic Rigidbody2Ds allowed. 😔
{
    public GameObject prefab;
    public Transform spawner;
    public void SpawnWeapon()
    {
        Instantiate(prefab, spawner.position, spawner.rotation);
    }
}
