using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    public Object Basil;
    public Object Joghurt;
    public Object BeerBox;
    public Object Banana;
    public Object Bread;
    public Object Milk;
    //public Rigidbody Item1;
    public Transform Item1;
    public Transform Item2;
    public Transform Item3;
    public Transform Item4;
    public Transform Item5;
    public int click;
   public Transform item;


   public List<Transform> Itemlist;
    public List<Object> Objectlist;
    public List<float> Pricelist;



    //ItemList.Add(Basil, 1.25f);
    //ItemList.Add("Joghurt", Joghurt, 0.99f);
    //ItemList.Ad"BeerBox", BeerBox, 5.50f);
    //ItemList.Add("Banana", Bd(anana, 0.25f);
    //ItemList.Add("Bread", Bread, 2.29f);
    //ItemList.Add("Milk", Milk, 1.50f);

    // Start is called before the first frame update
    
void Start()
    {
        click = 0;

        Itemlist = new List<Transform>();
        Itemlist.Add(Item1);
        Itemlist.Add(Item2);
        Itemlist.Add(Item3);
        Itemlist.Add(Item4);
        Itemlist.Add(Item5);

        Objectlist = new List<Object>();
        Objectlist.Add(Basil);
        Objectlist.Add(Joghurt);
        Objectlist.Add(Banana);
        Objectlist.Add(Bread);
        Objectlist.Add(Milk);

        Pricelist.Add(1.25f);
        Pricelist.Add(0.99f);
        Pricelist.Add(0.25f);
        Pricelist.Add(2.29f);
        Pricelist.Add(1.50f);
    }

    // Update is called once per frame
    void Update()
    {

                if (Input.GetMouseButtonDown(0))
                {

                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        var selection = hit.transform.gameObject;
                        string obj = hit.transform.gameObject.name;
                        {

                            //string part2 = part.name
                            //foreach (Object part in Objectlist//) && part.name.Equals(obj)
                            if (selection.CompareTag(selectableTag))
                                {
                        click = click++;
                        Debug.Log("click ="+click.ToString());
                        item = Itemlist[click];
                        Instantiate(hit.transform.gameObject, item.position, item.rotation);
                        //Instantiate(hit.transform.gameObject, Item2.position, Item2.rotation);
                        //Instantiate(hit.transform.gameObject, Item3.position, Item3.rotation);
                        //Instantiate(hit.transform.gameObject, Item4.position, Item4.rotation);
                        //Instantiate(hit.transform.gameObject, Item5.position, Item5.rotation);


                        //print(Input.GetMouseButtonDown);
                        //print(item);



                    }

                }
                        //Input.GetMousButtonUp;
                    }
                    //else if (Input.GetMouseButtonUp(0))
                    //{
                    //    break;
                    //}
                       
                }
            


        
    }
}
