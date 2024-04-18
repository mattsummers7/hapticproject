using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeObjectiveText : MonoBehaviour
{
    public static bool pressStart = true;
    public static bool shootCameras;
    public static bool findGold;
    public static bool escapeWallClimb;
    public static bool escapeRoofJump;
    public static bool escapeBoat;


    [SerializeField] Animator fadeText;
    [SerializeField] public TextMeshProUGUI objectiveText;



    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (pressStart)
        {
            objectiveText.text = ("press start to play");
            StartCoroutine(ShowText(pressStart));
            pressStart = false;
        }

        if (TimerLogic.timer > 0 && shootCameras)
        {
            Debug.Log("LASDALSKDJ");
            objectiveText.text = ("shoot the cameras");
            StartCoroutine(ShowText(shootCameras));
            shootCameras = false;
        }

        if(findGold)
        {
            objectiveText.text = ("find all the gold in the bank and collect it");
            StartCoroutine(ShowText(findGold));
            findGold = false;
        }

        if(escapeWallClimb)
        {
            objectiveText.text = ("you have all the gold! now get out of there and climb that wall");
            StartCoroutine(ShowText(escapeWallClimb));
            escapeWallClimb = false;
        }

        if(escapeRoofJump)
        {
            objectiveText.text = ("escape! jump from roof to roof and get to the boat");
            StartCoroutine(ShowText(escapeRoofJump));
            escapeRoofJump = false;
        }

        if(escapeBoat)
        {
            objectiveText.text = ("the boat is in front of you, get on it and go!");
            StartCoroutine(ShowText(escapeBoat));
            escapeBoat = false;
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

    }
}
