using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // ตัวแปรสำหรับเก็บตำแหน่งของตัวละคร

    // LateUpdate จะถูกเรียกหลังจาก Update ของทุกๆ GameObject
    // ทำให้แน่ใจว่าตัวละครเคลื่อนที่เสร็จแล้วก่อนที่กล้องจะตาม
    void LateUpdate()
    {
        // ตรวจสอบว่ามีตัวละครให้ตามหรือไม่
        if (player != null)
        {
            // กำหนดตำแหน่งใหม่ของกล้องให้ตามตำแหน่งของตัวละคร
            // แต่คงค่า Z เดิมไว้ (ปกติจะเป็น -10 สำหรับกล้อง 2D)
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}
