 
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

		private List<WorkCenter> _workCenters = new List<WorkCenter>();
		/// <summary>
		/// name = workCenters
		/// eType = #//WorkCenter
		/// </summary>
		[JsonProperty("workCenters")]
		public List<WorkCenter> WorkCenters { get {return _workCenters; } set { _workCenters = value; } }

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

		private List<ProcessUnit> _processUnits = new List<ProcessUnit>();
		/// <summary>
		/// name = processUnits
		/// eType = #//ProcessUnit
		/// </summary>
		[JsonProperty("processUnits")]
		public List<ProcessUnit> ProcessUnits { get {return _processUnits; } set { _processUnits = value; } }

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

		private List<Station> _stations = new List<Station>();
		/// <summary>
		/// name = stations
		/// eType = #//Station
		/// </summary>
		[JsonProperty("stations")]
		public List<Station> Stations { get {return _stations; } set { _stations = value; } }

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
	public abstract partial class EquipmentModule : Basys.Model.Base.IdentifiableEntity
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
		/// Unscharf: DiscManufacturingEquipmentModule kann einfache EquipmentModules enthalten.
		/// name = equipmentModules
		/// eType = #//EquipmentModule
		/// </summary>
		[JsonProperty("equipmentModules")]
		public List<EquipmentModule> EquipmentModules { get {return _equipmentModules; } set { _equipmentModules = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ControlModule
	/// </summary>
	public abstract partial class ControlModule : Basys.Model.Base.IdentifiableEntity
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
	
	/// Äquivalent zu oder Spezialisierung zu WorkCell?
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Station
	/// </summary>
	public partial class Station : Basys.Model.Base.IdentifiableEntity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Station"; } }

		public Station() : base()
		{		
		}

		private List<DiscreteManufacturingEquipmentModule> _equipmentModules = new List<DiscreteManufacturingEquipmentModule>();
		/// <summary>
		/// name = equipmentModules
		/// eType = #//DiscreteManufacturingEquipmentModule
		/// </summary>
		[JsonProperty("equipmentModules")]
		public List<DiscreteManufacturingEquipmentModule> EquipmentModules { get {return _equipmentModules; } set { _equipmentModules = value; } }

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

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//AssemblyStation
	/// </summary>
	public partial class AssemblyStation : Station
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//AssemblyStation"; } }

		public AssemblyStation() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//BufferStation
	/// </summary>
	public partial class BufferStation : Station
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//BufferStation"; } }

		public BufferStation() : base()
		{		
		}

		private int _capacity;
		/// <summary>
		/// name = capacity
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EInt
		/// </summary>
		[JsonProperty("capacity")]
		public int Capacity { get {return _capacity; } set { _capacity = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ProcessUnit
	/// </summary>
	public partial class ProcessUnit : WorkUnit
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ProcessUnit"; } }

		public ProcessUnit() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//DiscreteManufacturingEquipmentModule
	/// </summary>
	public partial class DiscreteManufacturingEquipmentModule : EquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//DiscreteManufacturingEquipmentModule"; } }

		public DiscreteManufacturingEquipmentModule() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Tool
	/// </summary>
	public partial class Tool : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Tool"; } }

		public Tool() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//StationaryTool
	/// </summary>
	public partial class StationaryTool : Tool
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//StationaryTool"; } }

		public StationaryTool() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//MovableTool
	/// </summary>
	public partial class MovableTool : Tool
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//MovableTool"; } }

		public MovableTool() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Transport
	/// </summary>
	public partial class Transport : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Transport"; } }

		public Transport() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Storage
	/// </summary>
	public partial class Storage : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Storage"; } }

		public Storage() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Fixture
	/// </summary>
	public partial class Fixture : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Fixture"; } }

		public Fixture() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Gate
	/// </summary>
	public partial class Gate : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Gate"; } }

		public Gate() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Robot
	/// </summary>
	public partial class Robot : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Robot"; } }

		public Robot() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Carrier
	/// </summary>
	public partial class Carrier : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Carrier"; } }

		public Carrier() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Machine
	/// </summary>
	public partial class Machine : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Machine"; } }

		public Machine() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//StaticObject
	/// </summary>
	public partial class StaticObject : DiscreteManufacturingEquipmentModule
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//StaticObject"; } }

		public StaticObject() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Turnable
	/// </summary>
	public partial class Turnable : HorizontalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Turnable"; } }

		public Turnable() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Conveyor
	/// </summary>
	public partial class Conveyor : HorizontalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Conveyor"; } }

		public Conveyor() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//LiftingTable
	/// </summary>
	public partial class LiftingTable : VerticalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//LiftingTable"; } }

		public LiftingTable() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//AVG
	/// </summary>
	public partial class AVG : HorizontalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//AVG"; } }

		public AVG() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Transposer
	/// </summary>
	public partial class Transposer : Transport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Transposer"; } }

		public Transposer() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//CarrierHandlingSystem
	/// </summary>
	public partial class CarrierHandlingSystem : Transport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//CarrierHandlingSystem"; } }

		public CarrierHandlingSystem() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Lift
	/// </summary>
	public partial class Lift : VerticalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Lift"; } }

		public Lift() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//VerticalTransport
	/// </summary>
	public partial class VerticalTransport : Transport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//VerticalTransport"; } }

		public VerticalTransport() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//HorizontalTransport
	/// </summary>
	public partial class HorizontalTransport : Transport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//HorizontalTransport"; } }

		public HorizontalTransport() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Rollerbed
	/// </summary>
	public partial class Rollerbed : HorizontalTransport
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Rollerbed"; } }

		public Rollerbed() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Loader
	/// </summary>
	public partial class Loader : Storage
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Loader"; } }

		public Loader() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Unloader
	/// </summary>
	public partial class Unloader : Storage
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Unloader"; } }

		public Unloader() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//BodyStore
	/// </summary>
	public partial class BodyStore : Storage
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//BodyStore"; } }

		public BodyStore() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//Clamp
	/// </summary>
	public partial class Clamp : Fixture
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//Clamp"; } }

		public Clamp() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//BeltConveyor
	/// </summary>
	public partial class BeltConveyor : Conveyor
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//BeltConveyor"; } }

		public BeltConveyor() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//RollConveyor
	/// </summary>
	public partial class RollConveyor : Conveyor
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//RollConveyor"; } }

		public RollConveyor() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//ChainConveyor
	/// </summary>
	public partial class ChainConveyor : Conveyor
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//ChainConveyor"; } }

		public ChainConveyor() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//PalletConveyor
	/// </summary>
	public partial class PalletConveyor : Conveyor
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//PalletConveyor"; } }

		public PalletConveyor() : base()
		{		
		}

	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/model/topology#//OverheadConveyor
	/// </summary>
	public partial class OverheadConveyor : Conveyor
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/model/topology#//OverheadConveyor"; } }

		public OverheadConveyor() : base()
		{		
		}

	}


#endregion

#region EnumDefintions


#endregion

} //namespace
