using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using JetBrains.Annotations;
using Microsoft.MixedReality.Toolkit.UI;

public class ExperimentManager : MonoBehaviour
{
    public TextMeshPro experimentLabel;
    public TextMeshPro completionLabel;
    public TextMeshPro descLabel;
    public TextMeshPro stepLabel;
    public Interactable ELeft;
    public Interactable ERight;
    public Interactable SLeft;
    public Interactable SRight;

    public UnityEvent onChangedTask;
    private List<string> tasks = new List<string>() { "1", "2", "3", "4" };
    private List<string> steps = new List<string>() { "1", "2", "3","4" };

    private string experiment = "";
    private string desc = "";
    private int completion = 0;
    private int counterE = 0;
    private int counterS = 0;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        ELeft.OnClick.AddListener(() => ButtonPressedL1());
        ERight.OnClick.AddListener(() => ButtonPressedR1());
        SLeft.OnClick.AddListener(() => ButtonPressedL2());
        SRight.OnClick.AddListener(() => ButtonPressedR2());

        if (experimentLabel != null)
        {
            experimentLabel.SetText(tasks[counterE]);
            stepLabel.SetText("Step: " + steps[counterS]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        descLabel.SetText("Put description here");
        completionLabel.SetText("Completion: " + count + "%");
    }
    public void ButtonPressedR1()
    {
        if (counterE < tasks.Count-1)
        {
            counterE += 1;

            experimentLabel.SetText(tasks[counterE]);
        }
    }
    public void ButtonPressedL1()
    {
        if (counterE < tasks.Count && counterE > 0)
        {
            counterE -= 1;

            experimentLabel.SetText(tasks[counterE]);
        }
    }
    public void ButtonPressedR2()
    {
        if (counterS < steps.Count - 1)
        {
            counterS += 1;

            stepLabel.SetText("Step: " + steps[counterS]);
        }
    }
    public void ButtonPressedL2()
    {
        if (counterS < steps.Count && counterS > 0)
        {
            counterS -= 1;

            stepLabel.SetText("Step: " + steps[counterS]);
        }
    }
}