using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Tile tilePrefab;
    public Material tile1Material;
    public Material tile2Material;
    public int width;
    public int depth;

    public void Generate(){
        foreach(Transform child in transform){
            DestroyImmediate(child.gameObject);
        }
        for(var x = 0; x < width; x++){
            for(var z = 0; z < depth; z++){
                var newTile = Instantiate(tilePrefab, transform);
                newTile.transform.position = new Vector3(x, 0, z);
            }
        }
    }

}
