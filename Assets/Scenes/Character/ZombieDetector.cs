using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDetector : MonoBehaviour
{
    private List<GameObject> zombiesInRange;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Zombie"))
        {
            zombiesInRange.Add(other.gameObject);
        }
    }

    
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Zombie"))
        {
            zombiesInRange.Remove(other.gameObject);
        }
    }

    public gameObject getNearestZombie(){
        
    }
}
     
     
