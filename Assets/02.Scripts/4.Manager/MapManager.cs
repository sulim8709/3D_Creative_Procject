using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager>
{
    [Header("mapSizeX")]
    public int mapSizeX = 16;
    [Header("mapSizeY")]
    public int mapSizeY = 16;

    [Header("PathNode")]
    public PathNode pathNode;
    [Header("TileNode")]
    public TileNode tileNode;

    private float spaceBetweenTile = 1f;

    private void Awake()
    {
        GenerateMap();
    }

    public void GenerateMap()
    {
        for (int i = 0; i < mapSizeX; ++i)
        {
            for (int j = 0; j < mapSizeY; ++j)
            {
                if (i < 2 || j < 2 || i > mapSizeX - 3 || j > mapSizeY - 3)
                {
                    Instantiate(pathNode, new Vector3(i * spaceBetweenTile, 0, j * spaceBetweenTile), Quaternion.identity);
                }
                else
                {
                    Instantiate(tileNode, new Vector3(i * spaceBetweenTile, 1, j * spaceBetweenTile), Quaternion.identity);
                }
            }
        }
    }
}
