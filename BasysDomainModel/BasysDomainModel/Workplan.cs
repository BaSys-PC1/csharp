 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = workplan
/// nsPrefix = workplan
/// nsURI = http://www.dfki.de/iui/basys/model/workplan
/// </summary>
namespace Basys.Model.Workplan
{

#region Classes

	/// <summary>
	
	/// ggf. BPMN, CMMN oder sonstige Taskmodelle. Die Ausdrucksmächtigkeit sollte Sequenzen und Vorranggraphen umfassen
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//WorkplanInstance
	/// </summary>
	public partial class WorkplanInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//WorkplanInstance"; } }

		public WorkplanInstance() : base()
		{		
		}

		private string _productInstanceId;
		/// <summary>
		/// name = productInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productInstanceId")]
		public string ProductInstanceId { get {return _productInstanceId; } set { _productInstanceId = value; } }

 		private List<WorkstepInstance> _workstepInstances = new List<WorkstepInstance>();
		/// <summary>
		/// name = workstepInstances
		/// eType = #//WorkstepInstance
		/// </summary>
		[JsonProperty("workstepInstances")]
		public List<WorkstepInstance> WorkstepInstances { get {return _workstepInstances; } set { _workstepInstances = value; } }

 	}

	/// <summary>
	
	/// Zuordnung Arbeitsschritt -> Betriebsmittel
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstance
	/// </summary>
	public partial class WorkstepInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstance"; } }

		public WorkstepInstance() : base()
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

 		private string _stationId;
		/// <summary>
		/// name = stationId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("stationId")]
		public string StationId { get {return _stationId; } set { _stationId = value; } }

 		private bool _isAutomatic;
		/// <summary>
		/// name = isAutomatic
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EBoolean
		/// </summary>
		[JsonProperty("isAutomatic")]
		public bool IsAutomatic { get {return _isAutomatic; } set { _isAutomatic = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceChangeEvent
	/// </summary>
	public partial class WorkstepInstanceChangeEvent : Basys.Model.Base.Event
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceChangeEvent"; } }

		public WorkstepInstanceChangeEvent() : base()
		{		
		}

		private WorkstepInstanceChangeType _type;
		/// <summary>
		/// name = type
		/// eType = #//WorkstepInstanceChangeType
		/// </summary>
		[JsonProperty("type")]
		public WorkstepInstanceChangeType Type { get {return _type; } set { _type = value; } }

 		private string _productInstanceId;
		/// <summary>
		/// name = productInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("productInstanceId")]
		public string ProductInstanceId { get {return _productInstanceId; } set { _productInstanceId = value; } }

 		private string _workstepInstanceId;
		/// <summary>
		/// name = workstepInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepInstanceId")]
		public string WorkstepInstanceId { get {return _workstepInstanceId; } set { _workstepInstanceId = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//Duration
	/// </summary>
	public partial class Duration
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//Duration"; } }


		private string _workstepInstanceId;
		/// <summary>
		/// name = workstepInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepInstanceId")]
		public string WorkstepInstanceId { get {return _workstepInstanceId; } set { _workstepInstanceId = value; } }

 		private int _beginnerLevel;
		/// <summary>
		/// name = beginnerLevel
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("beginnerLevel")]
		public int BeginnerLevel { get {return _beginnerLevel; } set { _beginnerLevel = value; } }

 		private int _beginnerLevelDeviance;
		/// <summary>
		/// name = beginnerLevelDeviance
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("beginnerLevelDeviance")]
		public int BeginnerLevelDeviance { get {return _beginnerLevelDeviance; } set { _beginnerLevelDeviance = value; } }

 		private int _expertLevel;
		/// <summary>
		/// name = expertLevel
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("expertLevel")]
		public int ExpertLevel { get {return _expertLevel; } set { _expertLevel = value; } }

 		private int _expertLevelDeviance;
		/// <summary>
		/// name = expertLevelDeviance
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("expertLevelDeviance")]
		public int ExpertLevelDeviance { get {return _expertLevelDeviance; } set { _expertLevelDeviance = value; } }

 	}


#endregion

#region EnumDefintions

	public enum WorkstepInstanceChangeType
	{
		UNKNOWN = 0,
		STARTED = 1,
		PAUSED = 2,
		REPEATING = 3,
		FINISHED = 4,
		ABORTED = 5	
	}

#endregion

} //namespace
