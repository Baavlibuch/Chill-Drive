using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characters;

    void Start()
    {
        // Generate a random index between 0 and the length of the "characters" array
        int randomIndex = Random.Range(0, characters.Length);

        // Instantiate the character at the desired spawn location
        GameObject selectedCharacter = Instantiate(characters[randomIndex], transform.position, transform.rotation);
    }
}
