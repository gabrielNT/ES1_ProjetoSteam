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

public class ShoppingCart
{
	private int ID
	{
		get;
		set;
	}

	private int NumberOfGames
	{
		get;
		set;
	}

	private float totalPrice
	{
		get;
		set;
	}

	public virtual IEnumerable<GameOfStore> GameOfStore
	{
		get;
		set;
	}

	public virtual int getID()
	{
		throw new System.NotImplementedException();
	}

	public virtual float getTotalPrice()
	{
		throw new System.NotImplementedException();
	}

	public virtual int getNumberOfGames()
	{
		throw new System.NotImplementedException();
	}

	public ShoppingCart(int userID)
	{
	}

	public virtual void confirmCart()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool insertIntoCart(int gameID)
	{
		throw new System.NotImplementedException();
	}

	public virtual GameOfStore[] getGameList()
	{
		throw new System.NotImplementedException();
	}

}

