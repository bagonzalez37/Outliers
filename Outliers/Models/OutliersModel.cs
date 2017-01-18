using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Outliers.Models
{
    public class OutliersModel
    {
        class Player
        {
            public string FirstName { get; set; }  
            public string LastName { get; set; }
            public string FavoriteFood { get; set; }
            public int SiblingCount { get; set; }
            public int MaxBench { get; set; }
            public int FreckleCount { get; set; }
            public float StrideLength { get; set; }
            public float BicepWidth { get; set; }
            public float JockstrapSize { get; set; }
            public float ShoeSize { get; set; }
            public float JumpHeight { get; set; }

            public Player()
            {
                this.FirstName = "Sharktooth";
                this.LastName = "O'Shannigan";
                this.FavoriteFood = null;
                this.MaxBench = 0;
                this.SiblingCount = 0;
                this.MaxBench = 0;
                this.FreckleCount = 0;
                this.StrideLength = 0.0f;
                this.BicepWidth = 0.0f;
                this.JockstrapSize = 0.0f;
                this.ShoeSize = 0.0f;
                this.JumpHeight = 0.0f;

            }

            public Player(string firstName, string lastName, string favoriteFood, int siblingCount, int maxBench, int freckleCount,
                float strideLength, float bicepWidth, float jockstrapSize, float shoeSize, float jumpHeight)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.FavoriteFood = favoriteFood;
                this.SiblingCount = siblingCount;
                this.MaxBench = maxBench;
                this.FreckleCount = freckleCount;
                this.StrideLength = strideLength;
                this.BicepWidth = bicepWidth;
                this.JockstrapSize = jockstrapSize;
                this.ShoeSize = shoeSize;
                this.JumpHeight = jumpHeight;
            }
            
        }
       
    }
}