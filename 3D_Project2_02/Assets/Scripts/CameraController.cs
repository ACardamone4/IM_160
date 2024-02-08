using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Vector3 offset;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        offset = new Vector3(0, 4, -15); //Makes the camera go to a good position with the vehicle
    }


    /// <summary>
    /// 
    /// </summary>
    void LateUpdate() //Fraction of a second after udate, makes vehicle less jittery
    {
        transform.position = Player.transform.position + offset; //Makes the camera follow player
    }


}
