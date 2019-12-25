using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowColumns : MonoBehaviour
{
    public GameObject WorldManager;
    Text text;

    private void Start()
    {
        text = this.GetComponent<Text>();
    }

    public void SetText()
    {
        text.text = "Columns: " + WorldManager.GetComponent<GenerateMazeScript>().mazeColumns;
    }
}
