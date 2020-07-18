using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

  public GameObject bulletPrefab;
  public Transform spawnObject;

  public int velocity;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      GameObject go = Instantiate(bulletPrefab, spawnObject.position, transform.rotation) as GameObject;
      go.GetComponent<Rigidbody>().AddForce(transform.forward * velocity, ForceMode.Impulse);
    }
  }
}
