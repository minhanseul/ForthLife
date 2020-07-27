using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSpawner : MonoBehaviour
{
    public GameObject productPrefab;
    public Transform[] spawnPoints;

    private int spawnPointsLength;
    private int currentSpawnPoint = 0;

    private int col = 0;
    private int row = 0;
    private int maxCol = 5;
    private int maxRow = 16;

    private void Start()
    {
        spawnPointsLength = spawnPoints.Length;
    }

    private void Update()
    {
        
    }

    private void InitializeProduct(Product p)
    {
        p.col = col++;
        p.row = row++;

        if (col >= maxCol) col = 0;
        if (row >= maxRow) row = 0;
    }

    public void InstantiateProduct()
    {
        Product product = Instantiate(productPrefab, spawnPoints[currentSpawnPoint++].position, Quaternion.identity).GetComponent<Product>();
        InitializeProduct(product);

        if (currentSpawnPoint >= spawnPoints.Length) currentSpawnPoint = 0;
    }
}
