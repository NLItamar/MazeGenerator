using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRows : MonoBehaviour
{
    public GameObject WorldManager;
    Text text;

    private void Start()
    {
        text = this.GetComponent<Text>();
    }

    public void SetText()
    {
        text.text = "Rows: " + WorldManager.GetComponent<GenerateMazeScript>().mazeRows;
    }
}
