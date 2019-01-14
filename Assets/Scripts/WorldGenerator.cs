using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
public class WorldGenerator
{
    public static WorldGenerator instance;
    private Tilemap map;
    private Grid grid;
    private GameObject map_gameObject;
    private GameObject grid_gameObject;
    private TileBase[] tile_atlas;
    private const int world_width = 100;
    private const int world_height = 100;

    private WorldGenerator()
    {
        grid_gameObject = new GameObject();
        grid_gameObject.transform.position = Vector3.zero;

        map_gameObject = new GameObject();
        map_gameObject.transform.position = Vector3.zero;

        map = map_gameObject.AddComponent<Tilemap>();
        map_gameObject.AddComponent<TilemapRenderer>();
        grid = grid_gameObject.AddComponent<Grid>();

        map.transform.SetParent(grid_gameObject.transform);

        tile_atlas = Resources.LoadAll<TileBase>("Tiles");
        Debug.Log(tile_atlas.Length);
    }
    public static WorldGenerator GetInstance()
    {
        if (instance == null)
            instance = new WorldGenerator();

        return instance;
    }

    public void GenerateWorld()
    {
        Vector3Int _current_position = new Vector3Int();
        TileBase _current_tile;
        for (int x = 0; x < world_width; x++)
        {
            for (int y = 0; y < world_height; y++)
            {
                _current_position.Set(x, y, 0);
                _current_tile = tile_atlas[Random.Range(0, tile_atlas.Length)];
                map.SetTile(_current_position, _current_tile);
            }
        }
    }



}
