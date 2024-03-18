using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    // Start is called before the first frame update
    public Tile[] upNeighbour;
    public Tile[] downNeighbour;
    public Tile[] leftNeighbour;
    public Tile[] rightNeighbour;

    public Tile[] frontNeighbour;
    public Tile[] backNeighbour;

    

    public void PrintNeighbors()
    {
        Debug.Log("Up Neighbors:");
        foreach (Tile tile in upNeighbour)
        {
            Debug.Log(tile.name);
        }

        Debug.Log("Down Neighbors:");
        foreach (Tile tile in downNeighbour)
        {
            Debug.Log(tile.name);
        }

        Debug.Log("Left Neighbors:");
        foreach (Tile tile in leftNeighbour)
        {
            Debug.Log(tile.name);
        }

        Debug.Log("Right Neighbors:");
        foreach (Tile tile in rightNeighbour)
        {
            Debug.Log(tile.name);
        }

        Debug.Log("Front Neighbors:");
        foreach (Tile tile in frontNeighbour)
        {
            Debug.Log(tile.name);
        }

        Debug.Log("Back Neighbors:");
        foreach (Tile tile in backNeighbour)
        {
            Debug.Log(tile.name);
        }
    }



}
