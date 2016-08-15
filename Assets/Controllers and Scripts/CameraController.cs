using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    float speed;
    float maxZoom;
    float minZoom;
	// Update is called once per frame
    void Start()
    {
        speed = 1;
        maxZoom = 10;
        minZoom = 2;
    }

	void Update () {

        moveCamera();
        zoomCamera();
    }

    void moveCamera()
    {
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            Camera.main.transform.Translate(new Vector3(0, speed, 0));
        }

        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            Camera.main.transform.Translate(new Vector3(0, -speed, 0));
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.Translate(new Vector3(-speed, 0, 0));
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.Translate(new Vector3(speed, 0, 0));
        }
    }

    void zoomCamera()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(Camera.main.orthographicSize < maxZoom)
            {
                Camera.main.orthographicSize++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(Camera.main.orthographicSize > minZoom)
            {
                Camera.main.orthographicSize--;
            }
            
        }
    }
}
