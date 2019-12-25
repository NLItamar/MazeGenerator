using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetValues : MonoBehaviour
{
    //the button in question
    public Button setValuesButton;

    //World manager object with the script attached to it
    public GameObject WorldManager;

    //the input fields
    public InputField Rows;
    public InputField Columns;

    //displayed values
    public GameObject textRows;
    public GameObject textColumns;

    void Start()
    {
        Button btn = setValuesButton.GetComponent<Button>();
        btn.onClick.AddListener(SetTheValues);
    }

    public void SetTheValues()
    {
        //set the input to the world manager
        WorldManager.GetComponent<GenerateMazeScript>().mazeRows = int.Parse(Rows.text);
        WorldManager.GetComponent<GenerateMazeScript>().mazeColumns = int.Parse(Columns.text);

        //call the methods to change the text
        textRows.GetComponent<ShowRows>().SetText();
        textColumns.GetComponent<ShowColumns>().SetText();
    }
}
