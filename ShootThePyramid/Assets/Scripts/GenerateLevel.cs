using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    [SerializeField] private GameObject levelPoint;
    [SerializeField] private GameObject levelPrefab;

    private void Start()
    {
        GameObject.Instantiate(levelPrefab, levelPoint.transform);
    }
}
