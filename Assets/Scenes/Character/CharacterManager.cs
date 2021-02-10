using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Character character1;
    public Character character2;
    public Character character3;
    public Character character4;
    private Character selectedCharacter;

    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField]
    private Camera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit  = Physics2D.Raycast(mousePos, Vector2.zero);
            if(hit && hit.transform.gameObject.tag=="Player")
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                clickable.click();
            }
            else{
                if(selectedCharacter!=null){
                    selectedCharacter.setMoveTargetPosition();
                }
            }
        }
    }

    public void setSelectedCharacter(Character targetCharacter){
        selectedCharacter = targetCharacter;
    }
}