using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
  public GameObject cursor;
  public GameObject obj;
  public ARRaycastManager raycastManager;
  // Start is called before the first frame update

  public bool useCursor = true;
  void Start()
  {
    cursor.SetActive(useCursor);
  }

  // Update is called once per frame
  void Update()
  {
    if(useCursor){
      UpdateCursor();
    }

    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
        if(useCursor){
        GameObject.Instantiate(obj, transform.position, transform.rotation);
      } else {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        if(hits.Count > 0) {
          GameObject.Instantiate(obj, hits[0].pose.position, hits[0].pose.rotation);
        }
      }
    }
  }
  void UpdateCursor() {
    Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(.5f, .5f));
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

    if(hits.Count > 0){
      transform.position = hits[0].pose.position;
      transform.rotation = hits[0].pose.rotation;
    }
  }
}
