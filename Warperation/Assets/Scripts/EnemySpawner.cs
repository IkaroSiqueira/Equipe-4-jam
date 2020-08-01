using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    ObjectPooler obj;
    void Start()
    {
        obj = ObjectPooler.Instance;
    }
    void FixedUpdate()
    {
        obj.SpawnFroomPool("Enemy1", transform.position, Quaternion.identity);
    }
}
