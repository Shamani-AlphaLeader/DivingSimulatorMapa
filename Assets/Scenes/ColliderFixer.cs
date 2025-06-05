using UnityEngine;

public class FixMeshColliders : MonoBehaviour
{
    void Start()
    {
        MeshCollider[] colliders = GetComponentsInChildren<MeshCollider>();

        foreach (MeshCollider mc in colliders)
        {
            MeshFilter mf = mc.GetComponent<MeshFilter>();
            if (mf != null && mf.sharedMesh != null)
            {
                mc.sharedMesh = mf.sharedMesh;
            }
        }

        Debug.Log("Todos os Mesh Colliders foram corrigidos!");
    }
}