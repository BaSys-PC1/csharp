 
using System;
using System.Collections.Generic;
using System.Reflection;

using Newtonsoft.Json;


/// <summary>
/// name = base
/// nsPrefix = base
/// nsURI = http://www.dfki.de/iui/basys/base
/// </summary>
namespace Basys.Model.Base
{

#region Classes

	/// <summary>
	
	/// Weitere Attribute: für wen? cachable? 
	/// eClass = http://www.dfki.de/iui/basys/base#//Metadata
	/// </summary>
	public partial class Metadata
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/base#//Metadata"; } }


		private string _creator;
		/// <summary>
		/// Welcher Dienst hat das Objekt erzeugt?
		/// name = creator
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("creator")]
		public string Creator { get {return _creator; } set { _creator = value; } }

 		private DateTime _creationDate;
		/// <summary>
		/// Wann wurde das Object erzeugt?
		/// name = creationDate
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("creationDate")]
		public DateTime CreationDate { get {return _creationDate; } set { _creationDate = value; } }

 		private DateTime _expiryDate;
		/// <summary>
		/// Wie lange ist das Object gültig?
		/// name = expiryDate
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EDate
		/// </summary>
		[JsonProperty("expiryDate")]
		public DateTime ExpiryDate { get {return _expiryDate; } set { _expiryDate = value; } }

 	}

	/// <summary>
	
	/// BaSys-Basisklasse, TODO: weitere klassen hiervon ableiten, Metadata wird dann automatisch gesetzt.
	/// eClass = http://www.dfki.de/iui/basys/base#//Entity
	/// </summary>
	public partial class Entity
	{
	 
		[JsonProperty("eClass")]
		public virtual string EcoreClass { get {return "http://www.dfki.de/iui/basys/base#//Entity"; } }


		private Metadata _metadata;
		/// <summary>
		/// name = metadata
		/// eType = #//Metadata
		/// </summary>
		[JsonProperty("metadata")]
		public Metadata Metadata { get {return _metadata; } set { _metadata = value; } }

 	}

	/// <summary>
	/// eClass = http://www.dfki.de/iui/basys/base#//IdentifiableEntity
	/// </summary>
	public partial class IdentifiableEntity : Entity
	{
	 
		[JsonProperty("eClass")]
		public override string EcoreClass { get {return "http://www.dfki.de/iui/basys/base#//IdentifiableEntity"; } }

		public IdentifiableEntity() : base()
		{		
		}

		private string _id;
		/// <summary>
		/// name = id
		/// eType = ecore:EDataType http://www.eclipse.org/emf/2002/Ecore#//EString
		/// </summary>
		[JsonProperty("id")]
		public string Id { get {return _id; } set { _id = value; } }

 	}


#endregion

#region EnumDefintions


#endregion

} //namespace
