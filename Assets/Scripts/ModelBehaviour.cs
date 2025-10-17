using UnityEngine;

public class ModelBehaviour : MonoBehaviour
{
    public void ActivateCube(GameObject obj)
    {
        obj.SetActive(true);}

    public void DeactivateCube(GameObject obj) {
        obj.SetActive(false); }

    public void SetRandomColor(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public void RotateGameObject(GameObject obj)
    {
        obj.transform.Rotate(Vector3.up , 5);
    }

}
