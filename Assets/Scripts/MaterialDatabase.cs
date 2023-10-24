using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Database")]
public class MaterialDatabase : ScriptableObject {
    [SerializeField] private List<ItemData> _data = new();
}

