using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSpawner : MonoBehaviour
{
    public GameObject productPrefab;
    public Transform[] spawnPoints;

    private GameObject[] products;

    private int spawnPointsLength;
    private int currentSpawnPoint = 0;

    private int row = 0;
    private int maxRow = 16;

    private void Start()
    {
        spawnPointsLength = spawnPoints.Length;
        for (int i = 0; i < 10; i++)
        {
            Instantiate(productPrefab);
        }
    }

    private void Update()
    {
        
    }

    private void InitializeProduct(Product p)
    {
        p.row = row++;

        if (row >= maxRow) row = 0;
    }

    public void InstantiateProduct()
    {
        Product product = Instantiate(productPrefab, spawnPoints[currentSpawnPoint++].position, Quaternion.identity).GetComponent<Product>();
        InitializeProduct(product);

        if (currentSpawnPoint >= spawnPoints.Length) currentSpawnPoint = 0;
    }
}
