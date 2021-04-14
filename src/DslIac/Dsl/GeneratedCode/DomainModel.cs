﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Variamos.IacTemplateGenerator.IacLanguage
{
	/// <summary>
	/// DomainModel IacLanguageDomainModel
	/// Description for Variamos.IacTemplateGenerator.IacLanguage.IacLanguage
	/// </summary>
	[DslDesign::DisplayNameResource("Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel.DisplayName", typeof(global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel), "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel.Description", typeof(global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel), "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("9ac27611-e568-4e3b-a9e3-d6734baf1af7")]
	public partial class IacLanguageDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// IacLanguageDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x9ac27611, 0xe568, 0x4e3b, 0xa9, 0xe3, 0xd6, 0x73, 0x4b, 0xaf, 0x1a, 0xf7);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public IacLanguageDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(IacModel),
				typeof(Vm),
				typeof(AzureComponent),
				typeof(NetworkInterface),
				typeof(IacModelHasVms),
				typeof(IacModelHasNetworkInterfaced),
				typeof(VmReferencesNetworkInterfaced),
				typeof(IacLanguageDiagram),
				typeof(VmNetworkInterfaceConnector),
				typeof(VmShape),
				typeof(NetworkInterfaceShape),
				typeof(global::Variamos.IacTemplateGenerator.IacLanguage.FixUpDiagram),
				typeof(global::Variamos.IacTemplateGenerator.IacLanguage.DecoratorPropertyChanged),
				typeof(global::Variamos.IacTemplateGenerator.IacLanguage.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(IacModel), "name", IacModel.nameDomainPropertyId, typeof(IacModel.namePropertyHandler)),
				new DomainMemberInfo(typeof(IacModel), "cloudProvider", IacModel.cloudProviderDomainPropertyId, typeof(IacModel.cloudProviderPropertyHandler)),
				new DomainMemberInfo(typeof(IacModel), "resourceGroup", IacModel.resourceGroupDomainPropertyId, typeof(IacModel.resourceGroupPropertyHandler)),
				new DomainMemberInfo(typeof(Vm), "vmSize", Vm.vmSizeDomainPropertyId, typeof(Vm.vmSizePropertyHandler)),
				new DomainMemberInfo(typeof(AzureComponent), "name", AzureComponent.nameDomainPropertyId, typeof(AzureComponent.namePropertyHandler)),
				new DomainMemberInfo(typeof(AzureComponent), "label", AzureComponent.labelDomainPropertyId, typeof(AzureComponent.labelPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(IacModelHasVms), "IacModel", IacModelHasVms.IacModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(IacModelHasVms), "Vm", IacModelHasVms.VmDomainRoleId),
				new DomainRolePlayerInfo(typeof(IacModelHasNetworkInterfaced), "IacModel", IacModelHasNetworkInterfaced.IacModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(IacModelHasNetworkInterfaced), "NetworkInterface", IacModelHasNetworkInterfaced.NetworkInterfaceDomainRoleId),
				new DomainRolePlayerInfo(typeof(VmReferencesNetworkInterfaced), "Vm", VmReferencesNetworkInterfaced.VmDomainRoleId),
				new DomainRolePlayerInfo(typeof(VmReferencesNetworkInterfaced), "NetworkInterface", VmReferencesNetworkInterfaced.NetworkInterfaceDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(8);
				createElementMap.Add(typeof(IacModel), 0);
				createElementMap.Add(typeof(Vm), 1);
				createElementMap.Add(typeof(NetworkInterface), 2);
				createElementMap.Add(typeof(IacLanguageDiagram), 3);
				createElementMap.Add(typeof(VmNetworkInterfaceConnector), 4);
				createElementMap.Add(typeof(VmShape), 5);
				createElementMap.Add(typeof(NetworkInterfaceShape), 6);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new IacModel(partition, propertyAssignments);
				case 1: return new Vm(partition, propertyAssignments);
				case 2: return new NetworkInterface(partition, propertyAssignments);
				case 3: return new IacLanguageDiagram(partition, propertyAssignments);
				case 4: return new VmNetworkInterfaceConnector(partition, propertyAssignments);
				case 5: return new VmShape(partition, propertyAssignments);
				case 6: return new NetworkInterfaceShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(3);
				createElementLinkMap.Add(typeof(IacModelHasVms), 0);
				createElementLinkMap.Add(typeof(IacModelHasNetworkInterfaced), 1);
				createElementLinkMap.Add(typeof(VmReferencesNetworkInterfaced), 2);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new IacModelHasVms(partition, roleAssignments, propertyAssignments);
				case 1: return new IacModelHasNetworkInterfaced(partition, roleAssignments, propertyAssignments);
				case 2: return new VmReferencesNetworkInterfaced(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return IacLanguageDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (IacLanguageDomainModel.resourceManager == null)
				{
					IacLanguageDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(IacLanguageDomainModel).Assembly);
				}
				return IacLanguageDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return IacLanguageDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return IacLanguageDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (IacLanguageDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new IacLanguageCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					IacLanguageDomainModel.copyClosure = copyFilter;
				}
				return IacLanguageDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (IacLanguageDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new IacLanguageDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					IacLanguageDomainModel.removeClosure = removeFilter;
				}
				return IacLanguageDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.DecoratorPropertyChanged));
			ruleManager.EnableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.DecoratorPropertyChanged));
			ruleManager.DisableRule(typeof(global::Variamos.IacTemplateGenerator.IacLanguage.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class IacLanguageDeleteClosure : IacLanguageDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public IacLanguageDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class IacLanguageDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public IacLanguageDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Variamos.IacTemplateGenerator.IacLanguage.IacModelHasVms.VmDomainRoleId, true);
			DomainRoles.Add(global::Variamos.IacTemplateGenerator.IacLanguage.IacModelHasNetworkInterfaced.NetworkInterfaceDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class IacLanguageCopyClosure : IacLanguageCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public IacLanguageCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class IacLanguageCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public IacLanguageCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
namespace Variamos.IacTemplateGenerator.IacLanguage
{
	/// <summary>
	/// DomainEnumeration: CloudProviderEnumerator
	/// Description for
	/// Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum CloudProviderEnumerator
	{
		/// <summary>
		/// Azure
		/// Description for
		/// Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.Azure
		/// </summary>
		[DslDesign::DescriptionResource("Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator/Azure.Description", typeof(global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel), "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx")]
		Azure = 0,
		/// <summary>
		/// AWS
		/// Description for
		/// Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.AWS
		/// </summary>
		[DslDesign::DescriptionResource("Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator/AWS.Description", typeof(global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel), "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx")]
		AWS = 1,
		/// <summary>
		/// gpc
		/// Description for
		/// Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator.gpc
		/// </summary>
		[DslDesign::DescriptionResource("Variamos.IacTemplateGenerator.IacLanguage.CloudProviderEnumerator/gpc.Description", typeof(global::Variamos.IacTemplateGenerator.IacLanguage.IacLanguageDomainModel), "Variamos.IacTemplateGenerator.IacLanguage.GeneratedCode.DomainModelResx")]
		gpc = 2,
	}
}
