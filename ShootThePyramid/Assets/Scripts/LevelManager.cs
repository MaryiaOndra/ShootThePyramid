using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject[] levelPoints;
    [SerializeField] private GameObject[] levelsPrefabs;
    [SerializeField] private GameObject platform;

    private void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel() 
    {
        //create random level selection

        GameObject.Instantiate(levelsPrefabs[0], levelPoints[0].transform);
        GameObject.Instantiate(platform, levelPoints[0].transform);
    }

    void CheckIsLevelEmpty() 
    {
    
    }
}
