using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckMove : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject myDuck;
  public LayerMask m_LayerMask;
  private GameObject foodTarget;
  private float eatingDist = 5;
  private bool foundFood = false;
  private bool startedWalking = false;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    bool isWalking = myDuck.GetComponent<DuckBehavior>().currentAct == "isWalking";
    checkForFood();
    if (!foundFood)
    {
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
    else
    {
      if(foodTarget!=null)
      {
        float x = this.transform.position.x;
        float z = this.transform.position.z;
        float a = x - foodTarget.transform.position.x;
        float b = z - foodTarget.transform.position.z;
        float dist = Mathf.Sqrt(a * a + b * b);
        if (dist > 0.2f)
        {
          if(!isWalking)
            myDuck.GetComponent<DuckBehavior>().animator.SetBool("isWalking", true);
          transform.position += transform.forward * .15f * Time.deltaTime;
        }
        else
        {
          if(isWalking)
            myDuck.GetComponent<DuckBehavior>().animator.SetBool("isWalking", false);
          if (myDuck.GetComponent<DuckBehavior>().currentAct != "isEating")
          {
            myDuck.GetComponent<DuckBehavior>().currentAct = "isEating";
            myDuck.GetComponent<DuckBehavior>().animator.SetBool("isEating", true);
          }
        }
      }
      else
      {
        foundFood = false;
        myDuck.GetComponent<DuckBehavior>().foundFood = false;
        myDuck.GetComponent<DuckBehavior>().currentAct = "";
        myDuck.GetComponent<DuckBehavior>().isActing = false;
        myDuck.GetComponent<DuckBehavior>().cooldown = Random.Range(2, 5);
        myDuck.GetComponent<DuckBehavior>().animator.SetBool("isWalking", false);
        myDuck.GetComponent<DuckBehavior>().animator.SetBool("isEating", false);
      }
    }
  }
  void checkForFood()
  {
    Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale * 30, Quaternion.identity, m_LayerMask);

    int i = 0;
    while (i < hitColliders.Length)
    {
      if (hitColliders[i].name == "Udon(Clone)")
      {
        foundFood = true;
        myDuck.GetComponent<DuckBehavior>().foundFood = true;
        foodTarget = hitColliders[i].transform.gameObject;
        transform.LookAt(foodTarget.transform);
        break;
      }
      i++;
    }
  }
}
