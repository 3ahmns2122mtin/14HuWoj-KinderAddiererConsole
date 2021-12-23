using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldValueOne, inputFieldValueTwo;
    [SerializeField] private Text textResult;

    public bool testing;

    public int CheckAddition(int summandOne, int summandTwo)
    {
        int result = 0;
        
        testing = false;

        result = summandOne + summandTwo;

        return result;
    }

    void Start()
    {
        CheckAddition(1, 2);
    }

    public void GetValues()
    {
        string valueOne, valueTwo;

        valueOne = inputFieldValueOne.text;
        valueTwo = inputFieldValueTwo.text;

        Debug.Log("Methode GetValues wird ausgeführt:" + CheckAddition(int.Parse(valueOne), int.Parse(valueTwo)));
    }

    void Update()
    {
        if (testing)
        {
            GetValues();
        }
    }
}
