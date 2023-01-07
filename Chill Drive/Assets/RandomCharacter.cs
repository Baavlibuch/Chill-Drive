using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCharacter : MonoBehaviour
{
    public GameObject[] characterModels;

    void Start()
    {
        // Generate a random index between 0 and the length of the characterModels array
        int index = Random.Range(0, characterModels.Length);

        // Instantiate a random character model from the array
        GameObject character = Instantiate(characterModels[index], transform.position, transform.rotation);

        // Set the position and rotation of the instantiated character model to match that of the character game object
        character.transform.position = transform.position;
        character.transform.rotation = transform.rotation;

        // Destroy the original character game object to avoid having multiple copies in the scene
        Destroy(gameObject);
    }
}
