using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class IAPController : MonoBehaviour
{
    public RankSistemi rs;
    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id == "point_1") rs.level += 5;
        else if (product.definition.id == "point_4") rs.level += 30;
        else if (product.definition.id == "point_15") rs.level += 100;
        PlayerPrefs.SetFloat("Levelim", rs.level);
    }
    public void OnPurchaseFailure(Product product, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of product " + product.definition.id + " failed because " + reason);
    }
}
