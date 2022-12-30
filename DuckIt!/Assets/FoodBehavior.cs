using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehavior : MonoBehaviour
{
  // Start is called before the first frame update
  private float HP = 100;
  bool m_Started;
  public LayerMask m_LayerMask;
  void Start()
  {
    m_Started = true;
  }

  // Update is called once per frame
  void Update()
  {
    Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 6, Quaternion.identity, m_LayerMask);
    int i = 0;
    //Check when there is a new collider coming into contact with the box
    while (i < hitColliders.Length)
    {
      if (hitColliders[i].name == "Duck(Clone)")
      {
        HP -= 5 * Time.deltaTime;
        transform.localScale = new Vector3(HP / 100, HP / 100, HP / 100);
        if (HP < 40)
        {
          Destroy(gameObject);
        }
      }
      i++;
    }
  }
}
