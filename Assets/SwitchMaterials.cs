using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterials : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject model;
    public Material[] mats;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeMat (Material mat){

        mats = model.GetComponent<Renderer>().materials;
        mats[0] = mat;
        model.GetComponent<Renderer>().materials = mats;
        model.GetComponent<Renderer>().material = mat;
        Debug.Log("Changed mat");
    }
}
