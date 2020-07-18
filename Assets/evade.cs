using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evade : MonoBehaviour
{
  private bool complete = true;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    move();
  }

  public void move()
  {
    if (complete)
    {
      complete = false;

      transform.Translate(Vector3.left * Time.deltaTime * 10);

      StartCoroutine(Wait(2));

      transform.Translate(Vector3.right * Time.deltaTime * 10);

      StartCoroutine(Wait(2));

      complete = true;
    }
  }

  IEnumerator Wait(float delay)
  {
    yield return new WaitForSeconds(delay);
  }
}
