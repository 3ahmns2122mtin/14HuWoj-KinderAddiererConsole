using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldValueOne, inputFieldValueTwo;
    [SerializeField] private Text textResult;
    [SerializeField] private GameObject resetButton;

    private string valueOne, valueTwo;

    private int termOne, termTwo;

    public int CheckAddition(int summandOne, int summandTwo)
    {
        int result = 0;

        result = summandOne + summandTwo;

        return result;
    }

    void Start()
    {
        CheckAddition(1, 2);
    }

    public void GetValues()
    {
        valueOne = inputFieldValueOne.text;
        valueTwo = inputFieldValueTwo.text;

        termOne = int.Parse(valueOne);
        termTwo = int.Parse(valueTwo);

        textResult.text = CheckAddition(termOne, termTwo).ToString();

        try
        {
            termOne = int.Parse(inputFieldValueOne.text);
            termTwo = int.Parse(inputFieldValueTwo.text);
        }
        catch (System.Exception)
        {
            inputFieldValueOne.GetComponent<InputField>().image.color = Color.red;
            inputFieldValueOne.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte richtigen Wert eingeben";

            inputFieldValueTwo.GetComponent<InputField>().image.color = Color.red;
            inputFieldValueTwo.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte richtigen Wert eingeben";
        }
    }

    void Update()
    {

    }
}
