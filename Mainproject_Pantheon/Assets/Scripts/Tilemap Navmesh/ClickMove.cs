using UnityEngine;
using UnityEngine.Tilemaps;

public class ClickMove : MonoBehaviour
{
    public Tilemap tilemap; // 타일맵 연결
    public TileBase targetTile; // 이동할 타일 설정
    private void Start()
    {
    }

    private void Update()
    {
        // 마우스 클릭 감지
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 클릭 위치를 월드 좌표로 변환
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 타일맵에서 클릭한 위치에 있는 타일을 찾음
            Vector3Int cellPosition = tilemap.WorldToCell(mousePosition);
            TileBase clickedTile = tilemap.GetTile(cellPosition);

            // 클릭한 타일이 목표 타일과 같으면 이동 명령을 내림
            if (clickedTile == targetTile)
            {

            }
        }
    }
}