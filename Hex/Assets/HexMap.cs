using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

    public GameObject HexPrefab;



	// Use this for initialization
	void Start () {
        GenerateMap();
	}
	
	public void GenerateMap()
    {
        for (int colum = 0; colum < 10; colum++)
        {
            for (int row = 0; row < 10; row++)
            {
                Hex hex = new Hex(colum, row);

                Instantiate(HexPrefab, hex.Position(), Quaternion.identity, this.transform);
            }
        }
    }
}
