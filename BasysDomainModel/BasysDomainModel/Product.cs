﻿ 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = product
/// nsPrefix = product
/// nsURI = http://www.dfki.de/iui/basys/model/product
/// </summary>
namespace Basys.Model.Product
{

#region Classes

	/// <summary>
	
	/// besser ProductType?
	/// eClass = http://www.dfki.de/iui/basys/model/product#//ProductGroup
	/// </summary>
	public partial class ProductGroup : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/product#//ProductGroup"; } }

		public ProductGroup() : base()
		{		
		}

	}

	/// <summary>
	
	/// In BaSys braucht man wohl schon noch einen ProductType, dann sollte die Variante darauf verweisen. Braucht man hier eine BOM?
	/// eClass = http://www.dfki.de/iui/basys/model/product#//ProductVariant
	/// </summary>
	public partial class ProductVariant : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/product#//ProductVariant"; } }

		public ProductVariant() : base()
		{		
		}

		private string _name;
		/// <summary>
		/// name = name
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("name")]
		public string Name { get {return _name; } set { _name = value; } }

 		private string _productGroupId;
		/// <summary>
		/// name = productGroupId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productGroupId")]
		public string ProductGroupId { get {return _productGroupId; } set { _productGroupId = value; } }

 	}

	/// <summary>
	
	/// Eine auftragsbezogene, sich in der Fertigung befindliche oder gefertigte Instanz einer bestimmten Produktvariante.
	/// eClass = http://www.dfki.de/iui/basys/model/product#//ProductInstance
	/// </summary>
	public partial class ProductInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/product#//ProductInstance"; } }

		public ProductInstance() : base()
		{		
		}

		private string _productVariantId;
		/// <summary>
		/// name = productVariantId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productVariantId")]
		public string ProductVariantId { get {return _productVariantId; } set { _productVariantId = value; } }

 		private string _orderId;
		/// <summary>
		/// name = orderId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("orderId")]
		public string OrderId { get {return _orderId; } set { _orderId = value; } }

 		private string _serialNumber;
		/// <summary>
		/// name = serialNumber
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("serialNumber")]
		public string SerialNumber { get {return _serialNumber; } set { _serialNumber = value; } }

 	}

	/// <summary>
	
	/// kann am ProductLifecycleService abgefragt (getCurrentStatus/ getStatusHistory) werden und wird kontinuierlich als Event publiziert, sollte man noch den Ort aufnehmen?
	/// eClass = http://www.dfki.de/iui/basys/model/product#//ProductInstanceStatus
	/// </summary>
	public partial class ProductInstanceStatus : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/product#//ProductInstanceStatus"; } }

		public ProductInstanceStatus() : base()
		{		
		}

		private string _productInstanceId;
		/// <summary>
		/// name = productInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productInstanceId")]
		public string ProductInstanceId { get {return _productInstanceId; } set { _productInstanceId = value; } }

 		private ProductInstanceStatusEnum _status;
		/// <summary>
		/// name = status
		/// eType = #//ProductInstanceStatusEnum
		/// </summary>
		[JsonProperty("status")]
		public ProductInstanceStatusEnum Status { get {return _status; } set { _status = value; } }

 		private string _workstepInstanceId;
		/// <summary>
		/// name = workstepInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepInstanceId")]
		public string WorkstepInstanceId { get {return _workstepInstanceId; } set { _workstepInstanceId = value; } }

 	}

	/// <summary>
	
	/// Umbenennung ProductLocation? Kann diese Info auch am PLC-Dienst abgefragt werden? oder PromiseMonitoring?
	/// eClass = http://www.dfki.de/iui/basys/model/product#//ProductRecognition
	/// </summary>
	public partial class ProductRecognition : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/product#//ProductRecognition"; } }

		public ProductRecognition() : base()
		{		
		}

		private RecognitionEnum _eventType;
		/// <summary>
		/// name = eventType
		/// eType = #//RecognitionEnum
		/// </summary>
		[JsonProperty("eventType")]
		public RecognitionEnum EventType { get {return _eventType; } set { _eventType = value; } }

 		private string _productInstanceId;
		/// <summary>
		/// name = productInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productInstanceId")]
		public string ProductInstanceId { get {return _productInstanceId; } set { _productInstanceId = value; } }

 		private string _componentId;
		/// <summary>
		/// Verweis auf eine Station einer Linie, an der das Produkt ist oder von der sich das Produkt wegbewegt. Nicht das Ziel
		/// name = componentId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId")]
		public string ComponentId { get {return _componentId; } set { _componentId = value; } }

 	}


#endregion

#region EnumDefintions

	public enum RecognitionEnum
	{
		UNKNOWN = 0,
		PRESENT = 1,
		IN_TRANSIT = 2	
	}
	/// <summary>
	/// Weitere Literale? Verschmelzung mit OderStatusEnum?
	/// </summary>
	public enum ProductInstanceStatusEnum
	{
		UNKNOWN = 0,
		IN_PRODUCTION = 1,
		WAITING = 2,
		IN_TEST = 3,
		NIO = 4,
		IN_REPAIR = 5,
		IO = 6	
	}

#endregion

} //namespace
