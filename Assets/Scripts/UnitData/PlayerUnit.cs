using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unitData;

[CreateAssetMenu(menuName = "NewUnit/PlayerUnit")]
public class PlayerUnit : UnitData
{
    [Header("Player Stats")]
    [SerializeField] private Color32 playerColour;
}
