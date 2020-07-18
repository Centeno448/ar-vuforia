using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{

  void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.tag == "Cube")
    {
      Destroy(col.gameObject);
    }
  }
}
