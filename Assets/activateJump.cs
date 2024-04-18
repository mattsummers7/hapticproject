using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateJump : MonoBehaviour
{
    [SerializeField] private jumpBehaviour jump;
    [SerializeField] private GameObject respawnBox;

    public bool isTutorial;

    private void OnTriggerEnter(Collider other)
    {
        if (jump != null)
        {
            jumpBehaviour.canJump = true;
            respawnBox.SetActive(true);
            if(!isTutorial)
            {
                StartCoroutine(changeText());
            }
            
        }

        
    }

    public IEnumerator changeText()
    {
        ChangeObjectiveText.escapeWallClimb = false;
        ChangeObjectiveText.escapeRoofJump = true;
        yield return new WaitForSeconds(1f);
        ChangeObjectiveText.escapeRoofJump = false;
    }
}
