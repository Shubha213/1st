using UnityEngine;
using UnityEngine.UI;

public class ChangeColorAndMaterial : MonoBehaviour
{
    public GameObject cube;
    public GameObject plane;
    public GameObject sphere;
    public Material redMaterial;
    public Material blueMaterial;
    public Material greenMaterial;
    public Texture cubeTexture;
    public Texture planeTexture;
    public Texture sphereTexture;

    void Start()
    {
        // Get the button component and attach the method to the button click event
        Button button = GetComponentInChildren<Button>(); // Assuming script attached to the button
        button.onClick.AddListener(ChangeColorsAndMaterials);
        
        // Ensure GameObject references are assigned correctly
        // This assumes cube, plane, and sphere are assigned in the Unity Editor
        // If not, you may need to find them dynamically
        cube = GameObject.Find("Cube");
        plane = GameObject.Find("Plane");
        sphere = GameObject.Find("Sphere");

        // Initialize game objects and materials
        cube.GetComponent<Renderer>().material = redMaterial;
        plane.GetComponent<Renderer>().material = blueMaterial;
        sphere.GetComponent<Renderer>().material = greenMaterial;
        cube.GetComponent<Renderer>().material.mainTexture = cubeTexture;
        plane.GetComponent<Renderer>().material.mainTexture = planeTexture;
        sphere.GetComponent<Renderer>().material.mainTexture = sphereTexture;
    }

    void ChangeColorsAndMaterials()
    {
        // Change the color, material, and texture of game objects dynamically
        cube.GetComponent<Renderer>().material.color = Random.ColorHSV();
        
        // Randomly select a material from the predefined materials
        Material[] materials = {redMaterial, blueMaterial, greenMaterial};
        Material randomMaterial = materials[Random.Range(0, materials.Length)];
        
        // Assign the randomly selected material to the plane
        plane.GetComponent<Renderer>().material = randomMaterial;

        // Change texture for the sphere (assuming you want to change it)
        sphere.GetComponent<Renderer>().material.mainTexture = sphereTexture; 
    }
}
