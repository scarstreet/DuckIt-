using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckBehavior : MonoBehaviour
{
  // Start is called before the first frame update
  public LayerMask m_LayerMask;
  public Animator animator;
  public bool isActing = false;
  public double cooldown;
  public string currentAct = "";
  public bool foundFood = false;
  void Start()
  {
    animator = GetComponent<Animator>();
    cooldown = Random.Range(3, 6);
  }

  // Update is called once per frame
  void Update()
  {
    if (!foundFood)
    {
      cooldown -= Time.deltaTime;

      if (!isActing && cooldown < 0)
      { // SET ACT =========================================
        isActing = true;
        int whichActNext = Random.Range(0, 20);
        if (whichActNext < 4) // Quack once. probability:4/20
        {
          currentAct = "isQuacking";
          cooldown = .2f;
        }
        else if (whichActNext < 15) // Walk around. probability:11/20
        {
          currentAct = "isWalking";
          cooldown = Random.Range(2, 9);
        }
        else if (whichActNext < 17) // Quack 10. probability:times 2/20
        {
          currentAct = "isQuacking";
          cooldown = 4;
        }
        else if (whichActNext < 18) // Sleeping. probability:1/20
        {
          currentAct = "isSleeping";
          cooldown = Random.Range(10, 30);
        }
        else // Spinning. probability:2/20
        {
          currentAct = "isSpinning";
          cooldown = Random.Range(5, 10);
        }
        animator.SetBool(currentAct, true);
      }
      if (isActing && cooldown < 0)
      { // BACK TO IDLE =====================================
        isActing = false;
        cooldown = Random.Range(5, 13);
        animator.SetBool(currentAct, false);
        currentAct = "";
      }
    }
  }

}
