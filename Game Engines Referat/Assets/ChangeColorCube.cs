using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCube : MonoBehaviour
{
    MeshRenderer mesh;
    Color defaultColor;
    Color blueColor = Color.blue;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        defaultColor = mesh.material.color;
    }

    public void ChangeColor()
    {
        if(mesh.material.color == defaultColor)
        {
            mesh.material.color = blueColor;
        }
        else
        {
            mesh.material.color = defaultColor;
        }
    }
}
