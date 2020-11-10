using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using JetBrains.Annotations;
using Microsoft.MixedReality.Toolkit.UI;
<<<<<<< Updated upstream
=======
using System.Linq.Expressions;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
    private List<string> tasks = new List<string>() { "1", "2", "3", "4" };
    private List<string> steps = new List<string>() { "1", "2", "3","4" };

    private string experiment = "";
    private string desc = "";
    private int completion = 0;
    private int counterE = 0;
    private int counterS = 0;
    private int count = 0;
=======
    private List<string> tasks = new List<string>() { "Experiment 1", "Experiment 2", "Experiment 3", "Experiment 4" };
    private List<string> descs = new List<string>() { "For Experiment one, use the workbench to...", "For Experiment two, use the workbench to...", "For Experiment three, use the workbench to...", "For Experiment four, use the workbench to..." };
    private List<string> steps = new List<string>() {"OK"};
    private List<string> steps1 = new List<string>() { "Step 1 For Experiment 1", "Step 2 For Experiment 1", "Step 3 For Experiment 1", "Step 4 For Experiment 1" };
    private List<string> steps2 = new List<string>() { "Step 1 For Experiment 2", "Step 2 For Experiment 2", "Step 3 For Experiment 2", "Step 4 For Experiment 2", "Step 5 For Experiment 2" };
    private List<string> steps3 = new List<string>() { "Step 1 For Experiment 3", "Step 2 For Experiment 3", "Step 3 For Experiment 3" };
    private List<string> steps4 = new List<string>() { "Step 1 For Experiment 4", "Step 2 For Experiment 4", "Step 3 For Experiment 4", "Step 4 For Experiment 4", "Step 5 For Experiment 4", "Step 5 For Experiment 4" };

    private string experiment = "";
    private string desc = "";
    private float completion = 0;
    private int counterE = 0;
    private int counterS = 0;
    private float count = 0;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            stepLabel.SetText("Step: " + steps[counterS]);
=======
            descLabel.SetText(descs[counterE]);
            stepLabel.SetText("Step: " + steps1[counterS]);
            completionLabel.SetText("Completion: " + count + "%");
            steps = steps1;
>>>>>>> Stashed changes
        }
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        descLabel.SetText("Put description here");
        completionLabel.SetText("Completion: " + count + "%");
    }
    public void ButtonPressedR1()
    {
        if (counterE < tasks.Count-1)
        {
            counterE += 1;

            experimentLabel.SetText(tasks[counterE]);
=======
    }
    public void ButtonPressedR1()
    {
        if (counterE < tasks.Count - 1)
        {
            counterE += 1;
            counterS = 0;
            experimentLabel.SetText(tasks[counterE]);
            descLabel.SetText(descs[counterE]);
            count = 0;
            completionLabel.SetText("Completion: " + count + "%");

            if (counterE == 0)
                steps = steps1;
            else if (counterE == 1)
                steps = steps2;
            else if (counterE == 2)
                steps = steps3;
            else if (counterE == 3)
                steps = steps4;
            ButtonPressedR2();
            ButtonPressedL2();

>>>>>>> Stashed changes
        }
    }
    public void ButtonPressedL1()
    {
        if (counterE < tasks.Count && counterE > 0)
        {
            counterE -= 1;
<<<<<<< Updated upstream

            experimentLabel.SetText(tasks[counterE]);
=======
            counterS = 0;
            experimentLabel.SetText(tasks[counterE]);
            descLabel.SetText(descs[counterE]);
            count = 0;
            completionLabel.SetText("Completion: " + count + "%");

            if (counterE == 0)
                steps = steps1;
            else if (counterE == 1)
                steps = steps2;
            else if (counterE == 2)
                steps = steps3;
            else if (counterE == 3)
                steps = steps4;
            ButtonPressedR2();
            ButtonPressedL2();
>>>>>>> Stashed changes
        }
    }
    public void ButtonPressedR2()
    {
        if (counterS < steps.Count - 1)
        {
            counterS += 1;
<<<<<<< Updated upstream

            stepLabel.SetText("Step: " + steps[counterS]);
=======
            stepLabel.SetText("Step: " + steps[counterS]);
            count = ((float)counterS / (float)steps.Count)*100;
            completionLabel.SetText("Completion: " + count + "%");
        }
        else
        {
            counterS = steps.Count;
            stepLabel.SetText("Step: Complete");
            count = 100;
            completionLabel.SetText("Completion: " + count + "%");
>>>>>>> Stashed changes
        }
    }
    public void ButtonPressedL2()
    {
<<<<<<< Updated upstream
        if (counterS < steps.Count && counterS > 0)
        {
            counterS -= 1;

            stepLabel.SetText("Step: " + steps[counterS]);
=======
        if (counterS < steps.Count + 1 && counterS > 0)
        {
            counterS -= 1;
            stepLabel.SetText("Step: " + steps[counterS]);
            count = ((float)counterS / (float)steps.Count) * 100;
            completionLabel.SetText("Completion: " + count + "%");
>>>>>>> Stashed changes
        }
    }
}