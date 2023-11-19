using UnityEngine;
using UnityEngine.Tilemaps;

public class ClickMove : MonoBehaviour
{
    public Tilemap tilemap; // Ÿ�ϸ� ����
    public TileBase targetTile; // �̵��� Ÿ�� ����
    private void Start()
    {
    }

    private void Update()
    {
        // ���콺 Ŭ�� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 Ŭ�� ��ġ�� ���� ��ǥ�� ��ȯ
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Ÿ�ϸʿ��� Ŭ���� ��ġ�� �ִ� Ÿ���� ã��
            Vector3Int cellPosition = tilemap.WorldToCell(mousePosition);
            TileBase clickedTile = tilemap.GetTile(cellPosition);

            // Ŭ���� Ÿ���� ��ǥ Ÿ�ϰ� ������ �̵� ����� ����
            if (clickedTile == targetTile)
            {

            }
        }
    }
}