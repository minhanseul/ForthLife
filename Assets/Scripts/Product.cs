using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    //메쉬 렌더러
    private MeshRenderer mesh;


    //물품코드 판별을 위한 행열
    public int col;
    public int row;

    //공정 전 매테리얼
    public Material beforeMaterial;
    //공정 후 매테리얼
    public Material afterMaterial;


    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();

        mesh.material = beforeMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SewingMachine"))
        {
            ChangeMaterial(afterMaterial);
        }
    }

    private void ChangeMaterial(Material mat)
    {
        mesh.material = mat;
    }
}
