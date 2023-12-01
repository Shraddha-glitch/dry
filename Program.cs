//************************Without DRY*********************



// using System;
// using System.Net.NetworkInformation;
// namespace WithoutDryDemo{
//     public class WithoutDry{
//         static void Main(){
//             String username1="Jung";
//             if (username1.Length<5){
//                 System.Console.WriteLine("Username must be at least 5 characters long");
//             }
//             String username2="Shraddha";
//             if (username2.Length<5){
//                 System.Console.WriteLine("Username must be at least 5 characters long");
//             }
//             else {
//                 System.Console.WriteLine("Username saved successfully!!");
//             }
//         }
//     }
// }


//************************With DRY*********************
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
namespace WithoutDryDemo{
    public class WithoutDry{

         public static bool IsValidateUsername(String username){
               return username.Length>=5;
            }

        static void Main(){
            String username1="John";

            if (!IsValidateUsername(username1)){
                System.Console.WriteLine(username1+ " " +"Username must be at least 5 characters long");
            }

            String username2="Shraddha";
            if (!IsValidateUsername(username2)){
                System.Console.WriteLine(username2+ " " +"Username must be at least 5 characters long");
            }
            else {
                System.Console.WriteLine("Username saved successfully!!"+ " : "+ username2);
            }
        }
    }
}

