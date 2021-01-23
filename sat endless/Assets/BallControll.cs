using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{

    public float speed;
    public GameObject Path;
    public Transform PathParent;
	// Update is called once per frame

	[HideInInspector]
	public bool Failed;

	Transform CurrentLocation;
	public GameControl gameControl;
	
	void Start() {

		CurrentLocation = transform;
	}

	public void Update()
	{
		if (!Failed)
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);

			//Debug.Log(Mathf.Abs(transform.position.y) - Mathf.Abs(CurrentLocation.position.y));
			if (Mathf.Abs(transform.position.y) - Mathf.Abs(CurrentLocation.position.y) > 50)
			{
				gameControl.Failed();
				Failed = true;

			}

			if (Input.touches.Length > 0)
			{
				Touch t = Input.GetTouch(0);
				if (t.phase == TouchPhase.Began)
				{

				}
				if (t.phase == TouchPhase.Moved)
				{
					transform.position = new Vector3(transform.position.x + t.deltaPosition.x * 0.007f, transform.position.y, transform.position.z);

				}
			}
		}

	}

	private void OnTriggerEnter(Collider other)
    {
		CurrentLocation = other.transform;
        GameObject go = Instantiate(Path,PathParent);
        go.transform.position = new Vector3(Random.Range(-5.5f, 5.5f), other.transform.position.y - 15-speed/2, other.transform.position.z + 40+speed*2f);
		speed += 1;
        
    }



	
}

