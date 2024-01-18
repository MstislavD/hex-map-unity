
using UnityEngine;

[System.Serializable]
public class HexFeatureCollection
{
    public Transform[] prefabs;

    public Transform Pick(float choice) => prefabs[(int)(choice * prefabs.Length)];
}
