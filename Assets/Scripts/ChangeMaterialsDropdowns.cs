using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeMaterialsDropdowns : MonoBehaviour
{
    [SerializeField] GameObject[] assets_concernés;
    [SerializeField] Material material_choix_1;
    [SerializeField] Material material_choix_2;
    [SerializeField] Material material_choix_3;

    public void ChangeAssetsMaterial(int index)
    {
        switch (index)
        {
            case 0:
                foreach (GameObject asset in assets_concernés)
                {
                    ChangeMaterial(asset, material_choix_1);
                }
                break;
            case 1:
                foreach (GameObject asset in assets_concernés)
                {
                    ChangeMaterial(asset, material_choix_2);
                }
                break;
            case 2:
                foreach (GameObject asset in assets_concernés)
                {
                    ChangeMaterial(asset, material_choix_3);
                }
                break;
            default:
                break;
        }
    }

    private void ChangeMaterial(GameObject asset, Material material)
    {
        asset.GetComponent<Renderer>().material = material;
    }
}
