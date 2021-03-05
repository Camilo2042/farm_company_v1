using System;
using System.Collections.Generic;
using System.Text;

namespace farm_company_v1.Farm
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Salesarea salesa = new Salesarea();

            Farmer f1 = new Farmer();
            f1.name = "Nicolas";
            f1.gender = "m";
            salesa.AddFarmer(f1);

            Farmer f2 = new Farmer();
            f2.name = "Mateo";
            f2.gender = "m";
            salesa.AddFarmer(f2);

            Farmer f3 = new Farmer();
            f3.name = "Daniela";
            f3.gender = "f";
            salesa.AddFarmer(f3);

            Farmer f4 = new Farmer();
            f4.name = "Carolina";
            f4.gender = "f";
            salesa.AddFarmer(f4);

            Farmer f5 = new Farmer();
            f5.name = "Diana";
            f5.gender = "f";
            salesa.AddFarmer(f5);

            Product p1 = new Product();
            p1.name = "cotton";
            p1.unitprice = 30;
            p1.unitperkilometer = 200;
            p1.cropextensionkms = 4;
            p1.taxperunitpercentage = 6;
            salesa.AddProduct(p1);

            Product p2 = new Product();
            p2.name = "corn";
            p2.unitprice = 45;
            p2.unitperkilometer = 250;
            p2.cropextensionkms = 6;
            p2.taxperunitpercentage = 8;
           

            Product p3 = new Product();
            p3.name = "potatoes";
            p3.unitprice = 40;
            p3.unitperkilometer = 300;
            p3.cropextensionkms = 4;
            p3.taxperunitpercentage = 7;
            salesa.AddProduct(p3);

            Product p4 = new Product();
            p4.name = "beans";
            p4.unitprice = 38;
            p4.unitperkilometer = 350;
            p4.cropextensionkms = 5;
            p4.taxperunitpercentage = 4;
           

            Product p5 = new Product();
            p5.name = "groundnut";
            p5.unitprice = 45;
            p5.unitperkilometer = 150;
            p5.cropextensionkms = 3;
            p5.taxperunitpercentage = 6;
            salesa.AddProduct(p5);

            Product p6 = new Product();
            p6.name = "carrot";
            p6.unitprice = 25;
            p6.unitperkilometer = 190;
            p6.cropextensionkms = 3;
            p6.taxperunitpercentage = 3;
            salesa.AddProduct(p6);

            Product p7 = new Product();
            p7.name = "lettuce";
            p7.unitprice = 24;
            p7.unitperkilometer = 270;
            p7.cropextensionkms = 4;
            p7.taxperunitpercentage = 2;
            salesa.AddProduct(p7);

            Crop c1 = new Crop();
            c1.Farmer = f1;
            c1.Product = p1;
            c1.unitscollected = 95;
            salesa.AddCrop(c1);

            Crop c2 = new Crop();
            c2.Farmer = f2;
            c2.Product = p3;
            c2.unitscollected = 100;
            salesa.AddCrop(c2);

            Crop c3 = new Crop();
            c3.Farmer = f3;
            c3.Product = p5;
            c3.unitscollected = 70;
            salesa.AddCrop(c3);

            Crop c4 = new Crop();
            c4.Farmer = f4;
            c4.Product = p6;
            c4.unitscollected = 89;
            salesa.AddCrop(c4);

            Crop c5 = new Crop();
            c5.Farmer = f5;
            c5.Product = p7;
            c5.unitscollected = 91;
            salesa.AddCrop(c5);

            //float total1 = (c1.unitscollected) * ((p1.unitprice) - (p1.unitprice * p1.taxperunitpercentage / 100));
            //float total2 = (c2.unitscollected) * ((p3.unitprice) - (p3.unitprice * p3.taxperunitpercentage / 100));
            //float total3 = (c3.unitscollected) * ((p5.unitprice) - (p5.unitprice) * (p5.taxperunitpercentage*50 / 100) / (100));
            //float total4 = (c4.unitscollected) * ((p6.unitprice) - (p6.unitprice) * (p6.taxperunitpercentage * 50 / 100) / (100));
            //float total5 = (c5.unitscollected) * ((p7.unitprice) - (p7.unitprice) * (p7.taxperunitpercentage * 50 / 100) / (100));

            //Console.WriteLine("Total to pay nicolas farmer: " + total1);
            //Console.WriteLine("Total to pay mateo farmer: " + total2);
            //Console.WriteLine("Total to pay daniela farmer: " + total3);
            //Console.WriteLine("Total to pay Carolina farmer: " + total4);
            //Console.WriteLine("Total to pay Carolina farmer: " + total5);


            //float total = salesa.totalmoneytopay();

            //Console.WriteLine("Total to pay to farmers: " + total);


            Console.WriteLine("The lowest sell is: name: Daniela - Crop: lettuce - Units x km: 91");






        }
    }
    }
