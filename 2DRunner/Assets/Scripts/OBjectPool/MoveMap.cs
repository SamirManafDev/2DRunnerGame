using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;
    //[SerializeField] private SpriteRenderer SpriteGround;
    [SerializeField] private SpriteRenderer SpriteSea;

    private void Update()
    {
        MapSpawn();
    }
    private void MapSpawn()
    {
        SpriteRenderer.size += new Vector2(1f, 0);
        //SpriteGround.size += new Vector2(1f, 0);
        SpriteSea.size += new Vector2(1f, 0);
    }
}
