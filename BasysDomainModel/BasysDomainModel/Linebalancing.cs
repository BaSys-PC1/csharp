 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = linebalancing
/// nsPrefix = linebalancing
/// nsURI = http://www.dfki.de/iui/basys/model/linebalancing
/// </summary>
namespace Basys.Model.Linebalancing
{

#region Classes

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/linebalancing#//LBProductInstance
	/// </summary>
	public partial class LBProductInstance : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/linebalancing#//LBProductInstance"; } }

		public LBProductInstance() : base()
		{		
		}

		private string _componentId;
		/// <summary>
		/// name = componentId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId")]
		public string ComponentId { get {return _componentId; } set { _componentId = value; } }

 		private string _workstepInstanceId;
		/// <summary>
		/// name = workstepInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("workstepInstanceId")]
		public string WorkstepInstanceId { get {return _workstepInstanceId; } set { _workstepInstanceId = value; } }

 		private long _remainingTime;
		/// <summary>
		/// name = remainingTime
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//ELong
		/// </summary>
		[JsonProperty("remainingTime")]
		public long RemainingTime { get {return _remainingTime; } set { _remainingTime = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/linebalancing#//LBStaff
	/// </summary>
	public partial class LBStaff : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/linebalancing#//LBStaff"; } }

		public LBStaff() : base()
		{		
		}

		private string _assignment;
		/// <summary>
		/// name = assignment
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("assignment")]
		public string Assignment { get {return _assignment; } set { _assignment = value; } }

 		private string _componentId_src;
		/// <summary>
		/// name = componentId_src
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId_src")]
		public string ComponentId_src { get {return _componentId_src; } set { _componentId_src = value; } }

 		private string _componentId_target;
		/// <summary>
		/// name = componentId_target
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("componentId_target")]
		public string ComponentId_target { get {return _componentId_target; } set { _componentId_target = value; } }

 		private string _currentProductInstanceId;
		/// <summary>
		/// name = currentProductInstanceId
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("currentProductInstanceId")]
		public string CurrentProductInstanceId { get {return _currentProductInstanceId; } set { _currentProductInstanceId = value; } }

 		private long _remainingMovementTime;
		/// <summary>
		/// name = remainingMovementTime
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//ELong
		/// </summary>
		[JsonProperty("remainingMovementTime")]
		public long RemainingMovementTime { get {return _remainingMovementTime; } set { _remainingMovementTime = value; } }

 	}


#endregion

#region EnumDefintions


#endregion

} //namespace
