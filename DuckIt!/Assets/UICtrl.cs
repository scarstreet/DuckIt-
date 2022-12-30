using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : MonoBehaviour
{
  public string currentMode = "Duck";
  public GameObject panel;
  public GameObject ARCursor;
  public bool panelVis = true;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void changeMode(string mode)
  {
    currentMode = mode;
  }
  public void wipeDucks()
  {
    ARCursor cursorScript = ARCursor.GetComponent<ARCursor>();
    Debug.Log(cursorScript.allDucks.Count);
    cursorScript.allDucks.ForEach((e) => { Debug.Log(e); Destroy(e); });
  }

  public void togglePanelVis()
  {
    panelVis = !panelVis;
    panel.SetActive(panelVis);
  }
}
