using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwan : MonoBehaviour
{
    public Transform randomT;
    public GameObject[] prefabs;

    private float spawnTimer = 0f;
    public ParticleSystem particleEffect;
    public float spawnInterval = 2f;

    public float minX = -7f;
    public float maxX = 7f;
    public float minY = -4f;
    public float maxY = 4f;
    public float fixedZ = 2f; // Z-axis is fixed

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            Vector3 randomPosition = GetRandomPosition();

            if (randomPosition != Vector3.zero)
            {
                // Choose a random GameObject from the array
                GameObject randomGameObject = prefabs[Random.Range(0, prefabs.Length)];

                GameObject spawnedObject = Instantiate(randomGameObject, randomPosition, randomT.rotation);

                if (spawnedObject != null)
                {
                    Instantiate(particleEffect, randomPosition, Quaternion.identity);
                    // Use the spawnedObject if needed
                }
            }

            spawnTimer = 0f;
        }
    }

    Vector3 GetRandomPosition()
    {
        Vector3 randomPosition = Vector3.zero;

        int maxAttempts = 10;
        int attempts = 0;

        do
        {
            randomPosition = new Vector3(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                fixedZ
            );

            if (IsPositionInsideBackground(randomPosition) && !IsOverlapping(randomPosition))
            {
                // Ensure that the spawned object is within the screen boundaries
                ClampObjectWithinScreen(ref randomPosition);

                return randomPosition;
            }

            attempts++;
        } while (attempts < maxAttempts);

        // If it can't find a suitable position after maxAttempts, return Vector3.zero
        return Vector3.zero;
    }

    void ClampObjectWithinScreen(ref Vector3 position)
    {
        // Assuming the main camera is tagged as "MainCamera"
        Camera mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found!");
            return;
        }

        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(position);

        // Clamp within screen boundaries
        viewportPosition.x = Mathf.Clamp01(viewportPosition.x);
        viewportPosition.y = Mathf.Clamp01(viewportPosition.y);

        position = mainCamera.ViewportToWorldPoint(viewportPosition);
    }

    bool IsOverlapping(Vector3 position)
    {
        Collider[] colliders = Physics.OverlapSphere(position, 0.5f);

        // Check if there are any colliders (objects) in the specified radius
        return colliders.Length > 0;
    }

    bool IsPositionInsideBackground(Vector3 position)
    {
        return (position.x >= -8f && position.x <= 8f &&
                position.y >= -4f && position.y <= 4f &&
                position.z >= -8f && position.z <= 8f);
    }
}