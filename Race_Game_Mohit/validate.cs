using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Game_Mohit
{
   public class validate
    {
        Random rd = new Random();
        //this is method to check the txtbox of the dog to check the value 
        public Boolean chkDog(int txt) {
                if (Convert.ToInt32(txt.ToString()) > 0 && Convert.ToInt32(txt.ToString()) < 5)
                {
                    return true;
                }
                else {
                    return false;
                }
        }


        //this is method to check the txtbox of the bet amount to check the value 
        public Boolean chkAmount(int txt)
        {
            if (Convert.ToInt32(txt.ToString()) > 0 && Convert.ToInt32(txt.ToString()) <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //gen no for running the dog 
        public int genNumber() {
            
            return rd.Next(1,30);
        }
        // this method is used to find the winner
        public int findWinner(int Location,int dog) {
            if (Location > 430)
            {
              
                return dog;
            }
            else {
                return 0;
            }
        }



    }
}
