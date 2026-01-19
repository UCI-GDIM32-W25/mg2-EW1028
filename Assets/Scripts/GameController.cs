using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private Transform _SpawnPoint;
    [SerializeField] private float spawnIntervalMin = 1f;
    [SerializeField] private float spawnIntervalMax = 3f;
    [SerializeField] private float minX = 12f;
    [SerializeField] private float maxX = 16f;

    [SerializeField] private float spawnY = 14f;
    public int points = 0;
    
    //public int SpawnPointMax
    //public int SpawnPointMin

    void Start()
    {
        StartCoroutine(SpawnCoin());
        UpdatePoints();
        
    }

    public void AddPoint()
    {
        points++;
        UpdatePoints();
    }

    public void UpdatePoints()
    {
        _pointsText.text = "Points: " + points.ToString();
    }

    private IEnumerator SpawnCoin()
    {
        while (true)
        {

            float spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            yield return new WaitForSeconds(spawnInterval);
            

            Vector3 spawnPosition = new Vector3(_SpawnPoint.position.x, spawnY, 0f);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}


   