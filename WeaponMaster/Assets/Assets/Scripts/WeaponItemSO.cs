using System;
using UnityEngine;

namespace WeaponMaster
{
    [Serializable]
    [CreateAssetMenu(fileName = "WeaponItem", menuName = "ScriptableObjects/WeaponItem")]
    public class WeaponItemSO : ScriptableObject
    {
        public SizeInt size = new();
        public string nameId;
        public int damage;
        public float reload;
    }
}