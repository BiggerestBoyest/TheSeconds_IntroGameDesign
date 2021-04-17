using System.Collections;
using System.Collections.Generic;
using unitData;
using UnityEngine;

[CreateAssetMenu(menuName = "NewUnit/EnemyUnit")]
public class EnemyUnit : UnitData
{
    [Header("Enemy Stats")]
    [SerializeField] private Transform target;
}
