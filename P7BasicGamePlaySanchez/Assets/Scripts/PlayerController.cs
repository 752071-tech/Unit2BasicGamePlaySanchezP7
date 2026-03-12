using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    public float zMin;
    public float zMax;
    public float verticalInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        verticalInput = Input.GetAxis("Vertical"); transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }   
}
