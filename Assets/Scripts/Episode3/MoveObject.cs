using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 1f; // Speed of the object
    public float enemySpeed = 0.5f;
    public float speedIncreaseRate = 0.05f; // Speed increase rate per second

    private void Update()
    {
        // Increase speed over time
        enemySpeed += speedIncreaseRate * Time.deltaTime;
        // Move the object from left to right
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        // Loop through all enemies

        // Find all GameObjects with the tag "enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {

            // Get the enemy's current position
            Vector3 position = enemy.transform.position;

            // Calculate the new position
            Vector3 newPosition = position + new Vector3(-enemySpeed * Time.deltaTime, 0, 0);

            // Apply the new position
            enemy.transform.position = newPosition;
            // Rotate the enemy around the z-axis
            float rotationSpeed = 10f; // Set this to the desired rotation speed
            enemy.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)  //Checks objects collisions
    {
        if (other.gameObject.tag == "Death")
        {
            Destroy(gameObject);
        }
    }
}