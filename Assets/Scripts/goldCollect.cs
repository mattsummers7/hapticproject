using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class goldCollect : MonoBehaviour
{
    //script for collecting the gold around the map

    [SerializeField] goldTracker goldTracker;
    [SerializeField] AudioSource dingCollect;

    private void Start()
    {
        //adds an event when the grip button is pressed to start collectGold coroutine

        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.selectEntered.AddListener(collectGold);
    }

    public void collectGold(SelectEnterEventArgs args)
    {
        StartCoroutine(collectAndDelete());
    }

    private IEnumerator collectAndDelete()
    {
        //collect gold and delete it from scene

        goldTracker.goldCollected++;
        dingCollect.Play();
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
