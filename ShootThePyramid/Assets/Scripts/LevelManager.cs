using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject[] levelPoints;
    [SerializeField] private GameObject[] levelsPrefabs;
    [SerializeField] private GameObject platform;

    int randomLvlInt;
    int cubeCountInt;
    CubeExitTrigger[] cubePrefabs;
    int cubePrefabInt;

    void Start()
    {
        GenerateNewLevel();
    }

    void Update()
    {
       // CheckIsLevelEmpty();       

        //if (cubePrefabInt == cubeCountInt)
        //{
        //    DestroyLevel();
        //    GenerateNewLevel();
        //}
    }

    void GenerateNewLevel() 
    {
        int randomPoint = Random.Range(0, levelPoints.Length);
        Transform pointTransform = levelPoints[randomPoint].transform;

        randomLvlInt = Random.Range(0, levelsPrefabs.Length);
        GameObject.Instantiate(levelsPrefabs[randomLvlInt], pointTransform );
        GameObject.Instantiate(platform, pointTransform);

        //cubePrefabs = levelsPrefabs[randomLvlInt].GetComponentsInChildren<CubeExitTrigger>();
        //cubePrefabInt = cubePrefabs.Length;
    }

    void DestroyLevel() 
    {
        GameObject.Destroy(levelsPrefabs[randomLvlInt]);
        GameObject.Destroy(platform);
    }

    //void CheckIsLevelEmpty() 
    //{
    //    foreach (var cube in cubePrefabs)
    //    {
    //        if (cube.IsCubeExitTrigger)
    //        {
    //            cubeCountInt++;
    //            Debug.Log("ONE CUBE IS OUT");
    //        }
    //    }
    //}

    void TurnOffLevel() 
    {
    
    }
}
