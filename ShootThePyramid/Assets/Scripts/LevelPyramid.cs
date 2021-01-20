using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPyramid : MonoBehaviour
{
    CubeExitTrigger[] cubePrefabs;
    int cubePrefabInt;
    int triggeredCubesInt;

    void Start()
    {
        cubePrefabs = GetComponentsInChildren<CubeExitTrigger>();
        cubePrefabInt = cubePrefabs.Length;
    }

    private void Update()
    {
        CheckAllCubes();

        if (cubePrefabInt == triggeredCubesInt)
        {
            Debug.Log("CHANGE THE PLATFORM!");
        }
    }

    void CheckAllCubes() 
    {      
        foreach (var cube in cubePrefabs)
        {
            if (cube.IsCubeExitTrigger)
            {
                triggeredCubesInt++;
                Debug.Log("ONE CUBE IS OUT");
            }
        }
    }
}
