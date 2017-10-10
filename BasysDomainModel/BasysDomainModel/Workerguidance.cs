 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = workerguidance
/// nsPrefix = workerguidance
/// nsURI = http://www.dfki.de/iui/basys/model/workerguidance
/// </summary>
namespace Basys.Model.Workerguidance
{

#region Classes

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Instruction
	/// </summary>
	public partial class Instruction : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Instruction"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Material
	/// </summary>
	public partial class Material : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Material"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Media
	/// </summary>
	public partial class Media : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Media"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Audio
	/// </summary>
	public partial class Audio : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Audio"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Video
	/// </summary>
	public partial class Video : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Video"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workerguidance#//Image
	/// </summary>
	public partial class Image : Media
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workerguidance#//Image"; } }

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


#endregion

#region EnumDefintions


#endregion

} //namespace
