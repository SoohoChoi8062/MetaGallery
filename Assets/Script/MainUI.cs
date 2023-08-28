using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    private static MainUI instance;

    [SerializeField] public GameObject ItemList_Panel;
    [SerializeField] public GameObject Item_Exit;
    [SerializeField] public GameObject ArtInfo_Panel;
    [SerializeField] public GameObject Button;

    

    public static MainUI Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        ItemList_Panel.SetActive(false);
        ArtInfo_Panel.SetActive(false);
        Button.SetActive(false);
    }

    public void ItemEnter()
    {
        ItemList_Panel.SetActive(true);
    }

    public void ItemExit()
    {
        ItemList_Panel.SetActive(false);
    }

    public void ArtInfoPanel()
    {
        ArtInfo_Panel.SetActive(true);
    }
}
