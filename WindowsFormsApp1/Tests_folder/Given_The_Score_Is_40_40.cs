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
    [TestFixture]
    public class Given_The_Score_Is_40_40
    {

        [Test]
        public void When_The_Server_Wins_A_Point()
        {
            int result1 = 40;
            int result2 = 40;
            Form1 point = new Form1();
            //act

            string result = point.pointForServer();

            //assert
            Assert.AreEqual(result, "A");
        }

        [Test]
        public static void When_The_Reciever_Wins_A_Point()
        {
            //arrange
            int result1 = 40;
            int result2 = 40;
            Form1 point = new Form1();

            //act

            string result = point.pointForReciever();

            //assert
            Assert.AreEqual(result, "A");


        }
    }

}
