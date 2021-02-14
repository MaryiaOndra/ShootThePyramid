using UnityEngine;

namespace ShootThePyramid.Scripts
{
    public class LevelPyramid : MonoBehaviour
    {
        CubeExitTrigger[] cubePrefabs;
        LevelManager levelManager;
        int cubePrefabInt;

        public int CountCubesInt { get; set; }

        void Awake()
        {
            levelManager = GetComponentInParent<LevelManager>();
            cubePrefabs = GetComponentsInChildren<CubeExitTrigger>();
            cubePrefabInt = cubePrefabs.Length;
        }

        public void CheckDroppedCubes()
        {
            if (cubePrefabInt == CountCubesInt)
            {
                levelManager.IsAllCubesDropped = true;
            }
        }
    }
}
