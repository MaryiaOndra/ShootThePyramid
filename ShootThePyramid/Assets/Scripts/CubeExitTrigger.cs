using UnityEngine;

public class CubeExitTrigger : MonoBehaviour
{
    public bool IsCubeExitTrigger { get; private set; }

    private void OnTriggerExit(Collider other)
    {
        IsCubeExitTrigger = true;
    }
}
