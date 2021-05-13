
using UnityEngine;

public class KeepOnlySoundControl : MonoBehaviour
{

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 1)
        {
            Destroy(gameObject);
        }

    }
}
