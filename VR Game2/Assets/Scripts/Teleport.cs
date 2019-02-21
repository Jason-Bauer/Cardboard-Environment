// 2017 Riccardo E. Giorato - giorat

using UnityEngine;

using System.Collections;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
  

  public GameObject camera;
  private VReyecaster cameraEyeCast;
    public Vector3 startMarker;
    public Vector3 endMarker;

    // Movement speed in units/sec.
    public float speed = 105.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;


    void Start()
  {
    cameraEyeCast = camera.GetComponent<VReyecaster>();
        startMarker = this.gameObject.transform.position;
        endMarker = this.gameObject.transform.position;
    }

  public void Recenter() {

    //GvrCardboardHelpers.Recenter();

    GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
    if (emulator == null) {
      return;
    }
    //emulator.Recenter();
  }
    void Update()
    {
        // Distance moved = time * speed.
        float distCovered = (Time.time - startTime) * speed;
        if (journeyLength > 0)
        {
            // Fraction of journey completed = current distance divided by total distance.
            float fracJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            this.gameObject.transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
        }
       
    }

    public void TeleportRandomly()
  {
        // Keep a note of the time the movement started.
        startTime = Time.time;
        startMarker = this.gameObject.transform.position;
        endMarker = cameraEyeCast.hitPoint();
        endMarker = new Vector3(endMarker.x, endMarker.y + 1.2f, endMarker.z);
        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker, endMarker);

        Debug.Log("click");
    transform.position = cameraEyeCast.hitPoint();
    transform.position = new Vector3 (transform.position.x, transform.position.y + 1.2f, transform.position.z);
    
  }
}
