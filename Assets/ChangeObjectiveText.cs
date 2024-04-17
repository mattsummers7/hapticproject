using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeObjectiveText : MonoBehaviour
{
    public static bool pressStart;
    public static bool shootCameras;
    public static bool findGold;
    public static bool escapeWallClimb;
    public static bool escapeRoofJump;
    public static bool escapeBoat;


    [SerializeField] Animator fadeText;
    [SerializeField] TextMeshProUGUI objectiveText;



    private void Start()
    {
        objectiveText.text = ("press start to play");
        StartCoroutine(ShowText(pressStart));
    }
    // Update is called once per frame
    void Update()
    {

        if (shootCameras)
        {
            objectiveText.text = ("shoot the cameras");
            StartCoroutine(ShowText(shootCameras));
        }

        if(findGold)
        {
            objectiveText.text = ("find all the gold in the bank and collect it");
            StartCoroutine(ShowText(findGold));
            
        }

        if(escapeWallClimb)
        {
            objectiveText.text = ("you have all the gold! now get out of there and climb that wall");
            StartCoroutine(ShowText(escapeWallClimb));
        }

        if(escapeRoofJump)
        {
            objectiveText.text = ("escape! jump from roof to roof and get to the boat");
            StartCoroutine(ShowText(escapeRoofJump));
        }

        if(escapeBoat)
        {
            objectiveText.text = ("the boat is in front of you, get on it and go!");
            StartCoroutine(ShowText(escapeBoat));
        }
    }

    public IEnumerator ShowText(bool objective)
    {

        objectiveText.enabled = true;
        yield return new WaitForSeconds(5);
        fadeText.SetBool("disappear", true);
        yield return new WaitForSeconds(2);
        fadeText.SetBool("disappear", false);
        objectiveText.enabled = false;
        objective = false;

    }
}
