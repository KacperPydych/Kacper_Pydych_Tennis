using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests_folder
{
    
    public class Given_The_Score_Is_40_30
    {

        [Test]
        public static void When_The_Server_Wins_A_Point()
        {
            //arrange
            int result1 = 40;
            int result2 = 30;
            Form1 point = new Form1();
            
            //act

            string winner = point.pointForServer();

            //assert
            Assert.AreEqual(winner, "Server");

           
        }
    }

}    
