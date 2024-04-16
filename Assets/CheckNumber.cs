using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class CheckNumber : MonoBehaviour
{
    [SerializeField] private IncrementUIText text;
    [SerializeField] private int answer;

    public bool correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(text.m_Count == answer)
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }
}
