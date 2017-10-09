 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = domain
/// nsPrefix = domain
/// nsURI = http://www.dfki.de/iui/basys/domain
/// </summary>
namespace Basys.Model.Domain
{

#region Classes

	/// <summary>
	
	/// TODO
	/// eClass = http://www.dfki.de/iui/basys/domain#//DynamicLineBalancingResult
	/// </summary>
	public partial class DynamicLineBalancingResult
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//DynamicLineBalancingResult"; } }


	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Instruction
	/// </summary>
	public partial class Instruction : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Instruction"; } }

		public Instruction() : base()
		{		
		}

		private string _description;
		/// <summary>
		/// loc
		/// name = description
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("description")]
		public string Description { get {return _description; } set { _description = value; } }

 		private List<string> _parameters = new List<string>();
		/// <summary>
		/// name = parameters
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("parameters")]
		public List<string> Parameters { get {return _parameters; } set { _parameters = value; } }

 		private List<string> _workstepIds = new List<string>();
		/// <summary>
		/// Verknüpfung einer Instruktion mit einem der mehreren Worksteps
		/// name = workstepIds
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepIds")]
		public List<string> WorkstepIds { get {return _workstepIds; } set { _workstepIds = value; } }

 	}

	/// <summary>
	
	/// TODO
	/// eClass = http://www.dfki.de/iui/basys/domain#//Line
	/// </summary>
	public partial class Line
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Line"; } }


	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Material
	/// </summary>
	public partial class Material : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Material"; } }

		public Material() : base()
		{		
		}

		private string _name;
		/// <summary>
		/// loc, kann die Industrie die Lokalisierung liefern, oder müssen wir einen Lokalisierungsdienst vorsehen?
		/// name = name
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("name")]
		public string Name { get {return _name; } set { _name = value; } }

 	}

	/// <summary>
	
	/// Abgleich mit Standardmodellierungen
	/// eClass = http://www.dfki.de/iui/basys/domain#//Media
	/// </summary>
	public partial class Media : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Media"; } }

		public Media() : base()
		{		
		}

		private string _type;
		/// <summary>
		/// MimeTypeEnum?
		/// name = type
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("type")]
		public string Type { get {return _type; } set { _type = value; } }

 		private int _fileSize;
		/// <summary>
		/// Einheit?
		/// name = fileSize
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("fileSize")]
		public int FileSize { get {return _fileSize; } set { _fileSize = value; } }

 		private string _checksum;
		/// <summary>
		/// macht nur Sinn, wenn Media-Instanz auf genau eine physische Datei zeigt.
		/// name = checksum
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("checksum")]
		public string Checksum { get {return _checksum; } set { _checksum = value; } }

 		private string _location;
		/// <summary>
		/// name = location
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("location")]
		public string Location { get {return _location; } set { _location = value; } }

 		private string _entityType;
		/// <summary>
		/// Bestimmt, auf welche Art Entity sich der Content bezieht: Resource, Material, Instruction, ..., ggf. über entityIds regeln
		/// name = entityType
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("entityType")]
		public string EntityType { get {return _entityType; } set { _entityType = value; } }

 		private List<string> _entityIds = new List<string>();
		/// <summary>
		/// Bestimmt, auf welchen Typ sich der Content bezieht, z.B. Ressource vom Typ Nexo Schrauber, ggf. Attributnamen anpassen
		/// name = entityIds
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("entityIds")]
		public List<string> EntityIds { get {return _entityIds; } set { _entityIds = value; } }

 		private List<string> _tags = new List<string>();
		/// <summary>
		/// evtl. braucht man noch zusätzliche Informationen, um den Inhalt näher zu charakterisieren und einen Mechanismus zur Präsentationsplanung
		/// name = tags
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("tags")]
		public List<string> Tags { get {return _tags; } set { _tags = value; } }

 		private string _locale;
		/// <summary>
		/// name = locale
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("locale")]
		public string Locale { get {return _locale; } set { _locale = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Audio
	/// </summary>
	public partial class Audio : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Audio"; } }

		public Audio() : base()
		{		
		}

		private int _duration;
		/// <summary>
		/// Einheit?
		/// name = duration
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("duration")]
		public int Duration { get {return _duration; } set { _duration = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Video
	/// </summary>
	public partial class Video : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Video"; } }

		public Video() : base()
		{		
		}

		private int _duration;
		/// <summary>
		/// Einheit?
		/// name = duration
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("duration")]
		public int Duration { get {return _duration; } set { _duration = value; } }

 		private int _width;
		/// <summary>
		/// Einheit? int, implitzit px
		/// name = width
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("width")]
		public int Width { get {return _width; } set { _width = value; } }

 		private int _height;
		/// <summary>
		/// Einheit?
		/// name = height
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("height")]
		public int Height { get {return _height; } set { _height = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Image
	/// </summary>
	public partial class Image : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Image"; } }

		public Image() : base()
		{		
		}

		private int _width;
		/// <summary>
		/// Einheit? int, implitzit px
		/// name = width
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("width")]
		public int Width { get {return _width; } set { _width = value; } }

 		private int _height;
		/// <summary>
		/// Einheit?
		/// name = height
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("height")]
		public int Height { get {return _height; } set { _height = value; } }

 	}

	/// <summary>
	
	/// Pro Order nur eine Variante? Mehrere Teile können in mehrere Orders aufgeteilt werden, tdb
	/// eClass = http://www.dfki.de/iui/basys/domain#//Order
	/// </summary>
	public partial class Order : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Order"; } }

		public Order() : base()
		{		
		}

		private string _variantId;
		/// <summary>
		/// name = variantId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("variantId")]
		public string VariantId { get {return _variantId; } set { _variantId = value; } }

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

 	}

	/// <summary>
	
	/// Unterschied zu OrderProgressChange? braucht man noch ein OrderStatusChange? Kann man das verschmelzen? -> ja, unterscheidung über Topics
	/// eClass = http://www.dfki.de/iui/basys/domain#//OrderStatus
	/// </summary>
	public partial class OrderStatus : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//OrderStatus"; } }

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
	
	/// besser ProductType?
	/// eClass = http://www.dfki.de/iui/basys/domain#//ProductGroup
	/// </summary>
	public partial class ProductGroup : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ProductGroup"; } }

		public ProductGroup() : base()
		{		
		}

	}

	/// <summary>
	
	/// In BaSys braucht man wohl schon noch einen ProductType, dann sollte die Variante darauf verweisen. Braucht man hier eine BOM?
	/// eClass = http://www.dfki.de/iui/basys/domain#//ProductVariant
	/// </summary>
	public partial class ProductVariant : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ProductVariant"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/domain#//ProductInstance
	/// </summary>
	public partial class ProductInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ProductInstance"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/domain#//ProductInstanceStatus
	/// </summary>
	public partial class ProductInstanceStatus : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ProductInstanceStatus"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/domain#//ProductRecognition
	/// </summary>
	public partial class ProductRecognition : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ProductRecognition"; } }

		public ProductRecognition() : base()
		{		
		}

		private RecognitionEnum _type;
		/// <summary>
		/// name = type
		/// eType = #//RecognitionEnum
		/// </summary>
		[JsonProperty("type")]
		public RecognitionEnum Type { get {return _type; } set { _type = value; } }

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

	/// <summary>
	
	/// ResourceInstance?
	/// eClass = http://www.dfki.de/iui/basys/domain#//ResourceInstance
	/// </summary>
	public partial class ResourceInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//ResourceInstance"; } }

		public ResourceInstance() : base()
		{		
		}

		private string _name;
		/// <summary>
		/// loc
		/// name = name
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("name")]
		public string Name { get {return _name; } set { _name = value; } }

 		private string _type;
		/// <summary>
		/// Verknüpfung mit ResourceType -> VS, Fähigkeitenmodellierung, etc.
		/// name = type
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("type")]
		public string Type { get {return _type; } set { _type = value; } }

 		private string _properties;
		/// <summary>
		/// TODO, je nach Typ steht hier was anderes drin.
		/// name = properties
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("properties")]
		public string Properties { get {return _properties; } set { _properties = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Staff
	/// </summary>
	public partial class Staff : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Staff"; } }

		public Staff() : base()
		{		
		}

		private string _firstname;
		/// <summary>
		/// Was schreibt man hier bei anonymisierten Werkern hin?
		/// name = firstname
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("firstname")]
		public string Firstname { get {return _firstname; } set { _firstname = value; } }

 		private string _lastname;
		/// <summary>
		/// name = lastname
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("lastname")]
		public string Lastname { get {return _lastname; } set { _lastname = value; } }

 		private DateTime _birthdate;
		/// <summary>
		/// name = birthdate
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("birthdate")]
		public DateTime Birthdate { get {return _birthdate; } set { _birthdate = value; } }

 		private string _language;
		/// <summary>
		/// name = language
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("language")]
		public string Language { get {return _language; } set { _language = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//StaffRecognition
	/// </summary>
	public partial class StaffRecognition : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//StaffRecognition"; } }

		public StaffRecognition() : base()
		{		
		}

		private RecognitionEnum _type;
		/// <summary>
		/// name = type
		/// eType = #//RecognitionEnum
		/// </summary>
		[JsonProperty("type")]
		public RecognitionEnum Type { get {return _type; } set { _type = value; } }

 		private string _workerId;
		/// <summary>
		/// workerId oder staffId?
		/// name = workerId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workerId")]
		public string WorkerId { get {return _workerId; } set { _workerId = value; } }

 		private string _componentId;
		/// <summary>
		/// Verweis auf eine Station einer Linie
		/// name = componentId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId")]
		public string ComponentId { get {return _componentId; } set { _componentId = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//StaffSkills
	/// </summary>
	public partial class StaffSkills : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//StaffSkills"; } }

		public StaffSkills() : base()
		{		
		}

		private string _workerId;
		/// <summary>
		/// workerId oder staffId?
		/// name = workerId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workerId")]
		public string WorkerId { get {return _workerId; } set { _workerId = value; } }

 		private List<StaffSkill> _skills = new List<StaffSkill>();
		/// <summary>
		/// name = skills
		/// eType = #//StaffSkill
		/// </summary>
		[JsonProperty("skills")]
		public List<StaffSkill> Skills { get {return _skills; } set { _skills = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//StaffSkill
	/// </summary>
	public partial class StaffSkill
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//StaffSkill"; } }


		private string _workstepId;
		/// <summary>
		/// name = workstepId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepId")]
		public string WorkstepId { get {return _workstepId; } set { _workstepId = value; } }

 		private int _level;
		/// <summary>
		/// 0 - 100
		/// name = level
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("level")]
		public int Level { get {return _level; } set { _level = value; } }

 		private PreferenceEnum _preference;
		/// <summary>
		/// name = preference
		/// eType = #//PreferenceEnum
		/// </summary>
		[JsonProperty("preference")]
		public PreferenceEnum Preference { get {return _preference; } set { _preference = value; } }

 	}

	/// <summary>
	
	/// ggf. BPMN, CMMN oder sonstige Taskmodelle. Die Ausdrucksmächtigkeit sollte Sequenzen und Vorranggraphen umfassen
	/// eClass = http://www.dfki.de/iui/basys/domain#//Workplan
	/// </summary>
	public partial class Workplan : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Workplan"; } }

		public Workplan() : base()
		{		
		}

		private string _productVariantId;
		/// <summary>
		/// name = productVariantId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productVariantId")]
		public string ProductVariantId { get {return _productVariantId; } set { _productVariantId = value; } }

 		private List<string> _workstepIds = new List<string>();
		/// <summary>
		/// TODO: Vorbedingungen sind noch nicht abbildbar. In den JSONs werden hier Ids angegeben. Kann ein Workstep in mehreren Arbeitsplänen verwendet werden?-> ja
		/// name = workstepIds
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepIds")]
		public List<string> WorkstepIds { get {return _workstepIds; } set { _workstepIds = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//Workstep
	/// </summary>
	public partial class Workstep : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//Workstep"; } }

		public Workstep() : base()
		{		
		}

		private string _name;
		/// <summary>
		/// loc
		/// name = name
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("name")]
		public string Name { get {return _name; } set { _name = value; } }

 		private int _duration;
		/// <summary>
		/// Einheit?
		/// name = duration
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("duration")]
		public int Duration { get {return _duration; } set { _duration = value; } }

 		private BOM _bom;
		/// <summary>
		/// name = bom
		/// eType = #//BOM
		/// </summary>
		[JsonProperty("bom")]
		public BOM Bom { get {return _bom; } set { _bom = value; } }

 		private List<CapabilityRequirement> _requirements = new List<CapabilityRequirement>();
		/// <summary>
		/// Wird mit den Fähigkeiten der Betriebsmittel abgeglichen
		/// name = requirements
		/// eType = #//CapabilityRequirement
		/// </summary>
		[JsonProperty("requirements")]
		public List<CapabilityRequirement> Requirements { get {return _requirements; } set { _requirements = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//CapabilityRequirement
	/// </summary>
	public partial class CapabilityRequirement
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//CapabilityRequirement"; } }


	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//BOM
	/// </summary>
	public partial class BOM
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//BOM"; } }


		private List<BOMEntry> _entries = new List<BOMEntry>();
		/// <summary>
		/// name = entries
		/// eType = #//BOMEntry
		/// </summary>
		[JsonProperty("entries")]
		public List<BOMEntry> Entries { get {return _entries; } set { _entries = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//BOMEntry
	/// </summary>
	public partial class BOMEntry
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//BOMEntry"; } }


		private int _amount;
		/// <summary>
		/// Einheit ggf. gesondert spezifizieren. Wir betrachten hier erstmal nur 'Stück'
		/// name = amount
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("amount")]
		public int Amount { get {return _amount; } set { _amount = value; } }

 		private string _materialId;
		/// <summary>
		/// name = materialId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("materialId")]
		public string MaterialId { get {return _materialId; } set { _materialId = value; } }

 	}

	/// <summary>
	
	/// Zuordnung Arbeitsschritt -> Betriebsmittel
	/// eClass = http://www.dfki.de/iui/basys/domain#//WorkstepInstance
	/// </summary>
	public partial class WorkstepInstance
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//WorkstepInstance"; } }


		private string _workstepId;
		/// <summary>
		/// name = workstepId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepId")]
		public string WorkstepId { get {return _workstepId; } set { _workstepId = value; } }

 		private List<string> _resourceInstanceIds = new List<string>();
		/// <summary>
		/// name = resourceInstanceIds
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("resourceInstanceIds")]
		public List<string> ResourceInstanceIds { get {return _resourceInstanceIds; } set { _resourceInstanceIds = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/domain#//TemperatureReading
	/// </summary>
	public partial class TemperatureReading
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/domain#//TemperatureReading"; } }


		private float _measuredValue;
		/// <summary>
		/// name = measuredValue
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EFloat
		/// </summary>
		[JsonProperty("measuredValue")]
		public float MeasuredValue { get {return _measuredValue; } set { _measuredValue = value; } }

 	}


#endregion

#region EnumDefintions

	public enum RecognitionEnum
	{
		PRESENT = 0,
		IN_TRANSIT = 1	
	}
	public enum PreferenceEnum
	{
		NEUTRAL = 0,
		POSITIVE = 1,
		NEGATIVE = -1	
	}
	/// <summary>
	/// Weitere Literale?
	/// </summary>
	public enum OrderStatusEnum
	{
		PLANNED = 0,
		STARTED = 1,
		PAUSED = 2,
		COMPLETED = 3,
		ABORTED = 4	
	}
	/// <summary>
	/// Weitere Literale? Verschmelzung mit OderStatusEnum?
	/// </summary>
	public enum ProductInstanceStatusEnum
	{
		IN_PRODUCTION = 0,
		IN_TEST = 1,
		NIO = 2,
		IN_REPAIR = 3,
		IO = 4	
	}

#endregion

} //namespace
