using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private GearManager gearManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �������� ������� ����� ���� � ������� ����������� (2D)
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // ������� ���, ������� �������� ����� ������� ����� ����
            Ray2D ray = new Ray2D(mousePosition, Vector2.zero);

            // ���������, ���� �� ������� ����������, � �������� ������������ ���
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                gearManager.TryToDig();
            }
        }
    }
}
