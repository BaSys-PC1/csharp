 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = topology
/// nsPrefix = topology
/// nsURI = http://www.dfki.de/iui/basys/model/topology
/// </summary>
namespace Basys.Model.Topology
{

#region Classes

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Enterprise
	/// </summary>
	public partial class Enterprise : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Enterprise"; } }

		public Enterprise() : base()
		{		
		}

		private List<Site> _sites = new List<Site>();
		/// <summary>
		/// name = sites
		/// eType = #//Site
		/// </summary>
		[JsonProperty("sites")]
		public List<Site> Sites { get {return _sites; } set { _sites = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Site
	/// </summary>
	public partial class Site : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Site"; } }

		public Site() : base()
		{		
		}

		private List<Area> _areas = new List<Area>();
		/// <summary>
		/// name = areas
		/// eType = #//Area
		/// </summary>
		[JsonProperty("areas")]
		public List<Area> Areas { get {return _areas; } set { _areas = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Area
	/// </summary>
	public partial class Area : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Area"; } }

		public Area() : base()
		{		
		}

		private WorkCenter _workCenters;
		/// <summary>
		/// name = workCenters
		/// eType = #//WorkCenter
		/// </summary>
		[JsonProperty("workCenters")]
		public WorkCenter WorkCenters { get {return _workCenters; } set { _workCenters = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//WorkCenter
	/// </summary>
	public abstract partial class WorkCenter : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//WorkCenter"; } }

		public WorkCenter() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ProcessCell
	/// </summary>
	public partial class ProcessCell : WorkCenter
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ProcessCell"; } }

		public ProcessCell() : base()
		{		
		}

		private List<Unit> _units = new List<Unit>();
		/// <summary>
		/// name = units
		/// eType = #//Unit
		/// </summary>
		[JsonProperty("units")]
		public List<Unit> Units { get {return _units; } set { _units = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ProductionUnit
	/// </summary>
	public partial class ProductionUnit : WorkCenter
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ProductionUnit"; } }

		public ProductionUnit() : base()
		{		
		}

		private List<Unit> _units = new List<Unit>();
		/// <summary>
		/// name = units
		/// eType = #//Unit
		/// </summary>
		[JsonProperty("units")]
		public List<Unit> Units { get {return _units; } set { _units = value; } }

 	}

	/// <summary>
	
	/// TODO: Zuweisung mobiler Betriebsmittel je Linie
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ProductionLine
	/// </summary>
	public partial class ProductionLine : WorkCenter
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ProductionLine"; } }

		public ProductionLine() : base()
		{		
		}

		private List<WorkCell> _workCells = new List<WorkCell>();
		/// <summary>
		/// name = workCells
		/// eType = #//WorkCell
		/// </summary>
		[JsonProperty("workCells")]
		public List<WorkCell> WorkCells { get {return _workCells; } set { _workCells = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//StorageZone
	/// </summary>
	public partial class StorageZone : WorkCenter
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//StorageZone"; } }

		public StorageZone() : base()
		{		
		}

		private List<StorageUnit> _storageUnits = new List<StorageUnit>();
		/// <summary>
		/// name = storageUnits
		/// eType = #//StorageUnit
		/// </summary>
		[JsonProperty("storageUnits")]
		public List<StorageUnit> StorageUnits { get {return _storageUnits; } set { _storageUnits = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//WorkUnit
	/// </summary>
	public abstract partial class WorkUnit : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//WorkUnit"; } }

		public WorkUnit() : base()
		{		
		}

		private List<EquipmentModule> _equipmentModules = new List<EquipmentModule>();
		/// <summary>
		/// name = equipmentModules
		/// eType = #//EquipmentModule
		/// </summary>
		[JsonProperty("equipmentModules")]
		public List<EquipmentModule> EquipmentModules { get {return _equipmentModules; } set { _equipmentModules = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Unit
	/// </summary>
	public partial class Unit : WorkUnit
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Unit"; } }

		public Unit() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//WorkCell
	/// </summary>
	public partial class WorkCell : WorkUnit
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//WorkCell"; } }

		public WorkCell() : base()
		{		
		}

		private Station _stations;
		/// <summary>
		/// name = stations
		/// eType = #//Station
		/// </summary>
		[JsonProperty("stations")]
		public Station Stations { get {return _stations; } set { _stations = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//StorageUnit
	/// </summary>
	public partial class StorageUnit : WorkUnit
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//StorageUnit"; } }

		public StorageUnit() : base()
		{		
		}

	}

	/// <summary>
	
	/// Ehemals ResourceInstance, TODO: mobile Betriebsmittel, z.B. Cobots
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//EquipmentModule
	/// </summary>
	public partial class EquipmentModule : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//EquipmentModule"; } }

		public EquipmentModule() : base()
		{		
		}

		private List<ControlModule> _controlModules = new List<ControlModule>();
		/// <summary>
		/// name = controlModules
		/// eType = #//ControlModule
		/// </summary>
		[JsonProperty("controlModules")]
		public List<ControlModule> ControlModules { get {return _controlModules; } set { _controlModules = value; } }

 		private List<EquipmentModule> _equipmentModules = new List<EquipmentModule>();
		/// <summary>
		/// name = equipmentModules
		/// eType = #//EquipmentModule
		/// </summary>
		[JsonProperty("equipmentModules")]
		public List<EquipmentModule> EquipmentModules { get {return _equipmentModules; } set { _equipmentModules = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ControlModule
	/// </summary>
	public partial class ControlModule : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ControlModule"; } }

		public ControlModule() : base()
		{		
		}

		private List<ControlModule> _controlModules = new List<ControlModule>();
		/// <summary>
		/// name = controlModules
		/// eType = #//ControlModule
		/// </summary>
		[JsonProperty("controlModules")]
		public List<ControlModule> ControlModules { get {return _controlModules; } set { _controlModules = value; } }

 	}

	/// <summary>
	
	/// Logische Unterteilung einer Linie in Abschnitte. Gibts so noch nicht in ISA95.
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ProductionLineSection
	/// </summary>
	public partial class ProductionLineSection
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ProductionLineSection"; } }


	}

	/// <summary>
	
	/// Äquivalent zu oder Spezialisierung zu WorkCell?
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Station
	/// </summary>
	public partial class Station
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Station"; } }


		private List<EquipmentModule> _equipmentModules = new List<EquipmentModule>();
		/// <summary>
		/// name = equipmentModules
		/// eType = #//EquipmentModule
		/// </summary>
		[JsonProperty("equipmentModules")]
		public List<EquipmentModule> EquipmentModules { get {return _equipmentModules; } set { _equipmentModules = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Transition
	/// </summary>
	public partial class Transition
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Transition"; } }


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

 		private float _distance;
		/// <summary>
		/// name = distance
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EFloat
		/// </summary>
		[JsonProperty("distance")]
		public float Distance { get {return _distance; } set { _distance = value; } }

 	}


#endregion

#region EnumDefintions


#endregion

} //namespace
