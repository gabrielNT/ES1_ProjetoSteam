﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamLibrary { 
    public class GameOfStore : Game
    {
	    private float price
	    {
		    get;
		    set;
	    }

	    private int unitSold
	    {
		    get;
		    set;
	    }

	    private int numberOfReviews
	    {
		    get;
		    set;
	    }

	    private float positiveReviewsPercentagem
	    {
		    get;    
		    set;
	    }

        //public virtual IEnumerable<GameReview> GameReview
        //{
        //    get;
        //    set;
        //}

	    public float getPrice()
	    {
		    return this.price;
	    }

	    public int getUnitSold()
	    {
            return this.unitSold;
	    }

	    private int getNumberOfReviews()
	    {
		    throw new System.NotImplementedException();
	    }

	    private float getPositiveReviesPercentage()
	    {
		    throw new System.NotImplementedException();
	    }

        public GameOfStore(int ID,float price, int unitsSold)
        {
            this.gameID = ID;
            this.price = price;
            this.unitSold = unitsSold;
            GetGameInformationFromDB();
        }
    }
}