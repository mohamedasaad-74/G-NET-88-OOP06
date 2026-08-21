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



        }


    }
}