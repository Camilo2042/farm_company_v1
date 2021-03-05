using System;
using System.Collections.Generic;
using System.Text;

namespace farm_company_v1.Farm
{
    public class Salesarea
    {
        Farmer[] Farmers = new Farmer[50];
        int farmerCount = 0;

        Crop[] Crops = new Crop[50];
        int cropCount = 0;

        Product[] Products = new Product[50];
        int productCount = 0;

        public void AddFarmer(Farmer farmer)
        {
        Farmers[farmerCount] = farmer;
            farmerCount++;
        }

        public void AddCrop(Crop crop)
        {
        Crops[cropCount] = crop;
            cropCount++;
        }

        public void AddProduct(Product product)
        {
        Products[productCount] = product;
            productCount++;
        }

        public float totalmoneytopay()
        {
            float total = 0;

            for (int i = 0; i < cropCount; i++)
            {
                if (Farmers[i].gender == "f")
                {
                    total = total + (Crops[i].unitscollected) * ((Crops[i].Product.unitprice) - (Crops[i].Product.unitprice) * (Crops[i].Product.taxperunitpercentage * 50 / 100) / (100));
                }

                else

                {
                    total = total + (Crops[i].unitscollected) * ((Crops[i].Product.unitprice) - (Crops[i].Product.unitprice * Crops[i].Product.taxperunitpercentage / 100));
                }
            }

            return total; 
        }


    }



}


















