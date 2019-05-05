using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class PlayerCollider : MonoBehaviour
{
    public GameObject track;
    public GameObject LethalObject;
    public PlayerMov movement;
    // offset of new track
    public float y_offset;
    public float z_offset;
    public float platform_length;
    public float object_length;
    public float object_y_pos;
    bool isColliding = false;
    float randNum;
    IEnumerator makeFalse()
    {
        yield return new WaitForSeconds(1f);
        isColliding = false;
    }
        
    // enter on collision
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Lethal_Obstacle")
        {
            movement.rb.velocity = new Vector3(0f, 0f, 0f);
            movement.enabled = false;
            SceneManager.LoadScene("menu");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "spawnNew")
        {
                if (!isColliding)
                {
                isColliding = true;
                Vector3 newPos = new Vector3();
                newPos.y = other.transform.position.y + y_offset;
                newPos.x = other.transform.position.x;
                newPos.z = other.transform.position.z + z_offset;
                Instantiate(track, newPos, Quaternion.identity);
                // max_z and min_z for z coordinate
                float min = newPos.z - (platform_length / 2) + 0.5f; // 0.5 added as a buffer amount
                float max = min + platform_length - 1f;// 1 subtracted as a buffer
                float counter = min;
                while (counter < max)
                {
                    randNum = Random.Range(0, 13);
                    Debug.Log(other.gameObject.name);
                    if (randNum <= 4)
                    {

                    }
                    else if (randNum <= 6)
                    {
                        Instantiate(LethalObject, new Vector3(-2, object_y_pos, counter), Quaternion.identity);
                    }
                    else if (randNum <= 8)
                    {
                        Instantiate(LethalObject, new Vector3(0, object_y_pos, counter), Quaternion.identity);
                    }
                    else if (randNum <= 10)
                    {
                        Instantiate(LethalObject, new Vector3(2, object_y_pos, counter), Quaternion.identity);
                    }
                    else if (randNum == 11)
                    {
                        Instantiate(LethalObject, new Vector3(-2, object_y_pos, counter), Quaternion.identity);
                        Instantiate(LethalObject, new Vector3(0, object_y_pos, counter), Quaternion.identity);
                    }
                    else if (randNum == 12)
                    {
                        Instantiate(LethalObject, new Vector3(0, object_y_pos, counter), Quaternion.identity);
                        Instantiate(LethalObject, new Vector3(2, object_y_pos, counter), Quaternion.identity);
                    }
                    else if (randNum == 13)
                    {
                        Instantiate(LethalObject, new Vector3(2, object_y_pos, counter), Quaternion.identity);
                        Instantiate(LethalObject, new Vector3(-2, object_y_pos, counter), Quaternion.identity);
                    }
                    counter += 4 * object_length;
                }
                StartCoroutine(makeFalse());
                }
        }
    }
    
}
