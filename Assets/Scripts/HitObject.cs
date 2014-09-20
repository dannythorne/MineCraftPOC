using UnityEngine;
using System.Collections;

public class HitObject : MonoBehaviour {

	public GameObject pickup;

	// Use this for initialization
	void Start () {

		Debug.Log("Start!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton()
	{
		Debug.Log("Mouse!");
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth/2,Camera.main.pixelHeight/2,0));
		RaycastHit hit;
		if( Physics.Raycast(ray, out hit, 100))
		{
			Debug.DrawLine(ray.origin, hit.point, Color.red, 100);
			//Vector3 s = transform.localScale;
			//s.x *= 0.5f;
			//s.y *= 0.5f;
			//s.z *= 0.5f;
			//transform.localScale = s;

			Instantiate(pickup, transform.position, transform.rotation);

		    Destroy(gameObject);

		}

	}
}
