using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
  public class ExplosionPhysicsForce : MonoBehaviour
  {
    public float explosionForce = 4;
    public AudioClip noise;

    private IEnumerator Start()
    {
      // wait one frame because some explosions instantiate debris which should then
      // be pushed by physics force
      yield return null;
      GetComponent<AudioSource>().PlayOneShot(noise);
      float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;

      float r = 10 * multiplier;
      var cols = Physics.OverlapSphere(transform.position, r);
      var rigidbodies = new List<Rigidbody>();
      foreach (var col in cols)
      {
        Destroy(col.transform.gameObject);
        // if (col.attachedRigidbody != null && !rigidbodies.Contains(col.attachedRigidbody))
        // {
        //   rigidbodies.Add(col.attachedRigidbody);
        // }
      }
      //   foreach (var rb in rigidbodies)
      //   {
      //     rb.AddExplosionForce(explosionForce * multiplier, transform.position, r, 1 * multiplier, ForceMode.Impulse);
      //   }
      StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
      yield return new WaitForSeconds(15f);
      Destroy(gameObject);
    }
  }
}
