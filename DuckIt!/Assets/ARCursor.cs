using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
  public GameObject cursor;
  public GameObject obj;
  public GameObject explosion;
  public GameObject food;
  public ARRaycastManager raycastManager;
  // Start is called before the first frame update

  public bool useCursor = true;
  public List<GameObject> allDucks;
  public List<GameObject> otherObjects;
  void Start()
  {
    cursor.SetActive(useCursor);
    allDucks = new List<GameObject>();
    otherObjects = new List<GameObject>();
  }

  // Update is called once per frame
  void Update()
  {
    if (useCursor)
    {
      UpdateCursor();
    }

    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
      GameObject toSummon = obj;
      if (UICtrl.currentMode == "Food")
        toSummon = food;
      else if (UICtrl.currentMode == "Boom")
        toSummon = explosion;

      if (useCursor)
      {
        GameObject newObj = GameObject.Instantiate(toSummon, transform.position, transform.rotation);
        if(UICtrl.currentMode == "Duck")
          allDucks.Add(newObj);
        else
          otherObjects.Add(newObj);
      }
      else
      {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        if (hits.Count > 0)
        {
          GameObject newObj = GameObject.Instantiate(toSummon, hits[0].pose.position, hits[0].pose.rotation);
          if (UICtrl.currentMode == "Duck")
            allDucks.Add(newObj);
          else
            otherObjects.Add(newObj);
        }
      }
      allDucks.RemoveAll(item => item == null);
      otherObjects.RemoveAll(item => item == null);
    }
  }
  void UpdateCursor()
  {
    Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(.5f, .5f));
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

    if (hits.Count > 0)
    {
      transform.position = hits[0].pose.position;
      transform.rotation = hits[0].pose.rotation;
    }
  }
}
