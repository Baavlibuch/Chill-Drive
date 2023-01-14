using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characters;
    public Transform spawnLocation;
    public Transform parentObject;

    void Start()
    {
        // Generate a random index between 0 and the length of the "characters" array
        int randomIndex = Random.Range(0, characters.Length);

        // Instantiate the character at the desired spawn location
        GameObject selectedCharacter = Instantiate(characters[randomIndex], spawnLocation.position, spawnLocation.rotation, parentObject);

        // Get the Animator component of the selected character and start the animation
        Animator animator = selectedCharacter.GetComponent<Animator>();
        animator.Play("", -1, 0f);
    }
}
