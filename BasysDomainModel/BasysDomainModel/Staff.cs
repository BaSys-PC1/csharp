 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = staff
/// nsPrefix = staff
/// nsURI = http://www.dfki.de/iui/basys/model/staff
/// </summary>
namespace Basys.Model.Staff
{

#region Classes

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//Staff
	/// </summary>
	public partial class Staff : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//Staff"; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//StaffLocation
	/// </summary>
	public partial class StaffLocation : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//StaffLocation"; } }

		public StaffLocation() : base()
		{		
		}

		private StaffDetectionEnum _detectionType;
		/// <summary>
		/// name = detectionType
		/// eType = #//StaffDetectionEnum
		/// </summary>
		[JsonProperty("detectionType")]
		public StaffDetectionEnum DetectionType { get {return _detectionType; } set { _detectionType = value; } }

 		private string _staffid;
		/// <summary>
		/// workerId oder staffId?
		/// name = staffid
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("staffid")]
		public string Staffid { get {return _staffid; } set { _staffid = value; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//StaffLocationChangeEvent
	/// </summary>
	public partial class StaffLocationChangeEvent : StaffLocation
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//StaffLocationChangeEvent"; } }

		public StaffLocationChangeEvent() : base()
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

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//Ability
	/// </summary>
	public partial class Ability : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//Ability"; } }

		public Ability() : base()
		{		
		}

		private string _key;
		/// <summary>
		/// name = key
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("key")]
		public string Key { get {return _key; } set { _key = value; } }

 		private string _value;
		/// <summary>
		/// name = value
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("value")]
		public string Value { get {return _value; } set { _value = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//WorkstepSkill
	/// </summary>
	public partial class WorkstepSkill : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//WorkstepSkill"; } }

		public WorkstepSkill() : base()
		{		
		}

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

 		private WorkstepPreferenceEnum _preference;
		/// <summary>
		/// name = preference
		/// eType = #//WorkstepPreferenceEnum
		/// </summary>
		[JsonProperty("preference")]
		public WorkstepPreferenceEnum Preference { get {return _preference; } set { _preference = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//StaffSkills
	/// </summary>
	public partial class StaffSkills : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//StaffSkills"; } }

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

 		private List<WorkstepSkill> _workstepSkills = new List<WorkstepSkill>();
		/// <summary>
		/// name = workstepSkills
		/// eType = #//WorkstepSkill
		/// </summary>
		[JsonProperty("workstepSkills")]
		public List<WorkstepSkill> WorkstepSkills { get {return _workstepSkills; } set { _workstepSkills = value; } }

 		private List<Ability> _abilities = new List<Ability>();
		/// <summary>
		/// name = abilities
		/// eType = #//Ability
		/// </summary>
		[JsonProperty("abilities")]
		public List<Ability> Abilities { get {return _abilities; } set { _abilities = value; } }

 	}


#endregion

#region EnumDefintions

	public enum StaffDetectionEnum
	{
		UNKNOWN = 0,
		PRESENT = 1,
		IN_TRANSIT = 2	
	}
	public enum WorkstepPreferenceEnum
	{
		NEUTRAL = 0,
		POSITIVE = 1,
		NEGATIVE = -1	
	}

#endregion

} //namespace
