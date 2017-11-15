 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = order
/// nsPrefix = order
/// nsURI = http://www.dfki.de/iui/basys/model/order
/// </summary>
namespace Basys.Model.Order
{

#region Classes

	/// <summary>
	
	/// Pro Order nur eine Variante? Mehrere Teile können in mehrere Orders aufgeteilt werden, tdb
	/// eClass = http://www.dfki.de/iui/basys/model/order#//Order
	/// </summary>
	public partial class Order : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/order#//Order"; } }

		public Order() : base()
		{		
		}

		private string _productVariantId;
		/// <summary>
		/// name = productVariantId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productVariantId")]
		public string ProductVariantId { get {return _productVariantId; } set { _productVariantId = value; } }

 		private DateTime _startDate;
		/// <summary>
		/// reales Startdatum
		/// name = startDate
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("startDate")]
		public DateTime StartDate { get {return _startDate; } set { _startDate = value; } }

 		private DateTime _endDate;
		/// <summary>
		/// reales Enddatum
		/// name = endDate
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("endDate")]
		public DateTime EndDate { get {return _endDate; } set { _endDate = value; } }

 		private int _pieces;
		/// <summary>
		/// name = pieces
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("pieces")]
		public int Pieces { get {return _pieces; } set { _pieces = value; } }

 		private int _priority;
		/// <summary>
		/// als Enum modelliert. Ok? listennummer
		/// name = priority
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("priority")]
		public int Priority { get {return _priority; } set { _priority = value; } }

 		private OrderStatus _status;
		/// <summary>
		/// name = status
		/// eType = #//OrderStatus
		/// </summary>
		[JsonProperty("status")]
		public OrderStatus Status { get {return _status; } set { _status = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/order#//OrderStatus
	/// </summary>
	public partial class OrderStatus : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/order#//OrderStatus"; } }

		public OrderStatus() : base()
		{		
		}

		private string _orderId;
		/// <summary>
		/// name = orderId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("orderId")]
		public string OrderId { get {return _orderId; } set { _orderId = value; } }

 		private OrderStatusEnum _status;
		/// <summary>
		/// name = status
		/// eType = #//OrderStatusEnum
		/// </summary>
		[JsonProperty("status")]
		public OrderStatusEnum Status { get {return _status; } set { _status = value; } }

 		private int _pieceCount;
		/// <summary>
		/// name = pieceCount
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("pieceCount")]
		public int PieceCount { get {return _pieceCount; } set { _pieceCount = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/order#//OrderStatusChangeEvent
	/// </summary>
	public partial class OrderStatusChangeEvent : OrderStatus
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/order#//OrderStatusChangeEvent"; } }

		public OrderStatusChangeEvent() : base()
		{		
		}

		private DateTime _timestamp;
		/// <summary>
		/// name = timestamp
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("timestamp")]
		public DateTime Timestamp { get {return _timestamp; } set { _timestamp = value; } }

 	}


#endregion

#region EnumDefintions

	/// <summary>
	/// Weitere Literale?
	/// </summary>
	public enum OrderStatusEnum
	{
		UNKNOWN = 0,
		PLANNED = 1,
		STARTED = 2,
		PAUSED = 3,
		COMPLETED = 4,
		ABORTED = 5	
	}

#endregion

} //namespace
