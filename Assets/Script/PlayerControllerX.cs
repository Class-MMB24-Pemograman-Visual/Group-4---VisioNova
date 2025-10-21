using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX_Version2 : MonoBehaviour
{
    public float speed = 20f;           // kecepatan maju pesawat
    public float rotationSpeed = 100f;  // kecepatan rotasi (pitch)
    private float verticalInput;        // input dari tombol atas/bawah

    void Update()
    {
        // Ambil input vertical (panah atas/bawah)
        verticalInput = Input.GetAxis("Vertical");

        // Gerakkan pesawat maju terus dengan kecepatan tetap
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Miringkan pesawat sesuai input panah atas/bawah
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
