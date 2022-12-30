using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckMove : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject myDuck;
  private bool startedWalking = false;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    bool isWalking = myDuck.GetComponent<DuckBehavior>().currentAct == "isWalking";
    if (isWalking)
    {
      if (startedWalking == false)
      {
        Vector3 randomDirection = new Vector3(0, Random.Range(-359, 359), 0);
        transform.Rotate(randomDirection);
        startedWalking = true;
      }
      transform.position += transform.forward * 0.09f * Time.deltaTime;
    //   Debug.Log(transform.position);
    }
    else
    {
      startedWalking = false;
    }
  }
}
