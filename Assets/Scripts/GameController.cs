using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private float spawnIntervalMin;
    [SerializeField] private float spawnIntervalMax;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoin());
        UpdatePoints();
        
    }
    
    void UpdatePoints()
    {
        _pointsText.text = "Points: " + points.ToString();
    }

    private System.Collections.IEnumerator SpawnCoin()
    {
        while (true)
            float spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            yield return new WaitForSeconds(spawnInterval);

            Vector3 spawnPosition = new Vector3(xPosition, 14, 0f);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
   