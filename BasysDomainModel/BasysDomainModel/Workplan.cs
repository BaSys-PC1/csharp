 
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

 		private string _componentId;
		/// <summary>
		/// name = componentId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId")]
		public string ComponentId { get {return _componentId; } set { _componentId = value; } }

 		private bool _isAutomatic;
		/// <summary>
		/// name = isAutomatic
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EBoolean
		/// </summary>
		[JsonProperty("isAutomatic")]
		public bool IsAutomatic { get {return _isAutomatic; } set { _isAutomatic = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceStatus
	/// </summary>
	public partial class WorkstepInstanceStatus : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceStatus"; } }

		public WorkstepInstanceStatus() : base()
		{		
		}

		private WorkstepInstanceStatusEnum _status;
		/// <summary>
		/// name = status
		/// eType = #//WorkstepInstanceStatusEnum
		/// </summary>
		[JsonProperty("status")]
		public WorkstepInstanceStatusEnum Status { get {return _status; } set { _status = value; } }

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
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceStatusChangeEvent
	/// </summary>
	public partial class WorkstepInstanceStatusChangeEvent : WorkstepInstanceStatus
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//WorkstepInstanceStatusChangeEvent"; } }

		public WorkstepInstanceStatusChangeEvent() : base()
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
	/// eClass = http://www.dfki.de/iui/basys/model/workplan#//Duration
	/// </summary>
	public partial class Duration : Basys.Model.Base.Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/workplan#//Duration"; } }

		public Duration() : base()
		{		
		}

		private string _workstepInstanceId;
		/// <summary>
		/// name = workstepInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepInstanceId")]
		public string WorkstepInstanceId { get {return _workstepInstanceId; } set { _workstepInstanceId = value; } }

 		private string _agentId;
		/// <summary>
		/// name = agentId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("agentId")]
		public string AgentId { get {return _agentId; } set { _agentId = value; } }

 		private double _average;
		/// <summary>
		/// name = average
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDouble
		/// </summary>
		[JsonProperty("average")]
		public double Average { get {return _average; } set { _average = value; } }

 		private double _standardDeviation;
		/// <summary>
		/// name = standardDeviation
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDouble
		/// </summary>
		[JsonProperty("standardDeviation")]
		public double StandardDeviation { get {return _standardDeviation; } set { _standardDeviation = value; } }

 	}


#endregion

#region EnumDefintions

	public enum WorkstepInstanceStatusEnum
	{
		UNKNOWN = 0,
		STARTED = 1,
		PAUSED = 2,
		REPEATING = 3,
		FINISHED = 4,
		ABORTED = 5,
		RESUMED = 6	
	}

#endregion

} //namespace
