using assignment9.Management_System;

namespace assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1  Object Copying
            //a) What happens when you assign one object variable to another object variable?
            //====================refrence==============
            //الاتنين هيشاورو علي نفس الاوبجيكت وبالتالي اي تغيير هياثر علي الاتنين
            //==================value=========
            //هيشاورو علي اتنبن اوبجيكت مختلفينوبالتالي التغيير في واحد منهم مش هياثر علي التاني 

            //=========================================================================
            //b) Does assigning one object to another create a new object? Explain.
            //لا لانه بيام نسخ ref
            //وليس الاوبجيكت
            //=========================================================================

            //c) What is the difference between copying an object and copying its reference?
            //=================copying an object========================
            //دي بتنسح اوبجيكت جديد وبالتالي اي تغييرلن يؤثر علي الاخر
            //================copying its reference================
            //هيصبع عندك متغييرن بيشيرو علي نفي الاوبجيكت وبالتالي اي تغيير في احدهم هيؤثر ع التاني 
            //========================================================================



            #endregion
            #region Q2  Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            //بياخد الجاحه اللي علي الوش 
            //==valuetype==independent
            //==refrencetypy==dependent

            //=================================
            //b) What is a Deep Copy?
            //بيخيلي كل حاجه مستقله عن الاخري ةاي تغيير لا يؤثر علي التاني 
            //==============================================

            //c) What happens to reference-type members when a Shallow Copy is created?
            //هما الاثنين هيشيروا على نفس الاوبجيكت وبالتالي أي تغيير هيأثر على الاثنين
            //============================================================

            //d) What happens to reference-type members when a Deep Copy is created?
            //يتم إنشاء اوبجيكت جديد وبالتالي هيكون عندي اثنين اوبجيكت مختلفين وأي تغيير لن يؤثر على الثاني
            //====================================================================

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //لو عندي في السيستم حاجه افتراضيه ببعتها للعميل وهو يعدل فيها 
            //=======================Deep Copy===============
            //    هيتم انشاء اوبجيكت جديد وبالتالي اي تغيير هيعمله المستخدم لن يؤثر علي القيم الافتراضيه
            //=======================Shallow Copy=============
            //لان يتم انشاء اوبجيكت جديد وبالتالي اي تغيير سيحدثه العميل هيؤثر علي القيم الافتراضيه بتاغتي ودا هيسببلي مشكله
            //=================================================================


            #endregion
            #region Q3  Static Members
            //a) What is a static field, and how is it different from an instance field?
            //============static field============
            //يتم الوصول ليه من خلال اسم الكلاس دون الحاجه الي انشاء اوبجيكت جديد
            //=================== instance field======
            //لازم عشان نوصله نعمله اوبديكت جديد
            //====================================================================

            //b) What is a static method? Can a static method directly access instance members?
            //=====static method ====
            //لا تحتاج لانشاء اوبجيكت جديد
            //من خلالها لانه يحتاج لانشاء اوبجيكت instance members ولكن لا يمكن استدعاء 
            //=========================================

            //c) What is a static constructor, and when is it executed?
            //دا كود بيشتغل مره واحه بس تلقاييي
            // static بنستخدمهلما نعوز نعمل حاجه  
            //==================================================

            //d) What is a static class? Can you create an object from a static class?
            //==============static class========
            //عباره عن كلاس تعتوي علي متغيرات او فنكشن من نوع استاتيك 
            //لا يمكن انشاء منها اي اوبجيكت
            //============================================================
            #endregion
            #region Q4  Extension Methods
            //a) What is an Extension Method?
            //عبارة عن طريقة  تخليك تضيف دالة جديدة لكلاس جاهز من غير ما تعدل في الكود الأصلي بتاعه ولا تورث منه
            //==================================================

            //b) What keyword must be used in the first parameter of an extension method?
            //=======this============
            //================================================

            //c) Where must an extension method be declared?
            //يعرف داحل استاتيك كلاس ويكون غير متداخل
            //==============================================

            //d) Can an extension method access private members of the class it extends?
            // لا== لانها تكتب خارج الكلاس الاصلي وبالتالي مش هنوف البرايفيت 
            #endregion
            #region Q5  Partial Classes and Partial Methods
            //a) What is a Partial Class?
            //بتخليك تقسم الكلاس اللي عندك علي عده ملفات ووقت الرن الكومبايلر بيتعامل معاهم علي انهم كلاس واحد
            //=======================================================

            //b) Why would a developer split one class into multiple files?
            //بتقسم الكود وبيكون سهل التعامل معاه 
            //سهوله العمل مع التيم
            //***************************************



            #endregion

            #region  Practical
            {
               // Console.WriteLine("==========================================");
               // Console.WriteLine("Smart Delivery Management System");
               // Console.WriteLine("==========================================");
               // Console.WriteLine();

               // Console.WriteLine("==========================================");
               // Console.WriteLine("Creating Shipments...");
               // Console.WriteLine("==========================================");
               // Console.WriteLine();

               // DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Naser St", 10);
               // DeliveryAddress addr2 = new DeliveryAddress("Alexandria", "Corniche St", 5);
               // DeliveryAddress addr3 = new DeliveryAddress("Giza", "Pyramids St", 12);

               // StandardShipment sh1 = new StandardShipment("SH001", "Standard", 3, 50m, addr1);
               // ExpressShipment sh2 = new ExpressShipment("SH002", "Express", 2, 80m, addr2, 20m);
               // InternationalShipment sh3 = new InternationalShipment("SH003", "International", 8, 200m, addr3, 100m, "Standard");

               // sh2.trackingStatus = "Out For Delivery";
               // sh3.trackingStatus = "Delivered";

               // Console.WriteLine();
               // Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
               // Console.WriteLine();

               // Console.WriteLine("==========================================");
               // Console.WriteLine("Object Copying");
               // Console.WriteLine("==========================================");
               // Console.WriteLine();

               // Shipment assignedShipment = sh1;
               // Console.WriteLine($"Original Shipment  : {sh1.trackingcode}");
               // Console.WriteLine($"Assigned Shipment  : {assignedShipment.trackingcode}");
               // Console.WriteLine();
               // Console.WriteLine($"Same Object : {Object.ReferenceEquals(sh1, assignedShipment)}");
               // Console.WriteLine();

               // Console.WriteLine("------------------------------------------");
               // Console.WriteLine("Shallow Copy");
               // Console.WriteLine("------------------------------------------");
               // Console.WriteLine();

               // DeliveryAddress shallowAddr = new DeliveryAddress("Cairo", "Naser St", 10);
               // StandardShipment origShallow = new StandardShipment("SH001", "Standard", 3, 50m, shallowAddr);
               // StandardShipment shallowCopy = (StandardShipment)origShallow.ShallowCopy();

               // Console.WriteLine($"Original Shipment Address : {origShallow.destination.city}");
               // Console.WriteLine($"Copied Shipment Address   : {shallowCopy.destination.city}");
               // Console.WriteLine();
               // Console.WriteLine("Changing copied shipment address...");
               // Console.WriteLine();
               // shallowCopy.destination = new DeliveryAddress("Giza", shallowCopy.destination.street, shallowCopy.destination.buildingNumber);

               // Console.WriteLine($"Original Shipment Address : {origShallow.destination.city}");
               // Console.WriteLine($"Copied Shipment Address   : {shallowCopy.destination.city}");
               // Console.WriteLine();
               // Console.WriteLine($"Same DeliveryAddress Object : {Object.ReferenceEquals(origShallow.destination, shallowCopy.destination)}");
               // Console.WriteLine();

               //;
               // Console.WriteLine("Deep Copy");
               // Console.WriteLine("------------------------------------------");
              
               // DeliveryAddress deepAddr = new DeliveryAddress("Cairo", "Naser St", 10);
               // StandardShipment origDeep = new StandardShipment("SH001", "Standard", 3, 50m, deepAddr);
               // StandardShipment deepCopy = (StandardShipment)origDeep.DeepCopy();

               // Console.WriteLine($"Original Shipment Address : {origDeep.destination.city}");
               // Console.WriteLine($"Copied Shipment Address   : {deepCopy.destination.city}");
               // Console.WriteLine();
               // Console.WriteLine("Changing copied shipment address");
               // Console.WriteLine();
               // deepCopy.destination = new DeliveryAddress("Giza", deepCopy.destination.street, deepCopy.destination.buildingNumber);

               // Console.WriteLine($"Original Shipment Address : {origDeep.destination.city}");
               // Console.WriteLine($"Copied Shipment Address   : {deepCopy.destination.city}");
               // Console.WriteLine();
               // Console.WriteLine($"Same DeliveryAddress Object : {Object.ReferenceEquals(origDeep.destination, deepCopy.destination)}");
               // Console.WriteLine();

               
               // Console.WriteLine("Extension Methods");
               // Console.WriteLine("===================");
               // Console.WriteLine();

               // Console.WriteLine(sh1.GetSummary());
               // Console.WriteLine(sh2.GetSummary());
               // Console.WriteLine(sh3.GetSummary());
               // Console.WriteLine();
               // Console.WriteLine($"SH001 Is Delivered : {sh1.IsDelivered()}");
               // Console.WriteLine($"SH003 Is Delivered : {sh3.IsDelivered()}");
               // Console.WriteLine();

               
               // Console.WriteLine("Tracking Status");
               
                

               // sh1.UpdateTrackingStatus("Out For Delivery");
               // Console.WriteLine();

               // Console.WriteLine("**********************************");
               // Console.WriteLine("Static Utilities");
               // Console.WriteLine("***********************************");
               // Console.WriteLine();
               // Console.WriteLine("*********************************");
               // Console.WriteLine("Delivery Center");
              
               // Console.WriteLine();
               // Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
               // Console.WriteLine();

               
               // Console.WriteLine("Partial Method");
               // Console.WriteLine("*****************************");
               // Console.WriteLine();

               // sh1.UpdateTrackingStatus("Delivered");
               // Console.WriteLine();

               // Console.WriteLine("Assignment Completed");
               
            }
        }
    }
}
            #endregion





