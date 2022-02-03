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
        }
        catch (System.Exception)
        {
            inputFieldValueOne.GetComponent<InputField>().image.color = Color.red;
            inputFieldValueOne.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte richtigen Wert eingeben";
            inputFieldValueOne.text = "";
        }

        try
        {
            termTwo = int.Parse(inputFieldValueTwo.text);
        }
        catch (System.Exception)
        {
            inputFieldValueTwo.GetComponent<InputField>().image.color = Color.red;
            inputFieldValueTwo.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte richtigen Wert eingeben";
            inputFieldValueTwo.text = "";
        }
    }

    public void ResetButton()
    {
        inputFieldValueOne.text = "";
        inputFieldValueTwo.text = "";

        textResult.text = "result";

        valueOne = "0";
        valueTwo = "0";

        inputFieldValueOne.GetComponent<InputField>().image.color = Color.white;
        inputFieldValueTwo.GetComponent<InputField>().image.color = Color.white;

        inputFieldValueOne.GetComponent<InputField>().GetComponent<Text>().text = "Value one...";
        inputFieldValueTwo.GetComponent<InputField>().GetComponent<Text>().text = "Value two...";

        Debug.Log("Es wird resetet");
    }
}
