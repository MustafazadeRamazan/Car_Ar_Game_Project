using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{

    private ARRaycastManager rayManager;
    private GameObject visual;
    public GameObject ActivatePanel;
    public GameObject FindText;

    void Start()
    {
        // get the component
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;

        // hide the placement visual

        visual.SetActive(false);
        ActivatePanel.SetActive(false);
        FindText.SetActive(true);

    }

    void Update()
    {
        // shoot a raycast from the center of the screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        // if we hit AR Plane, Update the postion and rotation

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if (!visual.activeInHierarchy)
            {
                visual.SetActive(true);
                ActivatePanel.SetActive(true);
                FindText.SetActive(false);
            }
        }
    }

}
