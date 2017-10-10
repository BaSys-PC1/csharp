 
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
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//StaffRecognition
	/// </summary>
	public partial class StaffRecognition : Basys.Model.Base.Event
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//StaffRecognition"; } }

		public StaffRecognition() : base()
		{		
		}

		private StaffRecognitionEnum _type;
		/// <summary>
		/// name = type
		/// eType = #//StaffRecognitionEnum
		/// </summary>
		[JsonProperty("type")]
		public StaffRecognitionEnum Type { get {return _type; } set { _type = value; } }

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

 		private List<StaffSkill> _skills = new List<StaffSkill>();
		/// <summary>
		/// name = skills
		/// eType = #//StaffSkill
		/// </summary>
		[JsonProperty("skills")]
		public List<StaffSkill> Skills { get {return _skills; } set { _skills = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/staff#//StaffSkill
	/// </summary>
	public partial class StaffSkill
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/staff#//StaffSkill"; } }


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


#endregion

#region EnumDefintions

	public enum StaffRecognitionEnum
	{
		UNKNOWN = 0,
		PRESENT = 1,
		IN_TRANSIT = 2	
	}
	public enum PreferenceEnum
	{
		NEUTRAL = 0,
		POSITIVE = 1,
		NEGATIVE = -1	
	}

#endregion

} //namespace
